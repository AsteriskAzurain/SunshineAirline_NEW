package com.ishang.asterisk.airlinetestapplication;

import android.content.Intent;
import android.os.Looper;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.TextView;

import com.ishang.asterisk.airlinetestapplication.global.GlobalVariable;

import org.json.JSONArray;
import org.json.JSONObject;

import java.io.ByteArrayOutputStream;
import java.io.InputStream;
import java.net.HttpURLConnection;
import java.net.URL;
import java.util.ArrayList;
import java.util.List;

public class SelectSeatActivity extends AppCompatActivity {

    TextView tv_deptime, tv_fltnum, tv_plane;
    Button btn_submit, btn_back;

    int fltid, userid;
    String deptime, fltnum, plane;
    List<ImageView> seatimglist;
    String[] cols ={"A","C","J","L"};

    int avltkt,sumtkt=0;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_select_seat);

        userid= GlobalVariable.getUserid();

        Intent intent = getIntent();
        fltid = intent.getIntExtra("fltid", 0);
        deptime = intent.getStringExtra("deptime");
        fltnum = intent.getStringExtra("fltnum");
        plane = intent.getStringExtra("plane");
        avltkt = intent.getIntExtra("avltkt", 0);

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

        btn_submit.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                for(ImageView img: seatimglist){
                    if(img.getTag(R.id.tag_iv).toString().equals("chosen")){
                        final String row = img.getTag(R.id.tag_row).toString();
                        final String col = img.getTag(R.id.tag_col).toString();
                        new Thread() {
                            @Override
                            public void run() {
                                try {
                                    String path = "http://10.0.2.2:5000/api/order?FlightId="+fltid+"&UserId="+userid+"&CabinType=first&ColumnName="+col+"&RowNumber="+row;
                                    URL url = new URL(path);
                                    HttpURLConnection connection = (HttpURLConnection) url.openConnection();
                                    connection.setConnectTimeout(5000);
                                    connection.setRequestMethod("POST");
                                    int rescode = connection.getResponseCode();
                                    InputStream is = connection.getInputStream();
                                    ByteArrayOutputStream baos = new ByteArrayOutputStream();

                                    int len = -1;
                                    byte[] buffer = new byte[1024];
                                    while ((len=is.read(buffer))!=-1) baos.write(buffer,0,len);
                                    String data = new String(baos.toByteArray());

                                    Looper.prepare();
                                    if(rescode==200){
                                        System.out.println(row+col+" post succeed.");
                                    }
                                    Looper.loop();

                                } catch (Exception e) {
                                    System.out.println("error0527:" + e.toString());
                                }

                            }
                        }.start();
                    }
                }
                recreate();
            }
        });
    }

    private void seatinit() {
        seatimglist = new ArrayList<>();
        for(int row=1; row<4; row++){
            for(String col:cols){
                String strid="s"+row+col;
                int ivid=getResources().getIdentifier(strid,"id",getPackageName());
                ImageView iv = (ImageView) findViewById(ivid);
                if(null!=iv){
                    iv.setImageResource(R.drawable.chair_available);
                    iv.setTag(R.id.tag_row,row);
                    iv.setTag(R.id.tag_col,col);
                    iv.setTag(R.id.tag_iv,"available");
                    if(row==3&&plane.equals("Boeing 737-800")) continue;
                    else seatimglist.add(iv);
                }
            }
        }
        System.out.println("img list size: "+seatimglist.size());
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
                            int ivid= getResources().getIdentifier(strid,"id",getPackageName());
                            ImageView iv= (ImageView) findViewById(ivid);
                            if(null!=iv){
                                iv.setImageResource(R.drawable.chair_occupied);
                                iv.setTag(R.id.tag_iv,"occupied");
                                iv.setClickable(false);
                            }
                        }
                    }
                    Looper.loop();

                } catch (Exception e) {
                    System.out.println("error0527:" + e.toString());
                }

            }
        }.start();
    }

    public void onClick(View view){
        ImageView img = (ImageView) view;
        String tag = view.getTag(R.id.tag_iv).toString();
        switch (tag){
            case "available":
                if(sumtkt<avltkt){
                    avltkt++;
                    img.setImageResource(R.drawable.chair_yourchosen);
                    img.setTag(R.id.tag_iv,"chosen");
                }
                break;
            case "chosen":
                sumtkt--;
                img.setImageResource(R.drawable.chair_available);
                img.setTag(R.id.tag_iv,"available");
                break;
            default:break;
        }
    }
}
