package com.ishang.asterisk.airline2application;

import android.content.Intent;
import android.os.Looper;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.LinearLayout;
import android.widget.TextView;

import org.json.JSONArray;
import org.json.JSONObject;

import java.io.ByteArrayOutputStream;
import java.io.InputStream;
import java.net.HttpURLConnection;
import java.net.MalformedURLException;
import java.net.URL;
import java.text.SimpleDateFormat;
import java.util.Date;

public class SearchResultActivity extends AppCompatActivity {

    LinearLayout linearLayout;
    Button btn_back;
    TextView tv_total;

    String path, cabintype;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_search_result);

        final Intent intent = getIntent();
        path = intent.getStringExtra("reqstr");
        cabintype = intent.getStringExtra("cabintype");

        linearLayout = (LinearLayout) findViewById(R.id.linear_result);
        btn_back = (Button) findViewById(R.id.btn_back_rst);
        tv_total = (TextView) findViewById(R.id.tv_total);

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

                        JSONArray array = new JSONArray(data);
                        final int n = array.length();
                        tv_total.setText("Total "+n+" flights");
                        for (int i = 0; i < n; i++) {
                            JSONObject obj = array.getJSONObject(i);

                            final int id = obj.getInt("Id");
                            final String airline = obj.getString("AirlineName");
                            final String fltnum = obj.getString("FlightNumber");
                            final double price = obj.getDouble("Price");
                            final String depstr = obj.getString("DepartureTime");
                            final String aircraft = obj.getString("Aircraft");
                            final int avltkt = obj.getInt("AvailableTickets");

                            SimpleDateFormat sdf1=new SimpleDateFormat("yyyy-MM-dd HH:mm");
                            SimpleDateFormat sdf2=new SimpleDateFormat("yyyy-MM-dd");
                            SimpleDateFormat sdf3=new SimpleDateFormat("HH:mm");
                            Date depdate = sdf1.parse(depstr);
                            final String date = sdf2.format(depdate);
                            final String time = sdf3.format(depdate);

                            final View view = View.inflate(getApplicationContext(),R.layout.flight_detail,null);
                            TextView t1 = (TextView) view.findViewById(R.id.tv_airline_d); t1.setText(airline);
                            TextView t2 = (TextView) view.findViewById(R.id.tv_avltkt_d); t2.setText(avltkt + " available tickets");
                            TextView t3 = (TextView) view.findViewById(R.id.tv_fltnum); t3.setText(fltnum);
                            TextView t4 = (TextView) view.findViewById(R.id.tv_price); t4.setText("$"+String.format("%.2f",price));
                            TextView t5 = (TextView) view.findViewById(R.id.tv_cabin); t5.setText(cabintype);
                            TextView t6 = (TextView) view.findViewById(R.id.tv_aircraft); t6.setText(aircraft);
                            TextView t7 = (TextView) view.findViewById(R.id.tv_date_d); t7.setText(date);
                            TextView t8 = (TextView) view.findViewById(R.id.tv_time); t8.setText(time);

                            runOnUiThread(new Runnable() {
                                @Override
                                public void run() {
                                    linearLayout.addView(view);

                                    if(cabintype.equals("First")){
                                        view.setOnClickListener(new View.OnClickListener() {
                                            @Override
                                            public void onClick(View view) {
                                                Intent intent1 = new Intent(SearchResultActivity.this,SelectSeatActivity.class);
                                                intent1.putExtra("fltid",id);
                                                intent1.putExtra("depdate",depstr);
                                                intent1.putExtra("fltnum",fltnum);
                                                intent1.putExtra("aircraft",aircraft);
                                                intent1.putExtra("cabintype",cabintype);
                                                startActivity(intent1);
                                            }
                                        });
                                    }
                                }
                            });
                        }
                    }
                    Looper.loop();

                } catch (Exception e) {
                    Log.w("get flight result:", e.toString());
                }
            }
        }.start();
    }
}
