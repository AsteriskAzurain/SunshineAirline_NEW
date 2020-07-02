package com.ishang.asterisk.airline;

import android.content.Intent;
import android.media.MediaPlayer;
import android.net.Uri;
import android.os.Looper;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.text.TextUtils;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.MediaController;
import android.widget.TextView;
import android.widget.VideoView;

import com.ishang.asterisk.airline.global.GlobalVarible;

import org.json.JSONArray;
import org.json.JSONObject;

import java.io.ByteArrayOutputStream;
import java.io.InputStream;
import java.net.HttpURLConnection;
import java.net.URL;

public class MainActivity extends AppCompatActivity {

    TextView textView;
    Button btn1,btn2,btn3;
    VideoView vv;
    MediaController mediaController;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        textView= (TextView) findViewById(R.id.tvsponsors);

        btn1= (Button) findViewById(R.id.btnsf);
        btn2= (Button) findViewById(R.id.btnmp);
        btn3= (Button) findViewById(R.id.btnlogout);

        vv= (VideoView) findViewById(R.id.videoView);
        mediaController=new MediaController(this);
        String uri="android.resource://"+getPackageName()+"/"+R.raw.video;
        vv.setVideoURI(Uri.parse(uri));
        vv.setMediaController(mediaController);
        mediaController.setMediaPlayer(vv);
        vv.start();

        vv.setOnPreparedListener(new MediaPlayer.OnPreparedListener() {
            @Override
            public void onPrepared(MediaPlayer mediaPlayer) {
                mediaPlayer.setLooping(true);
                mediaPlayer.start();
            }
        });

        int spot=GlobalVarible.getPlayingpot();
        if(spot==99999) {
            vv.seekTo(0);
            GlobalVarible.setPlayingpot(0);
        }
        else if(spot>0) vv.seekTo(spot);
        else{}

        getSponsors();

        setbtn();
    }

    public void getSponsors(){
        new Thread(){
            @Override
            public void run() {
                try{
                    String path="http://10.0.2.2:5000/api/sponsor/list";
                    URL url = new URL(path);
                    HttpURLConnection connection = (HttpURLConnection) url.openConnection();
                    connection.setConnectTimeout(5000);
                    connection.setRequestMethod("GET");
                    int rescode=connection.getResponseCode();
                    InputStream is = connection.getInputStream();
                    ByteArrayOutputStream baos=new ByteArrayOutputStream();

                    int len=-1;
                    byte[] buffer = new byte[1024];
                    while ((len=is.read(buffer))!=-1) baos.write(buffer);
                    String data = new String(baos.toByteArray());

                    Looper.prepare();
                    if(rescode==200){
                        JSONArray array=new JSONArray(data);
                        String sponinfo="Sponsors:";
                        for (int i=0; i<array.length();i++){
                            JSONObject object= array.getJSONObject(i);
                            sponinfo+=(object.getString("Name")+"     ");
                        }
                        textView.setText(sponinfo);
                        textView.setEllipsize(TextUtils.TruncateAt.MARQUEE);
                        textView.setSingleLine(true);
                        textView.setSelected(true);
                    }
                    Looper.loop();
                }catch (Exception e){
                    e.printStackTrace();
                }
            }
        }.start();
    }

    public void setbtn(){

        btn3.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                GlobalVarible.setUserid(0);
                GlobalVarible.setUsername(null);
                GlobalVarible.setUseremail(null);
                GlobalVarible.setPlayingpot(99999);
                Intent intent= new Intent(MainActivity.this, LoginActivity.class);
                startActivity(intent);
            }
        });

        btn1.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                GlobalVarible.setPlayingpot(vv.getCurrentPosition());
                Intent i1=new Intent(MainActivity.this,SearchFlightActivity.class);
                startActivity(i1);
            }
        });

        btn2.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                GlobalVarible.setPlayingpot(vv.getCurrentPosition());
                Intent i2=new Intent(MainActivity.this, MileageActivity.class);
                startActivity(i2);
            }
        });
    }
}
