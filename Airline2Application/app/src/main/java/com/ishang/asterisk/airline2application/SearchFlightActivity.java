package com.ishang.asterisk.airline2application;

import android.app.DatePickerDialog;
import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.text.InputType;
import android.util.Log;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.DatePicker;
import android.widget.EditText;
import android.widget.ImageView;
import android.widget.Spinner;
import android.widget.SpinnerAdapter;

import com.ishang.asterisk.airline2application.global.Airport;

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
    Button btn_search, btn_back;
    ImageView img_cal;

    List<Airport> airportlist;
    ArrayAdapter<Airport> adapter;

    String cabintype, from, to, date;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_search_flight);

        spin_cabin = (Spinner) findViewById(R.id.spin_cabin);
        spin_from = (Spinner) findViewById(R.id.spin_from);
        spin_to = (Spinner) findViewById(R.id.spin_to);
        et_date = (EditText) findViewById(R.id.et_date);
        btn_search = (Button) findViewById(R.id.btn_search_sf);
        btn_back = (Button) findViewById(R.id.btn_back_sf);
        img_cal = (ImageView) findViewById(R.id.imgdate);

        et_date.setInputType(InputType.TYPE_NULL);
        et_date.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                showDatepicker();
            }
        });
        img_cal.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                showDatepicker();
            }
        });

        btn_back.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                finish();
            }
        });

        loadairportlist();
        selectaction();

        btn_search.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                date=et_date.getText().toString();
                String path = "http://10.0.2.2:5000/api/flight/list?From="+from+"&To="+to+"&CabinType="+cabintype+"&Date="+date+"&isAsc=1";
                Intent intent = new Intent(SearchFlightActivity.this,SearchResultActivity.class);
                intent.putExtra("reqstr",path);
                intent.putExtra("cabintype",cabintype);
                startActivity(intent);
            }
        });
    }

    private void loadairportlist() {

        airportlist = new ArrayList<>();
        airportlist.add(new Airport("","please select one."));

        new Thread() {
            @Override
            public void run() {
                try {
                    String path = "http://10.0.2.2:5000/api/airport/list";
                    URL url = new URL(path);
                    HttpURLConnection conn = (HttpURLConnection) url.openConnection();
                    conn.setConnectTimeout(5000);
                    conn.setRequestMethod("GET");
                    int rescode = conn.getResponseCode();
                    InputStream is = conn.getInputStream();
                    ByteArrayOutputStream baos = new ByteArrayOutputStream();

                    int len = -1;
                    byte[] buffer = new byte[1024];
                    while ((len = is.read(buffer)) != -1) baos.write(buffer, 0, len);
                    String data = new String(baos.toByteArray());

                    if (rescode == 200) {
                        JSONArray array = new JSONArray(data);
                        for(int i=0; i<array.length(); i++){
                            JSONObject obj = array.getJSONObject(i);
                            String iata = obj.getString("IATA");
                            String name = obj.getString("Name");
                            Airport a = new Airport(iata,name);
                            airportlist.add(a);
                        }
                        runOnUiThread(new Runnable() {
                            @Override
                            public void run() {
                                adapter = new ArrayAdapter<Airport>(getApplicationContext(),android.R.layout.simple_spinner_item,airportlist);
                                adapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
                                spin_from.setAdapter(adapter);
                                spin_to.setAdapter(adapter);
                            }
                        });
                    }
                } catch (Exception e) {
                    Log.w("load airport", e.toString());
                }
            }
        }.start();



    }

    private void selectaction() {
        spin_cabin.setOnItemSelectedListener(new AdapterView.OnItemSelectedListener() {
            @Override
            public void onItemSelected(AdapterView<?> adapterView, View view, int i, long l) {
                cabintype=spin_cabin.getItemAtPosition(i).toString();
            }

            @Override
            public void onNothingSelected(AdapterView<?> adapterView) {

            }
        });

        spin_from.setOnItemSelectedListener(new AdapterView.OnItemSelectedListener() {
            @Override
            public void onItemSelected(AdapterView<?> adapterView, View view, int i, long l) {
                from=((Airport)spin_from.getItemAtPosition(i)).getIATA();
            }

            @Override
            public void onNothingSelected(AdapterView<?> adapterView) {

            }
        });

        spin_to.setOnItemSelectedListener(new AdapterView.OnItemSelectedListener() {
            @Override
            public void onItemSelected(AdapterView<?> adapterView, View view, int i, long l) {
                to = ((Airport)spin_to.getItemAtPosition(i)).getIATA();
            }

            @Override
            public void onNothingSelected(AdapterView<?> adapterView) {

            }
        });

    }

    private void showDatepicker() {
        Calendar cal = Calendar.getInstance();
        int year = cal.get(Calendar.YEAR);
        int month = cal.get(Calendar.MONTH);
        int day = cal.get(Calendar.DAY_OF_MONTH);
        // TODO: 5/26/2020 7 don't forget the ".show()" :)
        new DatePickerDialog(SearchFlightActivity.this, new DatePickerDialog.OnDateSetListener() {
            @Override
            public void onDateSet(DatePicker datePicker, int i, int i1, int i2) {
                et_date.setText(i+"-"+(i1+1)+"-"+i2);
            }
        },year,month,day).show();
    }
}
