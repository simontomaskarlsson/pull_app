package shrimpensoftware.pullapp;

import android.app.AlertDialog;
import android.content.Intent;
import android.net.Uri;
import android.view.View;
import android.widget.Button;

/**
 * Created by Simon on 2016-08-03.
 *
 * Handles view button functionality
 */
public class ViewButtons {
    // FIELDS -----------------------
    MainActivity owner;

    // FUNCTIONS --------------------
    // Constructor
    public ViewButtons(MainActivity owner) {
        this.owner = owner;
    }

    // Sets listener to onClick for plus/minus button
    public void setAdditionButtonListener(Button button, final Integer addition) {
        if (button != null) {
            button.setOnClickListener(new View.OnClickListener() {
                @Override
                public void onClick(View v) {
                    owner.numberOfPullups += addition;
                    owner.numberOfPullupsText.setText(owner.numberOfPullups.toString());

                    owner.todayCount += addition;
                    owner.todayCountText.setText(owner.todayCount.toString());

                    owner.imagePullupsCount += addition;
                }
            });
        }
    }

    // Click function for save button
    public void setSaveButtonListener(Button button) {
        if (button != null) {
            button.setOnClickListener(new View.OnClickListener() {
                @Override
                public void onClick(View v) {
                    owner.dataStorageHelper.updateNumberOfPullups();

                    // Effect for save indication to user
                    owner.timers.startFadeAtSaveCountdownTimer();
                }
            });
        }
    }

    // Web button click opens a webpage
    public void setWebButtonListener(Button button) {
        if (button != null) {
            button.setOnClickListener(new View.OnClickListener() {
                @Override
                public void onClick(View v) {
                    goToUrl("https://www.google.com/");
                }
            });
        }
    }


    private void goToUrl(String url) {
        Uri uriUrl = Uri.parse(url);
        Intent launchBrowser = new Intent(Intent.ACTION_VIEW, uriUrl);
        owner.startActivity(launchBrowser);
    }


    // Graph button starts data collection
    public void setGraphButtonListener(Button button) {
        if (button != null) {
            button.setOnClickListener(new View.OnClickListener() {
                @Override
                public void onClick(View v) {
                    owner.collectingData = !owner.collectingData;
                }
            });
        }
    }
}
