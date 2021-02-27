using System;
using System.Windows.Forms;

namespace FlowTimer {

    public class ChocoboTimer : BaseTimer {
        public double powerOnTime;
        public int lastFrame;
        public TimerStatus timerStatus;
        public Label labelStatus;


        public void Sync(double time, uint[] items, uint[] chocoNames, char rank) {
            int frames = (int) (60 * (time - powerOnTime));
            Console.WriteLine("frames: " + frames);
            int offset = FF7Util.offsetToNearestMatchingFrame(frames, items, chocoNames, rank);
            Console.WriteLine("offset: " + offset);
            if(offset == int.MaxValue) {
                Console.WriteLine("Failed to match.");
            } else {
                Console.WriteLine("Last Frame: " + lastFrame);
                lastFrame = frames + offset;
                Console.WriteLine("Next Frame: " + lastFrame);
                powerOnTime -= (offset / 60.0);
                Console.WriteLine("adjusted power on time: " + powerOnTime);
            }
        }

        public enum TimerStatus {
            POWER_ON, RACE_CALIBRATION, WAITING, TIMER_RUNNING
        }

        private void setTimerStatus(TimerStatus status) {
            timerStatus = status;
            switch(status) {
                case TimerStatus.POWER_ON:
                    labelStatus.Text = "Waiting for Power-On...";
                    break;
                case TimerStatus.RACE_CALIBRATION:
                    labelStatus.Text = "Race Calibration";
                    break;
                case TimerStatus.WAITING:
                    labelStatus.Text = "Waiting...";
                    break;
                case TimerStatus.TIMER_RUNNING:
                    labelStatus.Text = "Timer Running";
                    break;
            }
        }


        public ChocoboTimer(TabPage tab, params Control[] copyControls) : base(tab, null, copyControls) {
            labelStatus = FlowTimer.MainForm.LabelStatus;
            setTimerStatus(TimerStatus.POWER_ON);
            TimerCallback = this.TimerCallbackFn;
        }

        public double TimerCallbackFn(double start) {
            return Math.Max(5 - (Win32.GetTime() - start / 1000.0), 0.0);
        }


        public override void OnBeepSoundChange() {
        }

        public override void OnBeepVolumeChange() {
        }

        public override void OnInit() {

        }

        public override void OnKeyEvent(Keys key) {
            double now = Win32.GetTime() / 1000;
            if(FlowTimer.Settings.Mark.IsPressed(key)) {
                switch(timerStatus) {
                    case TimerStatus.POWER_ON:
                        powerOnTime = now;
                        setTimerStatus(TimerStatus.RACE_CALIBRATION);
                        Console.WriteLine(powerOnTime);
                        break;
                    case TimerStatus.RACE_CALIBRATION:
                        Console.WriteLine(now);
                        new CalibrationInput(now).Show();
                        break;
                    case TimerStatus.WAITING:
                        //start timer
                        setTimerStatus(TimerStatus.TIMER_RUNNING);
                        break;
                    case TimerStatus.TIMER_RUNNING:
                        //do nothing
                        break;
                }
            }
        }

        public override void OnTimerStart() {

        }

        public override void OnTimerStop() {
        }

        public override void OnVisualTimerStart() {
        }

        public void Reset() {
            if(timerStatus == TimerStatus.TIMER_RUNNING) {
                //stop the timer
            }
            setTimerStatus(TimerStatus.POWER_ON);
        }
    }
}
