package com.ishang.asterisk.airline1application.global;

import android.content.Context;
import android.os.Bundle;
import android.support.annotation.Nullable;
import android.support.v4.app.Fragment;
import android.view.Gravity;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;

import com.ishang.asterisk.airline1application.R;

/**
 * Created by Asterisk on 5/26/2020.
 */

public class WelcomeFragment extends Fragment {
    // TODO: 5/26/2020 24 the class should extend the father class: Fragment, create a constructor and override three of its three methods

    private Context context;
    private String showtext;
    private TextView textView;

    public WelcomeFragment(String showtext) {
        super();
        this.showtext = showtext;
    }

    @Override
    public void onCreate(@Nullable Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        context=getActivity();
    }

    @Nullable
    @Override
    public View onCreateView(LayoutInflater inflater, @Nullable ViewGroup container, @Nullable Bundle savedInstanceState) {
        View view = inflater.inflate(R.layout.welcome_fragment,container,false);
        textView=view.findViewById(R.id.tv_welcome);
        textView.setGravity(Gravity.CENTER);
        return view;
    }

    @Override
    public void onActivityCreated(@Nullable Bundle savedInstanceState) {
        super.onActivityCreated(savedInstanceState);
        textView.setText(showtext);
    }
}
