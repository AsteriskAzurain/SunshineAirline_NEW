package com.ishang.asterisk.airline2application;

import android.os.Looper;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.TableLayout;
import android.widget.TableRow;
import android.widget.TextView;

import com.ishang.asterisk.airline2application.global.GlobalVariable;

import org.json.JSONArray;
import org.json.JSONObject;

import java.io.ByteArrayOutputStream;
import java.io.InputStream;
import java.net.HttpURLConnection;
import java.net.URL;

public class MileageActivity extends AppCompatActivity {

    TextView tv_hi, tv_sum;
    TableLayout tab_mile;
    Button btn_back;
    int sum;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_mileage);

        tv_hi = (TextView) findViewById(R.id.tv_username);
        tv_sum = (TextView) findViewById(R.id.tv_sumpoint);
//        tab_mile = (TableLayout) findViewById(R.id.tab_mileage);
//        tab_mile.setStretchAllColumns(true);
        btn_back= (Button) findViewById(R.id.btn_back_mile);

        tv_hi.setText("Hi, "+GlobalVariable.getUsername()+", Your total milleage points is");
        btn_back.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                finish();
            }
        });

        final int userid = GlobalVariable.getUserid();
        new Thread(){
            @Override
            public void run() {
                try{
                    String path="http://10.0.2.2:5000/api/mileagepoints/"+userid;
                    URL url = new URL(path);
                    HttpURLConnection connection = (HttpURLConnection) url.openConnection();
                    connection.setConnectTimeout(5000);
                    connection.setRequestMethod("GET");
                    int rescode = connection.getResponseCode();
                    InputStream is = connection.getInputStream();
                    ByteArrayOutputStream baos = new ByteArrayOutputStream();

                    int len = -1;
                    byte[] buffer = new byte[1024];
                    while ((len=is.read(buffer))!=-1) baos.write(buffer,0,len);
                    String data = new String(baos.toByteArray());

                    Looper.prepare();
                    if(rescode==200){
                        // TODO: 5/26/2020 4 set stretch all columns should be put here
                        tab_mile = (TableLayout) findViewById(R.id.tab_mileage);
                        tab_mile.setStretchAllColumns(true);
                        JSONArray array = new JSONArray(data);
                        for (int i =0; i<array.length();i++){
                            JSONObject obj = array.getJSONObject(i);
                            final TableRow row = new TableRow(getApplicationContext());
                            TextView t1= new TextView(getApplicationContext());
                            TextView t2 = new TextView(getApplicationContext());
                            int point = obj.getInt("Points");
                            sum+=point;
                            t1.setText(point+" Points");
                            t2.setText(obj.getString("Date"));
                            row.addView(t1);
                            row.addView(t2);
                            runOnUiThread(new Runnable() {
                                @Override
                                public void run() {
                                    tab_mile.addView(row);
                                }
                            });
                        }
                        tv_sum.setText(sum + " Points");
                    }
                    Looper.loop();
                }catch (Exception e){
                    Log.w("get mileage detail",e.toString());
                }

            }
        }.start();

    }
}
