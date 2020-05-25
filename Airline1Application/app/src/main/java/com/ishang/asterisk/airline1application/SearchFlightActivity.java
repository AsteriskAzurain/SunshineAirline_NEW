package com.ishang.asterisk.airline1application;

import android.annotation.TargetApi;
import android.app.DatePickerDialog;
import android.content.Intent;
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

import com.ishang.asterisk.airline1application.global.Airport;
import com.ishang.asterisk.airline1application.global.Globalvariable;

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

    private Spinner spin_cabin, spin_from, spin_to;
    private EditText et_date;
    private Button btn_search, btn_back;
    private ImageView imgcal;

    private ArrayAdapter<Airport> adapter;
    private String path, cabintype;
    private String depIATA, arrIATA;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_search_flight);

        spin_cabin= (Spinner) findViewById(R.id.spin_cabin);
        spin_from= (Spinner) findViewById(R.id.spin_from);
        spin_to= (Spinner) findViewById(R.id.spin_to);
        et_date= (EditText) findViewById(R.id.et_date);
        btn_search = (Button) findViewById(R.id.btn_search_flight);
        btn_back= (Button) findViewById(R.id.btn_back_sf);
        imgcal = (ImageView) findViewById(R.id.imgcalendar);

        btn_back.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Globalvariable.setRequrl(null);
                Globalvariable.setCabintype(null);
                finish();
            }
        });

        btn_search.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                String date = et_date.getText().toString();
                if(date.isEmpty()) {
                    date="2018-06-15";
                    Toast.makeText(getApplicationContext(),"The date is required and has been automatically filled in as \"2018-06-15\".",Toast.LENGTH_SHORT).show();
                }
                path="http://10.0.2.2:5000/api/flight/list?From="+depIATA+"&To="+arrIATA+"&CabinType="+cabintype+"&Date="+date+"&isAsc=1";
                Globalvariable.setRequrl(path);
                Globalvariable.setCabintype(cabintype);
                Intent intent = new Intent(SearchFlightActivity.this, SearchResultActivity.class);
                startActivity(intent);
            }
        });

        loadspindata();

        // TODO: 5/25/2020 15 click the date edittext and the img of cal, a date picker should show
        et_date.setInputType(InputType.TYPE_NULL);
        et_date.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                showDatepicker();
            }
        });
        imgcal.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                showDatepicker();
            }
        });

    }

    @TargetApi(26)
    private void loadspindata() {

        // TODO: 5/25/2020 11 band data of cabintype in xml file, and use the entries attr

        final List<Airport> airportList = new ArrayList<>();
        airportList.add(new Airport("","please select one."));

        new Thread(){
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

                    if(rescode==200){
                        JSONArray array = new JSONArray(data);
                        for (int i=0; i<array.length(); i++){
                            JSONObject obj = array.getJSONObject(i);
                            String IATA =obj.getString("IATA");
                            String name = obj.getString("Name");
                            Airport a = new Airport(IATA,name);
                            airportList.add(a);
                        }
                    }

                }catch (Exception e){
                    System.out.println("fbw error: load airport \t"+e.toString());
                }
            }
        }.start();

        // TODO: 5/25/2020 12 how to make a adapter for spinner
        adapter =new ArrayAdapter<Airport>(getApplicationContext(),android.R.layout.simple_spinner_item,airportList);
        adapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
        spin_from.setAdapter(adapter);
        spin_to.setAdapter(adapter);
        spin_cabin.setSelection(2,true);

        // TODO: 5/25/2020 14 how to listen the spinner and get the selected data? 
        selectaction();
    }

    private void selectaction() {

        spin_cabin.setOnItemSelectedListener(new AdapterView.OnItemSelectedListener() {

            /**
             * 当选中某一个数据项时触发该事件
             * @param adapterView 接收的是被选择的数据项所属的Spinner对象，
             * @param view 接收的是显示被选择的数据项的TextView对象
             * @param i 接收的是被选择的数据项在适配器中的位置
             * @param l 被选择的数据项的行号
             */
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
                Airport a = (Airport) spin_from.getItemAtPosition(i);
                depIATA=a.getIATA();
            }

            @Override
            public void onNothingSelected(AdapterView<?> adapterView) {

            }
        });

        spin_to.setOnItemSelectedListener(new AdapterView.OnItemSelectedListener() {
            @Override
            public void onItemSelected(AdapterView<?> adapterView, View view, int i, long l) {
                arrIATA = ((Airport)spin_to.getItemAtPosition(i)).getIATA();
            }

            @Override
            public void onNothingSelected(AdapterView<?> adapterView) {

            }
        });
    }

    public void showDatepicker(){
        // TODO: 5/25/2020 16 get the date from the datepicker
        Calendar cal = Calendar.getInstance();
        int year = cal.get(Calendar.YEAR);
        int month = cal.get(Calendar.MONTH)+1;
        int day = cal.get(Calendar.DAY_OF_MONTH);
        new DatePickerDialog(SearchFlightActivity.this, new DatePickerDialog.OnDateSetListener(){
            /**
             * @param datePicker
             * @param i year
             * @param i1 month of year
             * @param i2 day of month
             */
            @Override
            public void onDateSet(DatePicker datePicker, int i, int i1, int i2) {
                et_date.setText(i+"-"+i1+"-"+i2);
            }
        },year,month,day).show();
    }

}
