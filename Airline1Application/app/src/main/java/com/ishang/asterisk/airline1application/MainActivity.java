package com.ishang.asterisk.airline1application;

import android.content.Intent;
import android.media.MediaPlayer;
import android.net.Uri;
import android.os.Looper;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.text.TextUtils;
import android.view.View;
import android.widget.Button;
import android.widget.MediaController;
import android.widget.TextView;
import android.widget.VideoView;

import com.ishang.asterisk.airline1application.global.Globalvariable;

import org.json.JSONArray;
import org.json.JSONObject;

import java.io.ByteArrayOutputStream;
import java.io.InputStream;
import java.net.HttpURLConnection;
import java.net.URL;

public class MainActivity extends AppCompatActivity {

    VideoView videoView ; MediaController mediacontroller;
    Button btn_search, btn_mile, btn_logout;
    TextView tv_sponsor;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        videoView = (VideoView) findViewById(R.id.vv_main);
        // TODO: 5/25/2020 5 how to band a video on vv?
        mediacontroller = new MediaController(this);
        String uri = "android.resource://"+getPackageName()+"/"+R.raw.video;
        videoView.setVideoURI(Uri.parse(uri));
        videoView.setMediaController(mediacontroller);
        mediacontroller.setMediaPlayer(videoView);
        videoView.requestFocus();
        videoView.start();
        // TODO: 5/25/2020 6 set a start position of vv
        videoView.seekTo(Globalvariable.getPlayingpos());
        // TODO: 5/25/2020 8 loop play video
        videoView.setOnPreparedListener(new MediaPlayer.OnPreparedListener() {
            @Override
            public void onPrepared(MediaPlayer mediaPlayer) {
                mediaPlayer.setLooping(true);
                mediaPlayer.start();
            }
        });

        getsponsorinfo();

    }

    public void onClick(View view){
        Intent intent;
        switch (view.getId()){
            case R.id.btn_search:
                Globalvariable.setPlayingpos(videoView.getCurrentPosition());
                intent = new Intent(MainActivity.this,SearchFlightActivity.class);
                startActivity(intent);
                break;
            case R.id.btn_mile:
                Globalvariable.setPlayingpos(videoView.getCurrentPosition());
                intent = new Intent(MainActivity.this, MileageActivity.class);
                startActivity(intent);
                break;
            case R.id.btn_logout:
                Globalvariable.setUserid(0);
                Globalvariable.setUseremail(null);
                Globalvariable.setUsername(null);
                intent = new Intent(MainActivity.this,LoginActivity.class);
                startActivity(intent);
                break;
            default:break;
        }

    }


    private void getsponsorinfo() {
        tv_sponsor = (TextView) findViewById(R.id.tv_sponsor);

        new Thread(){
            @Override
            public void run() {
                try{
                    String path ="http://10.0.2.2:5000/api/sponsor/list";
                    URL url =new URL(path);
                    HttpURLConnection connection = (HttpURLConnection) url.openConnection();
                    connection.setConnectTimeout(5000);
                    connection.setRequestMethod("GET");
                    int rescode = connection.getResponseCode();
                    InputStream is = connection.getInputStream();
                    ByteArrayOutputStream baos = new ByteArrayOutputStream();

                    int len = -1;
                    byte[] buffer = new byte[1024];
                    while ((len = is.read(buffer))!=-1){
                        baos.write(buffer,0,len);
                    }
                    String data = new String(baos.toByteArray());

                    Looper.prepare();
                    if(rescode==200){
                        JSONArray array = new JSONArray(data);
                        String spinfo="Sponsors:   ";
                        for (int i=0; i<array.length();i++){
                            JSONObject obj =array.getJSONObject(i);
                            spinfo+=(obj.getString("Name")+"         ");
                        }
                        tv_sponsor.setText(spinfo);
                        // TODO: 5/25/2020 7 Marquee effect of sponsors info
                        tv_sponsor.setEllipsize(TextUtils.TruncateAt.MARQUEE);
                        tv_sponsor.setSingleLine(true);
                        tv_sponsor.setSelected(true);
                        // FIXME: 5/25/2020 what's its use?
//                        tv_sponsor.setFocusable(true);
//                        tv_sponsor.setFocusableInTouchMode(true);
                    }
                    Looper.loop();



                }catch (Exception e){
                    System.out.println("fbw error: get sponsor info\t"+e.toString());
                }
            }
        }.start();
    }
}
