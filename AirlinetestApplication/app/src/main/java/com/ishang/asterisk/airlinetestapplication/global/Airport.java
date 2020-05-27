package com.ishang.asterisk.airlinetestapplication.global;

/**
 * Created by Asterisk on 5/27/2020.
 */

public class Airport {

    private String IATA;
    private String name;

    public Airport(String IATA, String name) {
        this.IATA = IATA;
        this.name = name;
    }

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
        return getName();
    }
}
