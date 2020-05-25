package com.ishang.asterisk.airline1application;

import android.content.Intent;
import android.os.Looper;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import com.ishang.asterisk.airline1application.global.Globalvariable;

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

        et_email=(EditText) findViewById(R.id.et_email);
        et_pswd= (EditText) findViewById(R.id.et_pswd);
        btn_login=(Button)findViewById(R.id.btn_login);

        btn_login.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                final String email, pswd;
                // TODO: 5/25/2020  1 after gettext, you should tostring
                email=et_email.getText().toString();
                pswd=et_pswd.getText().toString();

                if(email.isEmpty()||pswd.isEmpty()){
                    Toast.makeText(LoginActivity.this,"The Email and password are required.",Toast.LENGTH_SHORT).show();
                }else {
                    new Thread(){
                        @Override
                        public void run() {
                            try {
                                // TODO: 5/25/2020 3 before connect to the backend, a premission should be added
                                String path="http://10.0.2.2:5000/api/login?Email="+email+"&Password="+pswd;
                                URL url = new URL(path);
                                HttpURLConnection connection = (HttpURLConnection) url.openConnection();
                                connection.setConnectTimeout(5000);
                                connection.setRequestMethod("POST");
                                int rescode = connection.getResponseCode();
                                InputStream is = connection.getInputStream();
                                ByteArrayOutputStream baos = new ByteArrayOutputStream();

                                int len =-1;
                                byte[] buffer = new byte[1024];
                                while ((len=is.read(buffer))!=-1){
                                    baos.write(buffer,0,len);
                                }
                                // TODO: 5/25/2020 4 Can't create handler inside thread that has not called Looper.prepare()
                                Looper.prepare();
                                if(rescode==200){
                                    Toast.makeText(LoginActivity.this,"Login successfully.",Toast.LENGTH_SHORT).show();
                                    // TODO: 5/25/2020 2 after login succeed, you should store the user info
                                    setuserinfo(email);

                                    Globalvariable.setPlayingpos(0);

                                    Intent intent = new Intent(LoginActivity.this,MainActivity.class);
                                    startActivity(intent);
                                }
                                Looper.loop();
                            }catch (Exception e){
                                System.out.println("fbw error: login thread\t"+e.toString());
                                Toast.makeText(LoginActivity.this,"Login failed",Toast.LENGTH_SHORT).show();
                                recreate();

                            }
                        }
                    }.start();
                }
            }
        });
    }

    private void setuserinfo(final String email) {
        new Thread(){
            @Override
            public void run() {
                try {
                    String path="http://10.0.2.2:5000/api/user/"+email;
                    URL url = new URL(path);
                    HttpURLConnection connection1 = (HttpURLConnection) url.openConnection();
                    connection1.setConnectTimeout(5000);
                    connection1.setRequestMethod("GET");
                    int rescode = connection1.getResponseCode();
                    InputStream is = connection1.getInputStream();
                    ByteArrayOutputStream baos = new ByteArrayOutputStream();

                    int len =-1;
                    byte[] buffer = new byte[1024];
                    while ((len=is.read(buffer))!=-1){
                        baos.write(buffer,0,len);
                    }
                    String data = new String(baos.toByteArray());

                    if(rescode==200){
                        JSONObject userinfo = new JSONArray(data).getJSONObject(0);
                        Globalvariable.setUserid(userinfo.getInt("ID"));
                        Globalvariable.setUseremail(userinfo.getString("Email"));
                        String username = userinfo.getString("FirstName")+" "+userinfo.getString("LastName");
                        if(userinfo.getString("Gender").equals("M")) username="Mr. "+username;
                        else username="Mrs. "+username;
                        Globalvariable.setUsername(username);
                        System.out.println("fbw info: store user info succeed.");
                    }
                }catch (Exception e){
                    System.out.println("fbw error: store user info\t"+e.toString());
                }
            }
        }.start();
    }
}
