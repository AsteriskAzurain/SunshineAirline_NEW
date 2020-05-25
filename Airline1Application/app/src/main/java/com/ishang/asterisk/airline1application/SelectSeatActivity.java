package com.ishang.asterisk.airline1application;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.Button;
import android.widget.TextView;

import com.ishang.asterisk.airline1application.global.Globalvariable;

public class SelectSeatActivity extends AppCompatActivity {

    Button btn_submit, btn_back;
    TextView tv_deptime, tv_fltnum, tv_aircraft, tv_cabin;

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
        int fltid = fltinfo.getIntExtra("fltid",0);
        String fltnum = fltinfo.getStringExtra("fltnum");
        String deptime = fltinfo.getStringExtra("deptime");
        String aircraft = fltinfo.getStringExtra("aircraft");
        tv_deptime.setText(deptime);
        tv_fltnum.setText(fltnum);
        tv_aircraft.setText(aircraft);
        tv_cabin.setText(Globalvariable.getCabintype());
    }
}
