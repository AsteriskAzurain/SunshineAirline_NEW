package com.ishang.asterisk.airlinetestapplication;

import android.content.Intent;
import android.os.Looper;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import com.ishang.asterisk.airlinetestapplication.global.GlobalVariable;

import org.json.JSONArray;
import org.json.JSONObject;

import java.io.ByteArrayOutputStream;
import java.io.InputStream;
import java.net.HttpURLConnection;
import java.net.URL;

public class LoginActivity extends AppCompatActivity {

    Button btn_login;
    EditText et_email, et_pswd;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_login);

        btn_login = (Button) findViewById(R.id.btn_login);
        et_email = (EditText) findViewById(R.id.et_email);
        et_pswd = (EditText) findViewById(R.id.et_pswd);

        btn_login.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {

                final String email = et_email.getText().toString();
                final String pswd = et_pswd.getText().toString();

                if (email.isEmpty() || pswd.isEmpty())
                    Toast.makeText(LoginActivity.this, "email and password are required.", Toast.LENGTH_SHORT).show();
                else {
                    new Thread() {
                        @Override
                        public void run() {
                            try {
                                String path = "http://10.0.2.2:5000/api/login?Email=" + email + "&Password=" + pswd;
                                URL url = new URL(path);
                                HttpURLConnection connection = (HttpURLConnection) url.openConnection();
                                connection.setConnectTimeout(5000);
                                connection.setRequestMethod("POST");
                                int rescode = connection.getResponseCode();
                                InputStream is = connection.getInputStream();
                                ByteArrayOutputStream baos = new ByteArrayOutputStream();

                                int len = -1;
                                byte[] buffer = new byte[1024];
                                while ((len=is.read(buffer))!=-1) baos.write(buffer,0,len);
                                String data = new String(baos.toByteArray());

                                Looper.prepare();
                                if(rescode==200){
                                    Toast.makeText(LoginActivity.this, "login succeed.", Toast.LENGTH_SHORT).show();
                                    setuserinfo(email);
                                }
                                Looper.loop();

                            } catch (Exception e) {
                                System.out.println("error0527 login:" + e.toString());
                            }

                        }
                    }.start();
                }

                Intent intent = new Intent(LoginActivity.this, MainActivity.class);
                startActivity(intent);
            }
        });

    }

    private void setuserinfo(final String email) {
        new Thread() {
            @Override
            public void run() {
                try {
                    String path = "http://10.0.2.2:5000/api/user/" + email ;
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
                        JSONObject userinfo =(new JSONArray(data)).getJSONObject(0);
                        GlobalVariable.setUserid(userinfo.getInt("ID"));
                        GlobalVariable.setUseremail(userinfo.getString("Email"));
                        String username = userinfo.getString("FirstName")+" "+userinfo.getString("LastName");
                        GlobalVariable.setUsername((userinfo.getString("Gender")).equals("M")?"Mr. "+username:"Mrs. "+username);
                    }
                    Looper.loop();

                } catch (Exception e) {
                    System.out.println("error0527 store user info:" + e.toString());
                }

            }
        }.start();

    }
}
