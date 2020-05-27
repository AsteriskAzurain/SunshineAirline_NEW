package com.ishang.asterisk.airlinetestapplication;

import android.content.Intent;
import android.media.MediaPlayer;
import android.net.Uri;
import android.os.Bundle;
import android.os.Looper;
import android.support.v7.app.AppCompatActivity;
import android.text.TextUtils;
import android.view.View;
import android.widget.MediaController;
import android.widget.TextView;
import android.widget.VideoView;

import com.ishang.asterisk.airlinetestapplication.global.GlobalVariable;

import org.json.JSONArray;
import org.json.JSONObject;

import java.io.ByteArrayOutputStream;
import java.io.InputStream;
import java.net.HttpURLConnection;
import java.net.URL;

public class MainActivity extends AppCompatActivity {

    VideoView videoView;
    MediaController mediaController;
    TextView tv_sponsor;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        videoView = (VideoView) findViewById(R.id.videoView);
        mediaController = new MediaController(this);
        String uri = "android.resource://" + getPackageName() + "/" + R.raw.video;
        videoView.setVideoURI(Uri.parse(uri));
        videoView.setMediaController(mediaController);
        mediaController.setMediaPlayer(videoView);
        videoView.start();
        videoView.seekTo(GlobalVariable.getPlayingpos());
        videoView.setOnPreparedListener(new MediaPlayer.OnPreparedListener() {
            @Override
            public void onPrepared(MediaPlayer mediaPlayer) {
                mediaPlayer.setLooping(true);
                mediaPlayer.start();
            }
        });

        tv_sponsor = (TextView) findViewById(R.id.tv_sponsor);
        getsponsor();
    }

    public void onClick(View view) {
        Intent intent;
        System.out.println(view.getId());
        switch (view.getId()) {
            case R.id.btn_search:
                GlobalVariable.setPlayingpos(videoView.getCurrentPosition());
                intent = new Intent(MainActivity.this, SearchFlightActivity.class);
                startActivity(intent);
                break;
            case R.id.btn_mile:
                GlobalVariable.setPlayingpos(videoView.getCurrentPosition());
                intent = new Intent(MainActivity.this, MileageActivity.class);
                startActivity(intent);
                break;
            case R.id.btn_logout:
                GlobalVariable.setUseremail(null);
                GlobalVariable.setUsername(null);
                GlobalVariable.setUserid(0);
                intent = new Intent(MainActivity.this, LoginActivity.class);
                startActivity(intent);
                break;
            default:break;
        }
    }


    private void getsponsor() {
        new Thread() {
            @Override
            public void run() {
                try {
                    String path = "http://10.0.2.2:5000/api/sponsor/list";
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
                        String sponsors="Sponsors:   ";
                        for (int i = 0; i < array.length(); i++) {
                            JSONObject obj = array.getJSONObject(i);
                            sponsors+=(obj.getString("Name")+"         ");
                        }
                        tv_sponsor.setText(sponsors);
                        tv_sponsor.setEllipsize(TextUtils.TruncateAt.MARQUEE);
                        tv_sponsor.setSingleLine(true);
                        tv_sponsor.setSelected(true);
                    }
                    Looper.loop();

                } catch (Exception e) {
                    System.out.println("error0527 get sponsor:" + e.toString());
                }

            }
        }.start();
    }


}
