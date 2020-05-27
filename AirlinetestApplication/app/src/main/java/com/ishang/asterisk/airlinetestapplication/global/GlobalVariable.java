package com.ishang.asterisk.airlinetestapplication.global;

/**
 * Created by Asterisk on 5/27/2020.
 */

public class GlobalVariable {

    private static int userid;
    private static String useremail;
    private static String username;

    private static int playingpos;

    private static String cabintype;

    public static int getUserid() {
        return userid;
    }

    public static void setUserid(int userid) {
        GlobalVariable.userid = userid;
    }

    public static String getUseremail() {
        return useremail;
    }

    public static void setUseremail(String useremail) {
        GlobalVariable.useremail = useremail;
    }

    public static String getUsername() {
        return username;
    }

    public static void setUsername(String username) {
        GlobalVariable.username = username;
    }

    public static int getPlayingpos() {
        return playingpos;
    }

    public static void setPlayingpos(int playingpos) {
        GlobalVariable.playingpos = playingpos;
    }

    public static String getCabintype() {
        return cabintype;
    }

    public static void setCabintype(String cabintype) {
        GlobalVariable.cabintype = cabintype;
    }
}
