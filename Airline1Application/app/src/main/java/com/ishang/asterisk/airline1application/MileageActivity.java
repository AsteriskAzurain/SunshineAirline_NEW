package com.ishang.asterisk.airline1application;

import android.content.Intent;
import android.os.Looper;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TableLayout;
import android.widget.TableRow;
import android.widget.TextView;
import android.widget.Toast;

import com.ishang.asterisk.airline1application.global.Globalvariable;

import org.json.JSONArray;
import org.json.JSONObject;

import java.io.ByteArrayOutputStream;
import java.io.InputStream;
import java.net.HttpURLConnection;
import java.net.URL;

public class MileageActivity extends AppCompatActivity {

    Button btn_back;
    TextView tv_guide, tv_sum;
    TableLayout tab_point;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_mileage);

        btn_back= (Button) findViewById(R.id.btn_back_mile);
        btn_back.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                // FIXME: 5/25/2020 use the function finish() may lead to the playing postion not be set
                // finish();
                Intent intent = new Intent(MileageActivity.this,MainActivity.class);
                startActivity(intent);
            }
        });

        String username = Globalvariable.getUsername();
        if(null==username || username.isEmpty()){
            Toast.makeText(MileageActivity.this,"you havenn't login yet.",Toast.LENGTH_SHORT).show();
            Intent intent = new Intent(MileageActivity.this, LoginActivity.class);
            startActivity(intent);
        }else {
            tv_guide = (TextView) findViewById(R.id.tv_username);
            tv_guide.setText("Hi,"+username+", Your total mileage points is");
            getdetail();
        }
    }

    private void getdetail() {

        final int userid = Globalvariable.getUserid();

        new Thread(){
            @Override
            public void run() {
                try{
                    String path ="http://10.0.2.2:5000/api/mileagepoints/"+userid;
                    URL url = new URL(path);
                    HttpURLConnection connection = (HttpURLConnection) url.openConnection();
                    connection.setConnectTimeout(5000);
                    connection.setRequestMethod("GET");
                    int rescode = connection.getResponseCode();
                    InputStream is = connection.getInputStream();
                    ByteArrayOutputStream baos = new ByteArrayOutputStream();

                    int len =-1;
                    byte[] buffer = new byte[1024];
                    while ((len = is.read(buffer))!=-1) baos.write(buffer,0,len);
                    String data = new String(baos.toByteArray());

                    Looper.prepare();
                    if(rescode==200){
                        tab_point= (TableLayout) findViewById(R.id.tab_point);
                        // TODO: 5/25/2020 10 set table row style
                        tab_point.setStretchAllColumns(true);

                        int sum=0 ;
                        JSONArray array = new JSONArray(data);
                        for (int i=0; i<array.length();i++){
                            JSONObject obj = array.getJSONObject(i);
                            // TODO: 5/25/2020 9 how to add a table row? notice that the params in the function
                            TableRow row= new TableRow(getApplicationContext());
                            TextView tv_point = new TextView(getApplicationContext());
                            TextView tv_date = new TextView(getApplicationContext());
                            int point = obj.getInt("Points");
                            sum+=point;
                            tv_point.setText(point+" Points");
                            tv_date.setText(obj.getString("Date"));
                            row.addView(tv_point);
                            row.addView(tv_date);
                            tab_point.addView(row);
                        }
                        tv_sum= (TextView) findViewById(R.id.tv_sumpoints);
                        tv_sum.setText(sum+" Points");

                    }
                    Looper.loop();
                }
                catch (Exception e){
                    System.out.println("fbw error: get mileage detail\t"+e.toString());
                }

            }
        }.start();

    }


}
