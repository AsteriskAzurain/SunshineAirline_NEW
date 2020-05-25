package com.ishang.asterisk.airline1application.global;

/**
 * Created by Asterisk on 5/25/2020.
 */

public class Airport {

    private String IATA;
    private String Name;

    public Airport(String IATA, String name) {
        this.IATA = IATA;
        Name = name;
    }

    public String getIATA() {
        return IATA;
    }

    public void setIATA(String IATA) {
        this.IATA = IATA;
    }

    public String getName() {
        return Name;
    }

    public void setName(String name) {
        Name = name;
    }

    // TODO: 5/25/2020 13 ovverride tostring: adapter will use this function to show items
    @Override
    public String toString() {
        return getName();
    }
}
