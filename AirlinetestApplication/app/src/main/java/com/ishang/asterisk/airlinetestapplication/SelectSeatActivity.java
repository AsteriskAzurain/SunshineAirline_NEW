package com.ishang.asterisk.airlinetestapplication;

import android.content.Intent;
import android.os.Looper;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.TextView;

import org.json.JSONArray;
import org.json.JSONObject;

import java.io.ByteArrayOutputStream;
import java.io.InputStream;
import java.net.HttpURLConnection;
import java.net.URL;
import java.util.List;

public class SelectSeatActivity extends AppCompatActivity {

    TextView tv_deptime, tv_fltnum, tv_plane;
    Button btn_submit, btn_back;

    int fltid;
    String deptime, fltnum, plane;
    List<ImageView> seatimglist;
    String[] cols ={"A","C","J","L"};

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_select_seat);

        Intent intent = getIntent();
        fltid = intent.getIntExtra("fltid", 0);
        deptime = intent.getStringExtra("deptime");
        fltnum = intent.getStringExtra("fltnum");
        plane = intent.getStringExtra("plane");

        tv_deptime = (TextView) findViewById(R.id.tv_deptime_s);
        tv_fltnum = (TextView) findViewById(R.id.tv_fltnum_s);
        tv_plane = (TextView) findViewById(R.id.tv_plane_s);
        btn_submit = (Button) findViewById(R.id.btn_submit);
        btn_back = (Button) findViewById(R.id.btn_back_s);

        tv_deptime.setText(deptime);
        tv_fltnum.setText(fltnum);
        tv_plane.setText(plane);

        btn_back.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                finish();
            }
        });

        seatinit();

        loadseatdata();

        ImageView testimg = (ImageView) findViewById(R.id.s3C);
        System.out.println(testimg.getTag(R.id.tag_row).toString()+testimg.getTag(R.id.tag_col).toString()+" : "+testimg.getTag(R.id.tag_iv).toString());
    }

    private void seatinit() {
        for(int row=0; row<4; row++){
            for(String col:cols){
                String strid="s"+row+col;
                int ivid=getResources().getIdentifier(strid,"id",getPackageName());
                ImageView iv = (ImageView) findViewById(ivid);
                if(null!=iv){
                    iv.setImageResource(R.drawable.chair_available);
                    iv.setTag(R.id.tag_row,row);
                    iv.setTag(R.id.tag_col,col);
                    iv.setTag(R.id.tag_iv,"available");
                }
            }
        }
    }


    private void loadseatdata() {
        new Thread() {
            @Override
            public void run() {
                try {
                    String path = "http://10.0.2.2:5000/api/order?FlightId="+fltid+"&CabinType=first";
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
                        JSONArray array = new JSONArray(data);

                        for(int i=0; i<array.length();i++){
                            JSONObject obj = array.getJSONObject(i);
                            String row = obj.getString("RowNumber");
                            String col = obj.getString("ColumnName");
                            String strid="s"+row+col;
//                            ImageView iv
                        }
                        /*"FlightId": "2", "UserId": "1", "CabinType": "first", "ColumnName": "J", "RowNumber": "2"*/
                    }
                    Looper.loop();

                } catch (Exception e) {
                    System.out.println("error0527:" + e.toString());
                }

            }
        }.start();
    }
}
