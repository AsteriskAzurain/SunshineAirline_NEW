package com.ishang.asterisk.airline1application.global;

import android.support.v4.app.Fragment;
import android.support.v4.app.FragmentManager;
import android.support.v4.app.FragmentPagerAdapter;

import java.util.List;

/**
 * Created by Asterisk on 5/26/2020.
 */

public class WelcomeAdapter extends FragmentPagerAdapter {
    // TODO: 5/26/2020 25 extend the father fragmentpageradapter and create my own fragment, override two required methods

    List<WelcomeFragment> fragments;

    public WelcomeAdapter(FragmentManager fm, List<WelcomeFragment> fragments) {
        super(fm);
        this.fragments=fragments;
    }

    /**
     * 根据位置返回对应的fragment
     * */
    @Override
    public Fragment getItem(int position) {
        return fragments.get(position);
    }

    /**
     * 返回fragments的总数
     */
    @Override
    public int getCount() {
        return fragments.size();
    }
}
