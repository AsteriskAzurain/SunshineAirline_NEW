package com.ishang.asterisk.airline2application;

import android.content.Intent;
import android.os.Looper;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import com.ishang.asterisk.airline2application.global.GlobalVariable;

import org.json.JSONArray;
import org.json.JSONObject;

import java.io.ByteArrayOutputStream;
import java.io.InputStream;
import java.net.HttpURLConnection;
import java.net.URL;

public class LoginActivity extends AppCompatActivity {

    EditText et_email, et_pswd;
    Button btn_login;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_login);

        et_email = (EditText) findViewById(R.id.et_email);
        et_pswd = (EditText) findViewById(R.id.et_pswd);
        btn_login = (Button) findViewById(R.id.btn_login);
        btn_login.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                final String email = et_email.getText().toString();
                final String pswd = et_pswd.getText().toString();

                new Thread(){
                    @Override
                    public void run() {
                        try{
                            String path = "http://10.0.2.2:5000/api/login?Email="+email+"&Password="+pswd;
                            URL url= new URL(path);
                            HttpURLConnection connection = (HttpURLConnection) url.openConnection();
                            connection.setConnectTimeout(5000);
                            connection.setRequestMethod("POST");
                            int rescode = connection.getResponseCode();
                            InputStream is = connection.getInputStream();
                            ByteArrayOutputStream baos = new ByteArrayOutputStream();

                            int len = -1;
                            byte[] buffer = new byte[1024];
                            while ((len = is.read(buffer))!=-1) baos.write(buffer,0,len);
                            String data = new String(baos.toByteArray());

                            // TODO: 5/26/2020 2 before use toast, a looper should be added
                            Looper.prepare();
                            if(rescode == 200){
                                Toast.makeText(getApplicationContext(),"login succeed.",Toast.LENGTH_SHORT).show();
                                path = "http://10.0.2.2:5000/api/user/"+email;
                                setuserinfo(path);
                                Intent intent = new Intent(LoginActivity.this, MainActivity.class);
                                startActivity(intent);
                            }
                            Looper.loop();
                        }catch (Exception e){
                            Log.w("login",e.toString());
                        }
                    }
                }.start();
            }
        });
    }

    private void setuserinfo(final String path) {
        new Thread(){
            @Override
            public void run() {
                try{
                    URL url = new URL(path);
                    HttpURLConnection conn = (HttpURLConnection) url.openConnection();
                    conn.setConnectTimeout(5000);
                    conn.setRequestMethod("GET");
                    int rescode = conn.getResponseCode();
                    InputStream is = conn.getInputStream();
                    ByteArrayOutputStream baos = new ByteArrayOutputStream();

                    int len = -1 ;
                    byte[] buffer = new byte[1024];
                    while ((len=is.read(buffer))!=-1) baos.write(buffer,0,len);
                    String data = new String(baos.toByteArray());

                    if(rescode==200){
                        JSONObject userinfo = (new JSONArray(data)).getJSONObject(0);
                        // TODO: 5/26/2020 1 the setter and getter method in the globalvarible class should be defined as static 
                        GlobalVariable.setUserid(userinfo.getInt("ID"));
                        GlobalVariable.setUseremail(userinfo.getString("Email"));
                        String username = userinfo.getString("FirstName")+" "+userinfo.getString("LastName");
                        if(userinfo.getString("Gender").equals("M")) username = "Mr. "+username;
                        else username = "Mrs. "+username;
                        GlobalVariable.setUsername(username);
                    }

                }catch (Exception e){
                    Log.w("store user info", e.toString());
                }
            }
        }.start();
    }


}
