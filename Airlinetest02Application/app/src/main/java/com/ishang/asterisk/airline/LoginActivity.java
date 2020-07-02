package com.ishang.asterisk.airline;

import android.content.Intent;
import android.os.Looper;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import com.ishang.asterisk.airline.global.GlobalVarible;

import org.json.JSONArray;
import org.json.JSONObject;

import java.io.ByteArrayOutputStream;
import java.io.InputStream;
import java.net.HttpURLConnection;
import java.net.URL;

public class LoginActivity extends AppCompatActivity {

    Button btn_login;
    EditText et_email,et_pswd;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_login);

        et_email= (EditText) findViewById(R.id.etemail);
        et_pswd= (EditText) findViewById(R.id.etpswd);
        btn_login= (Button) findViewById(R.id.btn_login);
        btn_login.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                final String email = et_email.getText().toString();
                final String pswd=et_pswd.getText().toString();

                new Thread(){
                    @Override
                    public void run() {
                        try{
                            String path="http://10.0.2.2:5000/api/login?Email="+email+"&Password="+pswd;
                            URL url = new URL(path);
                            HttpURLConnection connection = (HttpURLConnection) url.openConnection();
                            connection.setConnectTimeout(5000);
                            connection.setRequestMethod("POST");
                            int rescode=connection.getResponseCode();
                            InputStream is = connection.getInputStream();
                            ByteArrayOutputStream baos=new ByteArrayOutputStream();

                            int len=-1;
                            byte[] buffer = new byte[1024];
                            while ((len=is.read(buffer))!=-1) baos.write(buffer);
                            String data = new String(baos.toByteArray());

                            Looper.prepare();
                            if(rescode==200){
                                // success
                                Toast.makeText(getApplicationContext(), "login success", Toast.LENGTH_SHORT).show();
                                setuserinfo(email);
                                Intent intent = new Intent(LoginActivity.this, MainActivity.class);
                                startActivity(intent);
                            }else {
                                Toast.makeText(getApplicationContext(),"login failed",Toast.LENGTH_SHORT).show();
                            }
                            Looper.loop();

                        }catch (Exception e){
                            e.printStackTrace();
                        }
                    }
                }.start();

            }
        });
    }

    public void setuserinfo(String email){
        final String path1="http://10.0.2.2:5000/api/user/"+email;
        new Thread(){
            @Override
            public void run() {
                try {
                    URL url = new URL(path1);
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

                    if(rescode==200){
                        JSONObject user=(new JSONArray(data)).getJSONObject(0);
                        GlobalVarible.setUserid(user.getInt("ID"));
                        GlobalVarible.setUseremail(user.getString("Email"));
                        String username=user.getString("FirstName")+" "+user.getString("LastName");
                        username=(user.getString("Gender").equals("M"))?"Mr. "+username:"Mrs. "+username;
                        GlobalVarible.setUsername(username);
                    }
                }catch (Exception e ){
                    e.printStackTrace();
                }
            }
        }.start();
    }
}
