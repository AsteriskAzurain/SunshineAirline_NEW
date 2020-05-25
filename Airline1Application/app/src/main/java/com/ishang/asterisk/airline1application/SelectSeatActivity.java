package com.ishang.asterisk.airline1application;

import android.content.Intent;
import android.media.Image;
import android.os.Looper;
import android.renderscript.ScriptGroup;
import android.support.v4.content.ContextCompat;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.TextView;
import android.widget.Toast;

import com.ishang.asterisk.airline1application.global.Globalvariable;

import org.json.JSONArray;
import org.json.JSONObject;

import java.io.ByteArrayOutputStream;
import java.io.InputStream;
import java.net.HttpURLConnection;
import java.net.URL;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class SelectSeatActivity extends AppCompatActivity {

    Button btn_submit, btn_back;
    TextView tv_deptime, tv_fltnum, tv_aircraft, tv_cabin;
    int avltkt, sumtkt;
    List<ImageView> seatimglist;

    int fltid;
    String fltnum,deptime,aircraft;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_select_seat);

        btn_submit = (Button) findViewById(R.id.btn_submit);
        btn_back= (Button) findViewById(R.id.btn_back_seat);
        tv_deptime = (TextView) findViewById(R.id.tv_deptime_seat);
        tv_fltnum= (TextView) findViewById(R.id.tv_fltnum_seat);
        tv_aircraft = (TextView) findViewById(R.id.tv_aircraft_seat);
        tv_cabin = (TextView) findViewById(R.id.tv_cabin_seat);

        Intent fltinfo = getIntent();
        fltid = fltinfo.getIntExtra("fltid",0);
        fltnum = fltinfo.getStringExtra("fltnum");
        deptime = fltinfo.getStringExtra("deptime");
        aircraft = fltinfo.getStringExtra("aircraft");
        avltkt = fltinfo.getIntExtra("avltkt",0);
        tv_deptime.setText(deptime);
        tv_fltnum.setText(fltnum);
        tv_aircraft.setText(aircraft);
        tv_cabin.setText(Globalvariable.getCabintype());

        setimgtag();

        loadseatdata(fltid);

        btn_back.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                finish();
            }
        });

        btn_submit.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                List<ImageView> chosenlist = new ArrayList<ImageView>();
                for(ImageView img : seatimglist){
                    String tag = img.getTag(R.id.tag_iv).toString();
                    if(tag.equals("chosen")){
                        chosenlist.add(img);
                    }
                }
                final int userid = Globalvariable.getUserid();
                for (ImageView img : chosenlist){
                    final String row = img.getTag(R.id.tag_row).toString();
                    final String col = img.getTag(R.id.tag_col).toString();
                    // TODO: 5/26/2020 22 android.os.NetworkOnMainThreadException: should use a thread to connect the internet 
                    new Thread(){
                        @Override
                        public void run() {
                            try{
                                String path = "http://10.0.2.2:5000/api/order?FlightId="+fltid+"&UserId="+userid+"&CabinType=first&ColumnName="+col+"&RowNumber="+row;
                                URL url = new URL(path);
                                HttpURLConnection connection = (HttpURLConnection) url.openConnection();
                                connection.setConnectTimeout(5000);
                                connection.setRequestMethod("POST");
                                int rescode = connection.getResponseCode();
                                InputStream is = connection.getInputStream();
                                ByteArrayOutputStream baos = new ByteArrayOutputStream();

                                int len =-1;
                                byte[] buffer = new byte[1024];
                                while ((len=is.read(buffer))!=-1) baos.write(buffer,0,len);
                                Looper.prepare();
                                if(rescode==200){
                                    System.out.println(row+col+" post succeed.");
//                                    loadseatdata(fltid);
                                }
                                Looper.loop();
                            }catch (Exception e){
                                System.out.println("fbw error: post seat data\t"+e.toString());
                            }
                        }
                    }.start();
                }

                Toast.makeText(SelectSeatActivity.this,"Booked succeed.",Toast.LENGTH_SHORT).show();
                recreate();
            }
        });
    }

    private void loadseatdata(final int fltid) {
        sumtkt=0;
        new Thread(){
            @Override
            public void run() {
                try{
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

                        for (int i=0; i<array.length(); i++){
                            JSONObject obj = array.getJSONObject(i);
                            int row = obj.getInt("RowNumber");
                            String col = obj.getString("ColumnName");
                            String id = "s"+row+col;
                            // TODO: 5/25/2020 18 find the img by the string id
                            // TODO: 5/25/2020 19 Exclude data not in scope
                            String[] cols = {"A","C","J","L"};
                            Boolean hascol = Arrays.asList(cols).contains(col);
                            Boolean hasrow = (aircraft.equals("Airbus 319"))?(row<=3?true:false):(row<=2?true:false);
                            if(hasrow && hascol){
                                final int imgid=getResources().getIdentifier(id,"id",getPackageName());

                                runOnUiThread(new Runnable() {
                                    @Override
                                    public void run() {
                                        ImageView img = (ImageView) findViewById(imgid);
                                        img.setTag(R.id.tag_iv,"occupied");
                                        img.setImageDrawable(ContextCompat.getDrawable(getApplicationContext(),R.drawable.chair_occupied));
                                        img.setClickable(false);
                                    }
                                });
                            }
                        }
                        for(ImageView img: seatimglist){
                            System.out.println(img.getTag(R.id.tag_row).toString()+img.getTag(R.id.tag_col).toString()+" : "+img.getTag(R.id.tag_iv).toString());
                        }
                    }
                    Looper.loop();
                }
                catch (Exception e){
                    System.out.println("fbw error : load seat data\t"+e.toString());
                }

            }
        }.start();

    }


    private void setimgtag() {
        seatimglist= new ArrayList<>();

        String[] cols = {"A","C","J","L"};
        for (int i=1; i<4; i++){
            for(String col :cols){
                String id = "s"+i+col;
                int imgid = getResources().getIdentifier(id,"id",getPackageName());
                ImageView img = (ImageView) findViewById(imgid);
                img.setTag(R.id.tag_row,i);
                img.setTag(R.id.tag_col,col);
                img.setTag(R.id.tag_iv,"available");
                // TODO: 5/26/2020 20 delete the seat img
                if((!aircraft.equals("Airbus 319"))&&i==3) {
                    TextView t1 = (TextView) findViewById(R.id.r3c0); t1.setText("");
                    TextView t2 = (TextView) findViewById(R.id.r3c7); t2.setText("");
                    img.setImageDrawable(null);
                    continue;
                }else{
                    seatimglist.add(img);

                }
            }
        }

    }

    public void onClick(View view){
        ImageView imgview=(ImageView)view;
        // TODO: 5/26/2020 21 after gettag it should be transferred to string
        switch (view.getTag(R.id.tag_iv).toString()){
            case "available":
                if(sumtkt<avltkt){
                    sumtkt++;
                    imgview.setImageDrawable(ContextCompat.getDrawable(getApplicationContext(),R.drawable.chair_yourchosen));
                    imgview.setTag(R.id.tag_iv,"chosen");
                }
                break;
            case "chosen":
                sumtkt--;
                imgview.setImageDrawable(ContextCompat.getDrawable(getApplicationContext(),R.drawable.chair_available));
                imgview.setTag(R.id.tag_iv,"available");
                break;
            default:break;
        }
    }

    public void test(){
        List<ImageView> testlist = new ArrayList<>();
        ImageView img1A = (ImageView) findViewById(R.id.s1A); img1A.setTag(R.id.tag_row,"1"); img1A.setTag(R.id.tag_col,"A"); testlist.add(img1A);
        ImageView img1C = (ImageView) findViewById(R.id.s1C); img1C.setTag(R.id.tag_row,"1"); img1C.setTag(R.id.tag_col,"C"); testlist.add(img1C);
        ImageView img1J = (ImageView) findViewById(R.id.s1J); img1J.setTag(R.id.tag_row,"1"); img1J.setTag(R.id.tag_col,"J"); testlist.add(img1J);
        ImageView img1L = (ImageView) findViewById(R.id.s1L); img1L.setTag(R.id.tag_row,"1"); img1L.setTag(R.id.tag_col,"L"); testlist.add(img1L);

        ImageView img2A = (ImageView) findViewById(R.id.s2A); img2A.setTag(R.id.tag_row,"2"); img2A.setTag(R.id.tag_col,"A"); testlist.add(img2A);
        ImageView img2C = (ImageView) findViewById(R.id.s2C); img2C.setTag(R.id.tag_row,"2"); img2C.setTag(R.id.tag_col,"C"); testlist.add(img2C);
        ImageView img2J = (ImageView) findViewById(R.id.s2J); img2J.setTag(R.id.tag_row,"2"); img2J.setTag(R.id.tag_col,"J"); testlist.add(img2J);
        ImageView img2L = (ImageView) findViewById(R.id.s2L); img2L.setTag(R.id.tag_row,"2"); img2L.setTag(R.id.tag_col,"L"); testlist.add(img2L);

        ImageView img3A = (ImageView) findViewById(R.id.s3A); img3A.setTag(R.id.tag_row,"3"); img3A.setTag(R.id.tag_col,"A");
        ImageView img3C = (ImageView) findViewById(R.id.s3C); img3C.setTag(R.id.tag_row,"3"); img3C.setTag(R.id.tag_col,"C");
        ImageView img3J = (ImageView) findViewById(R.id.s3J); img3J.setTag(R.id.tag_row,"3"); img3J.setTag(R.id.tag_col,"J");
        ImageView img3L = (ImageView) findViewById(R.id.s3L); img3L.setTag(R.id.tag_row,"3"); img3L.setTag(R.id.tag_col,"L");

        for(ImageView img: testlist){
            System.out.println(img.getTag(R.id.tag_row).toString()+img.getTag(R.id.tag_col).toString()+" : "+img.getTag(R.id.tag_iv).toString());
        }


        if(aircraft.equals("Airbus 319")){
            seatimglist.add(img3A);
            seatimglist.add(img3C);
            seatimglist.add(img3J);
            seatimglist.add(img3L);
        }else {
            img3A.setImageDrawable(null);
            img3C.setImageDrawable(null);
            img3J.setImageDrawable(null);
            img3L.setImageDrawable(null);
        }
    }
}
