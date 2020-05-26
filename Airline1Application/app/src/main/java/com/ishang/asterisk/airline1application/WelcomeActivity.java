package com.ishang.asterisk.airline1application;

import android.content.Intent;
import android.support.v4.view.ViewPager;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.LinearLayout;

import com.ishang.asterisk.airline1application.global.WelcomeAdapter;
import com.ishang.asterisk.airline1application.global.WelcomeFragment;

import java.util.ArrayList;
import java.util.List;

public class WelcomeActivity extends AppCompatActivity {

    private ViewPager viewPager;
    private List<WelcomeFragment> fragments;
    private WelcomeAdapter adapter;
    private LinearLayout linear_dot;
    private List<ImageView> dotimglist;
    Button btn_skip;

    Boolean isLastPage = false;
    Boolean isDragPage = false;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_welcome);

        // TODO: 5/26/2020 23 how to make controls in linear layout center? set the gravity="top|center".  Img: margintop=60; text: margintop=40, bottom=20.

        btn_skip = (Button) findViewById(R.id.btn_skip);
        // TODO: 5/26/2020 26 the action after the skip btn clicked is tologin
        btn_skip.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                toLogin();
            }
        });

        viewPager = (ViewPager) findViewById(R.id.viewpager);
        fragments = new ArrayList<>();
        fragments.add(new WelcomeFragment("Sunshine Airline\n Management System\n\n V1.0"));
        fragments.add(new WelcomeFragment("You can search flights and book flights in this app."));
        fragments.add(new WelcomeFragment("Our App will give you a good experience."));
        adapter = new WelcomeAdapter(getSupportFragmentManager(), fragments);
        viewPager.setAdapter(adapter);
        viewPager.addOnPageChangeListener(new ViewPager.OnPageChangeListener() {

            /**
             * 在屏幕滚动过程中不断被调用
             * @param position
             * @param positionOffset  是当前页面滑动比例，如果页面向右翻动，这个值不断变大，最后在趋近1的情况后突变为0。如果页面向左翻动，这个值不断变小，最后变为0
             * @param positionOffsetPixels  是当前页面滑动像素，变化情况和positionOffset一致
             */
            @Override
            public void onPageScrolled(int position, float positionOffset, int positionOffsetPixels) {
                if(isLastPage&&isDragPage&&positionOffsetPixels==0) toLogin();
            }

            /**
             * 这个方法有一个参数position，代表哪个页面被选中
             * 切换view时，下方圆点的变化。
             * @param position 当前view的位置
             */
            @Override
            public void onPageSelected(int position) {
                isLastPage = (position==dotimglist.size()-1);
                for (ImageView iv : dotimglist) iv.setBackgroundResource(R.mipmap.page_indicator_unfocused);
                dotimglist.get(position).setBackgroundResource(R.mipmap.page_indicator_focused);
            }

            /**
             * 在手指操作屏幕的时候发生变化
             * @param state  有三个值：0（END）  1(PRESS)  2(UP)
             */
            @Override
            public void onPageScrollStateChanged(int state) {
                isDragPage = (state==1);
            }
        });

        // TODO: 5/26/2020 28 the layout should set the gr..=center in xml file
        linear_dot = (LinearLayout) findViewById(R.id.linear_dot);
        dotimglist = new ArrayList<>();
        for (int i = 0; i < fragments.size(); i++) {
            ImageView dotimg = new ImageView(this);
            // TODO: 5/26/2020 27 through layoutparam to set style of dots
            LinearLayout.LayoutParams params = new LinearLayout.LayoutParams(50,50);
            params.setMargins(50,0,50,0);
            dotimg.setLayoutParams(params);
            dotimg.setBackgroundResource(R.mipmap.page_indicator_unfocused);
            if(i==0) dotimg.setBackgroundResource(R.mipmap.page_indicator_focused);
            dotimglist.add(dotimg);
            linear_dot.addView(dotimg);
        }
    }

    private void toLogin() {
        Intent intent = new Intent(WelcomeActivity.this, LoginActivity.class);
        startActivity(intent);
    }
}
