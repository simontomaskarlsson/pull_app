package shrimpensoftware.pullapp;

import android.hardware.SensorEvent;
import android.view.View;

import com.jjoe64.graphview.series.DataPoint;
import com.jjoe64.graphview.series.LineGraphSeries;

import java.text.DecimalFormat;
import java.util.ArrayList;

/**
 * Created by Simon on 2016-08-15.
 *
 * Handles accelerometer functionality
 */
public class Accelerometer {
    // FIELDS -----------------------
    MainActivity owner;

    // Numberformats
    DecimalFormat twoDecimalsFormat = new DecimalFormat("#.00");

    // FUNCTIONS --------------------
    // Constructor
    public Accelerometer(MainActivity owner) {
        this.owner = owner;
    }

    // Main sensor changed function
    public void onSensorChanged(SensorEvent sensorEvent) {
        owner.xText.setText("X: " + twoDecimalsFormat.format(sensorEvent.values[0]));
        owner.yText.setText("Y: " + twoDecimalsFormat.format(sensorEvent.values[1]));
        owner.zText.setText("Z: " + twoDecimalsFormat.format(sensorEvent.values[2]));


        /*if (owner.collectingData) {
            if (owner.graphCounter > 10) {
                owner.graph.addSeries(owner.series);
                owner.collectingData = false;
                owner.graph.setVisibility(View.VISIBLE);
            } else {
                double y = (double)sensorEvent.values[1];
                owner.series.appendData(new DataPoint(owner.graphCounter, y), true, 11);
                owner.graphCounter += 1;
            }
        } else if (owner.yValues.size() > 0) {
            owner.graph.addSeries(owner.series);
            owner.yValues.clear();
        }*/
        if(owner.collectingData) {
            //Store data
            double y = (double)sensorEvent.values[1];
            owner.yValues.add(y);
            //owner.graph.setVisibility(View.INVISIBLE);

        }
        else if (owner.yValues.size() > 10){
            //Create graph (LATER: CALCULATE NBROFOPULLS)
            owner.graph.addSeries(arrayListToSeries(owner.yValues));
            owner.graph.setVisibility(View.VISIBLE);

            //Reset yValues
            owner.yValues.clear();
            //owner.series.clear();
        }
    }


    // Create series from arrayList
    LineGraphSeries<DataPoint> arrayListToSeries(ArrayList list) {
        LineGraphSeries<DataPoint> series = new LineGraphSeries<>();
        for (int i = 0; i < list.size(); i++) {
            series.appendData(new DataPoint(i, (double)list.get(i)), true, list.size()-1);
        }
        return series;
    }

    //Find number of peaks in ArrayList
    int numberOfPeaks(ArrayList list) {
        int count = 0;

        for (int i = 0; i < list.size(); i++) {
            //Måste först analysera data!
            //Kul att testa filtrera hälsar Per
        }

        return count;
    }
}
