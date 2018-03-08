package shrimpensoftware.pullapp;


import android.content.pm.ActivityInfo;

import android.net.Uri;
import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.support.v7.widget.Toolbar;
import android.view.View;
import android.widget.Button;
import android.widget.CompoundButton;
import android.widget.ImageView;

import android.widget.Switch;
import android.widget.TextView;
import android.hardware.Sensor;
import android.hardware.SensorManager;
import android.hardware.SensorEvent;
import android.hardware.SensorEventListener;

import java.util.ArrayList;

import com.jjoe64.graphview.GraphView;
import com.jjoe64.graphview.series.DataPoint;
import com.jjoe64.graphview.series.LineGraphSeries;


public class MainActivity extends AppCompatActivity implements SensorEventListener {
    // View objects
    TextView titleText, numberOfPullupsText, todayCountText;

    TextView xText, yText, zText;

    // Imageviews
    ImageView workoutImageView;

    // Counters
    Integer numberOfPullups, todayCount, imagePullupsCount;

    // Help class instances
    DataStorageHelper dataStorageHelper = new DataStorageHelper(this);
    ViewButtons viewButtons = new ViewButtons(this);
    Timers timers = new Timers(this);
    Accelerometer accelerometer = new Accelerometer(this);

    // Graphs
    GraphView graph;
    ArrayList yValues = new ArrayList();
    boolean collectingData = false;
    /**
     * ATTENTION: This was auto-generated to implement the App Indexing API.
     * See https://g.co/AppIndexing/AndroidStudio for more information.
     */
    //private GoogleApiClient client;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        // Sensors
        Sensor accelerometerSensor;
        SensorManager SM;

        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        Toolbar toolbar = (Toolbar) findViewById(R.id.toolbar);
        setSupportActionBar(toolbar);
        setRequestedOrientation(ActivityInfo.SCREEN_ORIENTATION_PORTRAIT);

        // Reference to bind view objects to variables
        titleText = (TextView) findViewById(R.id.titleText);
        numberOfPullupsText = (TextView) findViewById(R.id.numberOfPullupsText);
        todayCountText = (TextView) findViewById(R.id.todayCountText);

        xText = (TextView) findViewById(R.id.xText);
        yText = (TextView) findViewById(R.id.yText);
        zText = (TextView) findViewById(R.id.zText);

        Button plusButton = (Button) findViewById(R.id.plusbutton);
        Button minusButton = (Button) findViewById(R.id.minusButton);
        Button saveButton = (Button) findViewById(R.id.saveButton);
        Button webButton = (Button) findViewById(R.id.webButton);
        Button graphButton = (Button) findViewById(R.id.graphButton);
        workoutImageView = (ImageView) findViewById(R.id.workoutImageView);

        final Switch accMonthSwitch = (Switch) findViewById(R.id.accMonthSwitch);

        // Set counters to initial values
        dataStorageHelper.initializeNumberOfPullups();
        todayCount = 0;
        imagePullupsCount = 0;

        // Set listener functions to view buttons
        viewButtons.setAdditionButtonListener(plusButton, 1);
        viewButtons.setAdditionButtonListener(minusButton, -1);
        viewButtons.setSaveButtonListener(saveButton);
        viewButtons.setWebButtonListener(webButton);
        viewButtons.setGraphButtonListener(graphButton);

        // Set tag on imageViews to easier timer switch drawables
        workoutImageView.setTag(R.mipmap.bottomposition);

        // Start the correct initial timers
        this.timers.startInitialTimers();

        // Set switch listener
        accMonthSwitch.setOnCheckedChangeListener(new CompoundButton.OnCheckedChangeListener() {
            @Override
            public void onCheckedChanged(CompoundButton compoundButton, boolean checked) {
                if (checked) {
                    xText.setVisibility(View.VISIBLE);
                    yText.setVisibility(View.VISIBLE);
                    zText.setVisibility(View.VISIBLE);
                } else {
                    xText.setVisibility(View.INVISIBLE);
                    yText.setVisibility(View.INVISIBLE);
                    zText.setVisibility(View.INVISIBLE);
                }
            }
        });

        // Accelerometer -----------------------------------------
        // Create sensor manager
        SM = (SensorManager) getSystemService(SENSOR_SERVICE);

        // Set accelerometer
        accelerometerSensor = SM.getDefaultSensor(Sensor.TYPE_ACCELEROMETER);

        // Register sensor listener
        SM.registerListener(this, accelerometerSensor, SensorManager.SENSOR_DELAY_NORMAL);
        // -------------------------------------------------------

        // Graph variables
        graph = (GraphView) findViewById(R.id.graph);

        // ATTENTION: This was auto-generated to implement the App Indexing API.
        // See https://g.co/AppIndexing/AndroidStudio for more information.
        //client = new GoogleApiClient.Builder(this).addApi(AppIndex.API).build();
    }

    @Override
    public void onSensorChanged(SensorEvent sensorEvent) {
        accelerometer.onSensorChanged(sensorEvent);

    }

    @Override
    public void onAccuracyChanged(Sensor sensor, int i) {
        // Implementation is needed but does not need any functionality at this moment
    }

    /*@Override
    public void onStart() {
        super.onStart();

        // ATTENTION: This was auto-generated to implement the App Indexing API.
        // See https://g.co/AppIndexing/AndroidStudio for more information.
        client.connect();
        Action viewAction = Action.newAction(
                Action.TYPE_VIEW, // TODO: choose an action type.
                "Main Page", // TODO: Define a title for the content shown.
                // TODO: If you have web page content that matches this app activity's content,
                // make sure this auto-generated web page URL is correct.
                // Otherwise, set the URL to null.
                Uri.parse(""),
                // TODO: Make sure this auto-generated app URL is correct.
                Uri.parse("")

        );
        AppIndex.AppIndexApi.start(client, viewAction);
    }

    @Override
    public void onStop() {
        super.onStop();

        // ATTENTION: This was auto-generated to implement the App Indexing API.
        // See https://g.co/AppIndexing/AndroidStudio for more information.
        Action viewAction = Action.newAction(
                Action.TYPE_VIEW, // TODO: choose an action type.
                "Main Page", // TODO: Define a title for the content shown.
                // TODO: If you have web page content that matches this app activity's content,
                // make sure this auto-generated web page URL is correct.
                // Otherwise, set the URL to null.
                Uri.parse(""),
                // TODO: Make sure this auto-generated app URL is correct.
                Uri.parse("")
        );
        AppIndex.AppIndexApi.end(client, viewAction);
        client.disconnect();
    }*/
}


/* TODO
- Gör UIt generellt för olika skärmstorlekar
- Lägg till lite ljud?
- Lägg till fält för antal varje månad
- Byt switchfärg
- Koppla in accelerometern för automatisk räkning av pulls?
 */
