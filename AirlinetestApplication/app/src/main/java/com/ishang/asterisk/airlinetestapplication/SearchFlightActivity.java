package com.ishang.asterisk.airlinetestapplication;

import android.app.DatePickerDialog;
import android.content.Intent;
import android.os.Looper;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.text.InputType;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.DatePicker;
import android.widget.EditText;
import android.widget.ImageView;
import android.widget.Spinner;
import android.widget.Toast;

import com.ishang.asterisk.airlinetestapplication.global.Airport;
import com.ishang.asterisk.airlinetestapplication.global.GlobalVariable;

import org.json.JSONArray;
import org.json.JSONObject;

import java.io.ByteArrayOutputStream;
import java.io.InputStream;
import java.net.HttpURLConnection;
import java.net.URL;
import java.util.ArrayList;
import java.util.Calendar;
import java.util.List;

public class SearchFlightActivity extends AppCompatActivity {

    Spinner spin_cabin, spin_from, spin_to;
    EditText et_date;
    ImageView imgcal;
    Button btn_search, btn_back;

    List<Airport> airportlist;
    ArrayAdapter<Airport> adapter;

    String cabintype, depIATA, arrIATA, depdate;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_search_flight);

        spin_cabin = (Spinner) findViewById(R.id.spin_cabin);
        spin_from = (Spinner) findViewById(R.id.spin_from);
        spin_to = (Spinner) findViewById(R.id.spin_to);
        et_date = (EditText) findViewById(R.id.et_date_sf);
        imgcal = (ImageView) findViewById(R.id.img_cal);
        btn_search = (Button) findViewById(R.id.btn_search_sf);
        btn_back = (Button) findViewById(R.id.btn_back_sf);

        getairport();

        getspinitem();

        et_date.setInputType(InputType.TYPE_NULL);
        et_date.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                showdatepicker();
            }
        });
        imgcal.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                showdatepicker();
            }
        });

        btn_back.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                finish();
            }
        });
        btn_search.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                depdate=et_date.getText().toString();
                if(depdate.isEmpty()||depIATA.isEmpty()||arrIATA.isEmpty()||cabintype.isEmpty()){
                    Toast.makeText(SearchFlightActivity.this,"every field is required.",Toast.LENGTH_SHORT).show();
                }else{
                    String path = "http://10.0.2.2:5000/api/flight/list?From="+depIATA+"&To="+arrIATA+"&CabinType="+cabintype+"&Date="+depdate+"&isAsc=1";
                    Intent intent = new Intent(SearchFlightActivity.this, SearchResultActivity.class);
                    intent.putExtra("requrl",path);
                    startActivity(intent);
                }
            }
        });
    }

    private void getairport() {
        airportlist = new ArrayList<>();
        airportlist.add(new Airport("","please select one"));
        new Thread() {
            @Override
            public void run() {
                try {
                    String path = "http://10.0.2.2:5000/api/airport/list";
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
                        for (int i=0; i<array.length();i++){
                            JSONObject obj =array.getJSONObject(i);
                            Airport a = new Airport(obj.getString("IATA"),obj.getString("Name"));
                            airportlist.add(a);
                        }
                        adapter = new ArrayAdapter<Airport>(getApplicationContext(),android.R.layout.simple_spinner_item,airportlist);
                        adapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
                        spin_from.setAdapter(adapter);
                        spin_to.setAdapter(adapter);
                    }
                    Looper.loop();

                } catch (Exception e) {
                    System.out.println("error0527:" + e.toString());
                }

            }
        }.start();
    }

    private void getspinitem() {
        spin_cabin.setOnItemSelectedListener(new AdapterView.OnItemSelectedListener() {
            @Override
            public void onItemSelected(AdapterView<?> adapterView, View view, int i, long l) {
                cabintype = spin_cabin.getItemAtPosition(i).toString();
                GlobalVariable.setCabintype(cabintype);
            }

            @Override
            public void onNothingSelected(AdapterView<?> adapterView) {

            }
        });

        spin_from.setOnItemSelectedListener(new AdapterView.OnItemSelectedListener() {
            @Override
            public void onItemSelected(AdapterView<?> adapterView, View view, int i, long l) {
                depIATA = ((Airport) spin_from.getItemAtPosition(i)).getIATA();
            }

            @Override
            public void onNothingSelected(AdapterView<?> adapterView) {
            }
        });

        spin_to.setOnItemSelectedListener(new AdapterView.OnItemSelectedListener() {
            @Override
            public void onItemSelected(AdapterView<?> adapterView, View view, int i, long l) {
                arrIATA = ((Airport) spin_to.getItemAtPosition(i)).getIATA();
            }

            @Override
            public void onNothingSelected(AdapterView<?> adapterView) {

            }
        });
    }

    private void showdatepicker() {
        Calendar cal = Calendar.getInstance();
        int year = cal.get(Calendar.YEAR);
        int month=cal.get(Calendar.MONTH);
        int day = cal.get(Calendar.DAY_OF_MONTH);
        new DatePickerDialog(SearchFlightActivity.this, new DatePickerDialog.OnDateSetListener() {

            @Override
            public void onDateSet(DatePicker datePicker, int i, int i1, int i2) {
                et_date.setText(i+"-"+(i1+1)+"-"+i2);
            }
        },year,month,day).show();

    }
}
