package com.ishang.asterisk.airline1application;

import android.content.Intent;
import android.os.Looper;
import android.support.v4.view.ScrollingView;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.LinearLayout;
import android.widget.TextView;

import com.ishang.asterisk.airline1application.global.Globalvariable;

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

    private String requrl, cabintype;
    LinearLayout layout_detail;
    Button btn_back;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_search_result);

        requrl=Globalvariable.getRequrl();
        cabintype=Globalvariable.getCabintype();

        layout_detail= (LinearLayout) findViewById(R.id.linear_detail);
        btn_back= (Button) findViewById(R.id.btn_back_rst);
        btn_back.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                finish();
            }
        });
        
        adddetailcard();
    }

    private void adddetailcard() {

        new Thread(){
            @Override
            public void run() {
                try {
                    URL url = new URL(requrl);
                    HttpURLConnection connection = (HttpURLConnection) url.openConnection();
                    connection.setConnectTimeout(5000);
                    connection.setRequestMethod("GET");
                    int rescode =connection.getResponseCode();
                    InputStream is = connection.getInputStream();
                    ByteArrayOutputStream baos = new ByteArrayOutputStream();

                    int len = -1;
                    byte[] buffer = new byte[1024];
                    while ((len=is.read(buffer))!=-1) baos.write(buffer,0,len);
                    String data = new String(baos.toByteArray());

                    Looper.prepare();
                    if(rescode==200){
                        JSONArray array = new JSONArray(data);

                        int num= array.length();
                        TextView texttotal=(TextView)findViewById(R.id.tv_total);
                        texttotal.setText("Total "+num+" flights");

                        for (int i=0; i<num; i++){
                            JSONObject obj = array.getJSONObject(i);
                            final int fltid = obj.getInt("Id");
                            String airline = obj.getString("AirlineName");
                            final String fltnum= obj.getString("FlightNumber");
                            double price = obj.getDouble("Price");
                            final String deptime = obj.getString("DepartureTime");
                            String arrtime = obj.getString("ArriveTime");
                            final String aircraft = obj.getString("Aircraft");
                            int avltkts=obj.getInt("AvailableTickets");

                            SimpleDateFormat sdf = new SimpleDateFormat("yyyy-MM-dd HH:mm");
                            Date depdate = sdf.parse(deptime);
                            SimpleDateFormat sdf2 = new SimpleDateFormat("yyyy-MM-dd");
                            SimpleDateFormat sdf3 = new SimpleDateFormat("HH:mm");
                            String date =sdf2.format(depdate);
                            String time = sdf3.format(depdate);

                            // TODO: 5/25/2020 17 create the detail layout file and transfer a view object
                            View detailview = View.inflate(getApplicationContext(),R.layout.flight_detail,null);
                            TextView tv1= ((TextView)detailview.findViewById(R.id.tv_airline));
                            tv1.setText(airline);
                            TextView tv2=((TextView)detailview.findViewById(R.id.tv_avls));
                            tv2.setText(avltkts+" avaliable tickets");
                            TextView tv3=((TextView)detailview.findViewById(R.id.tv_depdate));
                            tv3.setText(date);
                            TextView tv4=((TextView)detailview.findViewById(R.id.tv_fltnum));
                            tv4.setText(fltnum);
                            TextView tv5=((TextView)detailview.findViewById(R.id.tv_price));
                            tv5.setText("$"+String.format("%.2f", price));
                            TextView tv6=((TextView)detailview.findViewById(R.id.tv_cabin));
                            tv6.setText(cabintype);
                            TextView tv7=((TextView)detailview.findViewById(R.id.tv_aircraft));
                            tv7.setText(aircraft);
                            TextView tv8=((TextView)detailview.findViewById(R.id.tv_time));
                            tv8.setText(time);

                            layout_detail.addView(detailview);

                            if(cabintype.equals("First")){
                                detailview.setOnClickListener(new View.OnClickListener() {
                                    @Override
                                    public void onClick(View view) {
                                        Intent intent = new Intent(SearchResultActivity.this, SelectSeatActivity.class);
                                        intent.putExtra("fltid",fltid);
                                        intent.putExtra("fltnum",fltnum);
                                        intent.putExtra("deptime",deptime);
                                        intent.putExtra("aircraft",aircraft);
                                        startActivity(intent);
                                    }
                                });
                            }
                        }

                    }
                    Looper.loop();

                } catch (Exception e) {
                    System.out.println("fbw error: load flight detail\t"+e.toString());
                }
            }
        }.start();
    }
}
