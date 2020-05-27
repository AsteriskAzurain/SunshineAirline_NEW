package com.ishang.asterisk.airlinetestapplication;

import android.content.Intent;
import android.os.Looper;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.LinearLayout;
import android.widget.TextView;

import com.ishang.asterisk.airlinetestapplication.global.GlobalVariable;

import org.json.JSONArray;
import org.json.JSONObject;

import java.io.ByteArrayOutputStream;
import java.io.InputStream;
import java.net.HttpURLConnection;
import java.net.URL;
import java.text.SimpleDateFormat;
import java.util.Date;

public class SearchResultActivity extends AppCompatActivity {

    LinearLayout linearLayout;
    TextView tv_total;
    Button btn_back;

    String requrl, cabintype;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_search_result);

        Intent intent = getIntent();
        requrl = intent.getStringExtra("requrl");
        cabintype= GlobalVariable.getCabintype();

        btn_back = (Button) findViewById(R.id.btn_back_rst);
        btn_back.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                finish();
            }
        });

        loaddetail();
    }

    private void loaddetail() {
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
                    while ((len = is.read(buffer)) != -1) baos.write(buffer, 0, len);
                    String data = new String(baos.toByteArray());

                    Looper.prepare();
                    if (rescode == 200) {
                        linearLayout = (LinearLayout) findViewById(R.id.linear_rst);
                        JSONArray array = new JSONArray(data);

                        int n = array.length();
                        tv_total = (TextView) findViewById(R.id.tv_total_rst);
                        tv_total.setText("Total " + n + " flights");

                        for (int i = 0; i < n; i++) {
                            JSONObject obj = array.getJSONObject(i);
                            final int fltid = obj.getInt("Id");
                            String airline = obj.getString("AirlineName");
                            final String fltnum = obj.getString("FlightNumber");
                            double price = obj.getDouble("Price");
                            final String depstr = obj.getString("DepartureTime");
                            final String plane = obj.getString("Aircraft");
                            int avltkt = obj.getInt("AvailableTickets");

                            SimpleDateFormat sdf1 = new SimpleDateFormat("yyyy-MM-dd HH:mm");
                            SimpleDateFormat sdf2 = new SimpleDateFormat("yyyy-MM-dd");
                            SimpleDateFormat sdf3 = new SimpleDateFormat("HH:mm");
                            Date depdate = sdf1.parse(depstr);
                            String date = sdf2.format(depdate);
                            String time = sdf3.format(depdate);

                            final View view = View.inflate(SearchResultActivity.this, R.layout.flight_detail, null);
                            TextView t1 = (TextView) view.findViewById(R.id.tv_airline_d); t1.setText(airline);
                            TextView t2 = (TextView) view.findViewById(R.id.tv_fltnum_d); t2.setText(fltnum);
                            TextView t3 = (TextView) view.findViewById(R.id.tv_price_d); t3.setText("$"+String.format("%.2f",price));
                            TextView t4 = (TextView) view.findViewById(R.id.tv_cabin_d); t4.setText(cabintype);
                            TextView t5 = (TextView) view.findViewById(R.id.tv_plane_d); t5.setText(plane);
                            TextView t6 = (TextView) view.findViewById(R.id.tv_date_d); t6.setText(date);
                            TextView t7 = (TextView) view.findViewById(R.id.tv_time_d); t7.setText(time);
                            TextView t8 = (TextView) view.findViewById(R.id.tv_avltkt_d); t8.setText(avltkt+" available tickeets");

                            linearLayout.addView(view);

                            runOnUiThread(new Runnable() {
                                @Override
                                public void run() {
                                    if(cabintype.equals("First")){
                                        view.setOnClickListener(new View.OnClickListener() {
                                            @Override
                                            public void onClick(View view) {
                                                Intent intent = new Intent(SearchResultActivity.this, SelectSeatActivity.class);
                                                intent.putExtra("fltid",fltid);
                                                intent.putExtra("deptime",depstr);
                                                intent.putExtra("fltnum",fltnum);
                                                intent.putExtra("plane",plane);
                                                startActivity(intent);
                                            }
                                        });
                                    }
                                }
                            });

                        }

                    }
                    Looper.loop();

                } catch (Exception e) {
                    System.out.println("error0527:" + e.toString());
                }

            }
        }.start();
    }
}
