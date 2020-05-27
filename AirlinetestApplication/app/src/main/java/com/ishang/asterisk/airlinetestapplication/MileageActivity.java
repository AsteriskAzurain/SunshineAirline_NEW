package com.ishang.asterisk.airlinetestapplication;

import android.os.Bundle;
import android.os.Looper;
import android.support.v7.app.AppCompatActivity;
import android.view.View;
import android.widget.Button;
import android.widget.TableLayout;
import android.widget.TableRow;
import android.widget.TextView;

import com.ishang.asterisk.airlinetestapplication.global.GlobalVariable;

import org.json.JSONArray;
import org.json.JSONObject;

import java.io.ByteArrayOutputStream;
import java.io.InputStream;
import java.net.HttpURLConnection;
import java.net.URL;

public class MileageActivity extends AppCompatActivity {

    TableLayout tab_point;
    TextView tv_hi, tv_total;
    Button btn_back;

    int userid;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_mileage);

        userid = GlobalVariable.getUserid();

        tv_hi = (TextView) findViewById(R.id.tv_hi);
        tv_hi.setText("Hi, "+GlobalVariable.getUsername()+", Your total mileage points is");
        btn_back.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                finish();
            }
        });


        new Thread() {
            @Override
            public void run() {
                try {
                    String path = "http://10.0.2.2:5000/api/mileagepoints/" + userid;
                    URL url = new URL(path);
                    HttpURLConnection connection = (HttpURLConnection) url.openConnection();
                    connection.setConnectTimeout(5000);
                    connection.setRequestMethod("GET");
                    int rescode = connection.getResponseCode();
                    InputStream is = connection.getInputStream();
                    ByteArrayOutputStream baos = new ByteArrayOutputStream();

                    int len = -1;
                    byte[] buffer = new byte[1024];
                    while ((len = is.read(buffer)) != -1) baos.write(buffer, 0, len);
                    String data = new String(baos.toByteArray());

                    Looper.prepare();
                    if (rescode == 200) {
                        tab_point = (TableLayout) findViewById(R.id.tab_mile);
                        tab_point.setStretchAllColumns(true);
                        JSONArray array = new JSONArray(data);
                        int sum = 0;
                        for (int i = 0; i < array.length(); i++) {
                            JSONObject obj = array.getJSONObject(i);
                            TableRow row = new TableRow(getApplicationContext());
                            int point = obj.getInt("Points");
                            sum+=point;
                            String date = obj.getString("Date");
                            TextView t1= new TextView(getApplicationContext()); t1.setText(point+" Points");
                            TextView t2= new TextView(getApplicationContext()); t2.setText(date);
                            row.addView(t1);
                            row.addView(t2);
                            tab_point.addView(row);
                        }
                        tv_total = (TextView) findViewById(R.id.tv_total);
                        tv_total.setText(sum+" Points");
                    }
                    Looper.loop();

                } catch (Exception e) {
                    System.out.println("error0527 get mileage:" + e.toString());
                }

            }
        }.start();
    }
}
