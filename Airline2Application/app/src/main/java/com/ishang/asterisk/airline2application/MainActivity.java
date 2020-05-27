package com.ishang.asterisk.airline2application;

import android.content.Intent;
import android.net.Uri;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.MediaController;
import android.widget.VideoView;

import com.ishang.asterisk.airline2application.global.GlobalVariable;

public class MainActivity extends AppCompatActivity {

    VideoView videoView;
    MediaController mediaController;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        videoView = (VideoView) findViewById(R.id.videoView);
        mediaController = new MediaController(this);
        // TODO: 5/26/2020 3 set uri for videoview 
        String uri = "android.resource://"+getPackageName()+"/"+R.raw.video;
        videoView.setVideoURI(Uri.parse(uri));
        videoView.setMediaController(mediaController);
        mediaController.setMediaPlayer(videoView);
        videoView.start();
        setplayingpos();
    }

    public void onClick(View view){
        Intent intent;
        switch (view.getId()){
            case R.id.btn_search:
                GlobalVariable.setPlayingpot(videoView.getCurrentPosition());
                intent = new Intent(MainActivity.this, SearchFlightActivity.class);
                startActivity(intent);
                break;
            case R.id.btn_mile:
                GlobalVariable.setPlayingpot(videoView.getCurrentPosition());
                intent = new Intent(MainActivity.this, MileageActivity.class);
                startActivity(intent);
                break;
            case R.id.btn_logout:
                GlobalVariable.setUserid(0);
                GlobalVariable.setUseremail(null);
                GlobalVariable.setUsername(null);
                intent = new Intent(MainActivity.this, LoginActivity.class);
                startActivity(intent);
                break;
            default:break;
        }
    }

    private void setplayingpos() {
        videoView.seekTo(GlobalVariable.getPlayingpot());
    }

}
