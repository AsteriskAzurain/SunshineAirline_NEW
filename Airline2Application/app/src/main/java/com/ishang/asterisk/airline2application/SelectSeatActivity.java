package com.ishang.asterisk.airline2application;

import android.content.Intent;
import android.speech.tts.TextToSpeech;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.TextView;

public class SelectSeatActivity extends AppCompatActivity {

    int fltid;
    String aircraft;
    TextView tv_deptime, tv_fltnum, tv_plane, tv_cabin;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_select_seat);

        Intent intent = getIntent();
        String deptime = intent.getStringExtra("depdate");
        String fltnum = intent.getStringExtra("fltnum");
        String aircraft = intent.getStringExtra("aircraft");
        String cabintype = intent.getStringExtra("cabintype");

    }
}
