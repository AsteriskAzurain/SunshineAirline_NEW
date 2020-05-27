package com.ishang.asterisk.airline2application.global;

/**
 * Created by Asterisk on 5/26/2020.
 */

public class GlobalVariable {

    private static int userid;
    private static String useremail;
    private static String username;

    private static int playingpot;

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

    public static int getPlayingpot() {
        return playingpot;
    }

    public static void setPlayingpot(int playingpot) {
        GlobalVariable.playingpot = playingpot;
    }
}
