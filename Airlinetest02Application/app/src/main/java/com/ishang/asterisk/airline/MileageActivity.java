package com.ishang.asterisk.airline;

import android.content.Intent;
import android.os.Looper;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.text.TextUtils;
import android.view.View;
import android.widget.Button;
import android.widget.TableLayout;
import android.widget.TableRow;
import android.widget.TextView;

import com.ishang.asterisk.airline.global.GlobalVarible;

import org.json.JSONArray;
import org.json.JSONObject;

import java.io.ByteArrayOutputStream;
import java.io.InputStream;
import java.net.HttpURLConnection;
import java.net.URL;

import static com.ishang.asterisk.airline.R.id.table_mile;

public class MileageActivity extends AppCompatActivity {

    int userid;

    TextView tv_hi, tv_points;
    TableLayout tableLayout;
    Button btn_back;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_mileage);

        userid = GlobalVarible.getUserid();

        tableLayout = (TableLayout) findViewById(table_mile);
        tv_hi = (TextView) findViewById(R.id.tvhi);
        tv_points = (TextView) findViewById(R.id.tv_total_point);
        btn_back = (Button) findViewById(R.id.btn_back_mile);

        tableLayout.setStretchAllColumns(true);
        tv_hi.setText("Hi, " + GlobalVarible.getUsername() + ", Your total mileage points is");

        btn_back.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent intent = new Intent(MileageActivity.this, MainActivity.class);
                startActivity(intent);
            }
        });

        getpointinfo();
    }

    private void getpointinfo() {
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
                    while ((len = is.read(buffer)) != -1) baos.write(buffer);
                    String data = new String(baos.toByteArray());

                    Looper.prepare();
                    if (rescode == 200) {
                        JSONArray array = new JSONArray(data);
                        int sum = 0;
                        for (int i = 0; i < array.length(); i++) {
                            JSONObject object = array.getJSONObject(i);

                            int point = object.getInt("Points");
                            sum += point;

                            TableRow row = new TableRow(getApplicationContext());
                            TextView tv1 = new TextView(getApplicationContext());
                            TextView tv2 = new TextView(getApplicationContext());

                            tv1.setText(point+" Points");
                            tv2.setText(object.getString("Date"));

                            row.addView(tv1);
                            row.addView(tv2);
                            tableLayout.addView(row);
                        }
                        tv_points.setText(sum+" Points");
                    }
                    Looper.loop();
                } catch (Exception e) {
                    e.printStackTrace();
                }
            }
        }.start();
    }
}
