package com.ishang.asterisk.airline.global;

/**
 * Created by Asterisk on 7/1/2020.
 */

public class GlobalVarible {

    private static int userid;
    private static String useremail;
    private static String username;

    public static int getPlayingpot() {
        return playingpot;
    }

    public static void setPlayingpot(int playingpot) {
        GlobalVarible.playingpot = playingpot;
    }

    private static int playingpot;

    public static int getUserid() {
        return userid;
    }

    public static void setUserid(int userid) {
        GlobalVarible.userid = userid;
    }

    public static String getUseremail() {
        return useremail;
    }

    public static void setUseremail(String useremail) {
        GlobalVarible.useremail = useremail;
    }

    public static String getUsername() {
        return username;
    }

    public static void setUsername(String username) {
        GlobalVarible.username = username;
    }


}
