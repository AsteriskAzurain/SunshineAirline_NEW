package com.ishang.asterisk.airline1application.global;

/**
 * Created by Asterisk on 5/25/2020.
 */

public class Globalvariable {

    public static int userid;
    public static String useremail;
    public static String username;

    public static int playingpos;

    public static String requrl;
    public static String cabintype;

    public static int getUserid() {
        return userid;
    }

    public static void setUserid(int userid) {
        Globalvariable.userid = userid;
    }

    public static String getUseremail() {
        return useremail;
    }

    public static void setUseremail(String useremail) {
        Globalvariable.useremail = useremail;
    }

    public static String getUsername() {
        return username;
    }

    public static void setUsername(String username) {
        Globalvariable.username = username;
    }

    public static int getPlayingpos() {
        return playingpos;
    }

    public static void setPlayingpos(int playingpos) {
        Globalvariable.playingpos = playingpos;
    }

    public static String getRequrl() {
        return requrl;
    }

    public static void setRequrl(String requrl) {
        Globalvariable.requrl = requrl;
    }

    public static String getCabintype() {
        return cabintype;
    }

    public static void setCabintype(String cabintype) {
        Globalvariable.cabintype = cabintype;
    }
}
