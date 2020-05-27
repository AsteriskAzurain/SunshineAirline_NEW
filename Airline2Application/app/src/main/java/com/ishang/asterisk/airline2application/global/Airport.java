package com.ishang.asterisk.airline2application.global;

/**
 * Created by Asterisk on 5/26/2020.
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

    // TODO: 5/26/2020 5 override the tostring method is required 
    @Override
    public String toString() {
        return getName();
    }
}
