package shrimpensoftware.pullapp;

import android.content.SharedPreferences;
import android.preference.PreferenceManager;


/**
 * Created by Simon on 2016-08-03.
 *
 * Handles internal data storage
 */
public class DataStorageHelper {
   //FIELDS -----------------------
    MainActivity owner;

    // Internal storage file keys
    String numberOfPullupsKey = "numberOfPullups_Key";


    // FUNCTIONS ------------------
    // Constructor
    public DataStorageHelper(MainActivity owner) {
        this.owner = owner;
    }

    // Initializes numberOfPullups, used when starting the app
    public void initializeNumberOfPullups() {
        owner.numberOfPullups = getInternalStorageValue(numberOfPullupsKey);
        owner.numberOfPullupsText.setText(owner.numberOfPullups.toString());
    }

    // Updates the current pullups count in the database
    public void updateNumberOfPullups() {
        setInternalStorageValue(numberOfPullupsKey, owner.numberOfPullups);
    }

    // Gets value from internal data storage
    public int getInternalStorageValue(String keyString) {
        SharedPreferences prefs = PreferenceManager.getDefaultSharedPreferences(owner);
        return prefs.getInt(keyString, 0);
    }

    // Sets value in internal data storage
    public void setInternalStorageValue(String keyString , int newValue) {
        SharedPreferences prefs = PreferenceManager.getDefaultSharedPreferences(owner);
        SharedPreferences.Editor editor = prefs.edit();
        editor.putInt(keyString, newValue);
        editor.apply();
    }
}
