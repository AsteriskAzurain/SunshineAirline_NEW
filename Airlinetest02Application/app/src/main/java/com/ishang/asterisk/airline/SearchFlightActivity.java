package com.ishang.asterisk.airline;

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

import com.ishang.asterisk.airline.global.Airport;

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

    Spinner spin_from, spin_to, spin_cabin;
    EditText et_date;
    Button btn_search, btn_back;
    ImageView btn_date;

    List<Airport> airportList;
    ArrayAdapter adapter;

    String depIATA, arrIATA, cabintype;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_search_flight);

        spin_from= (Spinner) findViewById(R.id.spin_from);
        spin_to= (Spinner) findViewById(R.id.spin_to);
        spin_cabin= (Spinner) findViewById(R.id.spin_cabin);
        et_date= (EditText) findViewById(R.id.et_date);
        btn_search= (Button) findViewById(R.id.btn_search_sf);
        btn_back= (Button) findViewById(R.id.btn_back_sf);
        btn_date = (ImageView) findViewById(R.id.iv_date);

        btn_back.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent intent = new Intent(SearchFlightActivity.this, MainActivity.class);
                startActivity(intent);
            }
        });

        btn_date.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                showdatedialog();
            }
        });

        et_date.setInputType(InputType.TYPE_NULL);
        et_date.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                showdatedialog();
            }
        });

        loadairport();

        selectaction();

        btn_search.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent result = new Intent(SearchFlightActivity.this, SearchResultActivity.class);
                result.putExtra("cabintype",cabintype);
                String depDate=et_date.getText().toString();
                String path="http://10.0.2.2:5000/api/flight/list?From="+depIATA+"&To="+arrIATA+"&CabinType="+cabintype+"&Date="+depDate+"&isAsc=1";
                result.putExtra("requrl",path);
                startActivity(result);
            }
        });
    }

    private void loadairport() {

        new Thread(){
            @Override
            public void run() {
                try{
                    String path="http://10.0.2.2:5000/api/airport/list";
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
                        airportList= new ArrayList<>();
                        for (int i=0; i<array.length();i++){
                            JSONObject object= array.getJSONObject(i);
                            Airport a=new Airport();
                            a.setIATA(object.getString("IATA"));
                            a.setName(object.getString("Name"));
                            airportList.add(a);
                        }
                        adapter=new ArrayAdapter(getApplicationContext(),android.R.layout.simple_spinner_item,airportList);
                        adapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
                        spin_from.setAdapter(adapter);
                        spin_to.setAdapter(adapter);

                    }
                    Looper.loop();
                }catch (Exception e){
                    e.printStackTrace();
                }
            }
        }.start();
    }

    public void showdatedialog(){
        Calendar cal = Calendar.getInstance();
        int year=cal.get(Calendar.YEAR);
        int month=cal.get(Calendar.MONTH);
        int day =cal.get(Calendar.DAY_OF_MONTH);
        new DatePickerDialog(SearchFlightActivity.this, new DatePickerDialog.OnDateSetListener() {
            @Override
            public void onDateSet(DatePicker datePicker, int i, int i1, int i2) {
                et_date.setText(i+"-"+(i1+1)+"-"+i2);
            }
        },year,month,day).show();
    }

    public void selectaction(){

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
                depIATA=((Airport)spin_from.getItemAtPosition(i)).getIATA();
            }

            @Override
            public void onNothingSelected(AdapterView<?> adapterView) {

            }
        });

        spin_to.setOnItemSelectedListener(new AdapterView.OnItemSelectedListener() {
            @Override
            public void onItemSelected(AdapterView<?> adapterView, View view, int i, long l) {
                arrIATA=((Airport)spin_to.getItemAtPosition(i)).getIATA();
            }

            @Override
            public void onNothingSelected(AdapterView<?> adapterView) {

            }
        });
    }
}
