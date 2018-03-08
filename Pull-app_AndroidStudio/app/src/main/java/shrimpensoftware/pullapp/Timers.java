package shrimpensoftware.pullapp;

import android.os.CountDownTimer;

import java.util.Timer;
import java.util.TimerTask;

/**
 * Created by Simon on 2016-08-13.
 *
 * Handles the app timers
 */
public class Timers {
    // FIELDS -----------------------
    MainActivity owner;

    // Timer time in ms
    Integer pullupTimerTime = 500;

    // Timers
    final Timer pullupTimer = new Timer();

    // FUNCTIONS --------------------
    // Constructor
    public Timers(MainActivity owner) {
        this.owner = owner;
    }

    public void startInitialTimers() {
        // The pullupTimer
        pullupTimer.schedule(new TimerTask() {
            @Override
            public void run() {
                owner.runOnUiThread(new Runnable() {
                    @Override
                    public void run() {
                        if (owner.imagePullupsCount > 0) {
                            if ((Integer) owner.workoutImageView.getTag() == R.mipmap.bottomposition) {
                                owner.workoutImageView.setImageResource(R.mipmap.topposition);
                                owner.workoutImageView.setTag(R.mipmap.topposition);
                            } else {
                                owner.workoutImageView.setImageResource(R.mipmap.bottomposition);
                                owner.workoutImageView.setTag(R.mipmap.bottomposition);
                                owner.imagePullupsCount -= 1;
                            }
                        }
                    }
                });
            }
        }, 0, pullupTimerTime);
    }

    // Makes a faded effect to the counter when saving
    public void startFadeAtSaveCountdownTimer() {
         new CountDownTimer(500, 50) {
            @Override
            public void onTick(long l) {
                owner.numberOfPullupsText.setAlpha(
                        owner.numberOfPullupsText.getAlpha() - (float)0.1);
            }

            @Override
            public void onFinish() {
                owner.numberOfPullupsText.setAlpha(1);
            }
        }.start();
    }
}
