package com.ishang.asterisk.airline.global;

/**
 * Created by Asterisk on 7/1/2020.
 */

public class Airport {

    private String IATA;
    private String name;

    public String getIATA() {
        return IATA;
    }

    public void setIATA(String IATA) {
        this.IATA = IATA;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    @Override
    public String toString() {
        return name;
    }
}
