package com.ishang.asterisk.airline;

import android.content.Intent;
import android.os.Looper;
import android.support.v4.view.ScrollingView;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.LinearLayout;
import android.widget.TextView;

import org.json.JSONArray;
import org.json.JSONObject;

import java.io.ByteArrayOutputStream;
import java.io.InputStream;
import java.net.HttpURLConnection;
import java.net.URL;
import java.text.SimpleDateFormat;
import java.util.Date;

public class SearchResultActivity extends AppCompatActivity {

    String requrl, cabintype;

    LinearLayout linearlayout;
    TextView tv_total;
    Button btn_back;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_search_result);

        getflights();

        linearlayout = (LinearLayout) findViewById(R.id.linear_layout_result);
        tv_total = (TextView) findViewById(R.id.tv_total_result);
        btn_back = (Button) findViewById(R.id.btn_back_result);

        btn_back.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                finish();
            }
        });

    }

    private void getflights() {
        Intent req = getIntent();
        requrl = req.getStringExtra("requrl");
        cabintype = req.getStringExtra("cabintype");

        new Thread() {
            @Override
            public void run() {
                try {
                    URL url = new URL(requrl);
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
                        tv_total.setText("Total "+array.length()+" flights");
                        for (int i = 0; i < array.length(); i++) {
                            JSONObject object = array.getJSONObject(i);
                            int fltid = object.getInt("Id");
                            String airline = object.getString("AirlineName");
                            String fltnum = object.getString("FlightNumber");
                            int price = object.getInt("Price");
                            String depdatestr = object.getString("DepartureTime");
                            String plane = object.getString("Aircraft");
                            int avls = object.getInt("AvailableTickets");

                            SimpleDateFormat sdf1 = new SimpleDateFormat("yyyy-MM-dd HH:mm");
                            SimpleDateFormat sdf2 = new SimpleDateFormat("yyyy-MM-dd");
                            SimpleDateFormat sdf3 = new SimpleDateFormat("HH:mm");
                            Date depdate = sdf1.parse(depdatestr);
                            String date = sdf2.format(depdate);
                            String time = sdf3.format(depdate);

                            View card = View.inflate(getApplicationContext(), R.layout.detail_card, null);
                            TextView tv1 = (TextView) card.findViewById(R.id.tv_d_airline); tv1.setText(airline);
                            TextView tv2 = (TextView) card.findViewById(R.id.tv_d_avls); tv2.setText(avls+" avaliable tickets");
                            TextView tv3 = (TextView) card.findViewById(R.id.tv_d_fltnum); tv3.setText(fltnum);
                            TextView tv4 = (TextView) card.findViewById(R.id.tv_d_price); tv4.setText("$"+price+".00");
                            TextView tv5 = (TextView) card.findViewById(R.id.tv_d_cabin); tv5.setText(cabintype);
                            TextView tv6 = (TextView) card.findViewById(R.id.tv_d_plane); tv6.setText(plane);
                            TextView tv7 = (TextView) card.findViewById(R.id.tv_d_date); tv7.setText(date);
                            TextView tv8 = (TextView) card.findViewById(R.id.tv_d_time); tv8.setText(time);

                            if(cabintype.equals("First")){
                                card.setOnClickListener(new View.OnClickListener() {
                                    @Override
                                    public void onClick(View view) {
                                        Intent intent=new Intent(SearchResultActivity.this,SelectSeatActivity.class);
                                        startActivity(intent);
                                    }
                                });
                            }

                            linearlayout.addView(card);
                        }

                    }
                    Looper.loop();
                } catch (Exception e) {
                    e.printStackTrace();
                }
            }
        }.start();
    }


}
