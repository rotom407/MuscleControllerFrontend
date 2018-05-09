using System.Threading;
using WindowsInput;
using WindowsInput.Native;

namespace MuscleControllerFrontend {
    public enum MainMode {
        MMouse,
        GEDemo
    }
    //0.995, 0.5, 0.7, 1000
    public static class Config {
        public static double[] filttrend = { 0.995, 0.999 }, filtdenoise = { 0.5, 0.1 }, filttilt = { 0.7, 0.3 }, filtcutoff = { 1000, 10000 }, filtemg = { 0.0, 0.3 }, filtemgcutoff = { 0, 20 };
        public static int[] schmitthigh = { 150, 150 }, schmittlow = { 50, 50 };
        public static Vector3D[,] defaultbase = { { new Vector3D(0, -1, 0), new Vector3D(0, 0, 1), new Vector3D(-1, 0, 0) }, { new Vector3D(0, 0, 1), new Vector3D(0, -1, 0), new Vector3D(1, 0, 0) } };
        public static double gedemodeadzone = 20;
        public static int gedemozoomstrength = 1;
        public static int gedemozoomup = 70, gedemozoomdown = -40;
    }

    //static class storing global objects
    public static class Globals {
        public static MainMode mainMode = MainMode.MMouse;
        public static Serialstate state = Serialstate.Closed;
        public static Filters[] filters = new Filters[3];   //3 filters (for AcX AcY AcZ) used for cursor movements
        public static Filters[] chfilters = new Filters[3]; //3 filters (for AcX AcY AcZ) used for charts
        public static volatile byte timestamp = 0;
        public static volatile DataBuffer dbuf = new DataBuffer();  //data buffer used by serial worker
        public static SerialWorker sworker = new SerialWorker();
        public static InteropWorker iworker = new InteropWorker("PH");
        public static Thread sthread = new Thread(sworker.DoWork);
        public static Thread ithread = new Thread(iworker.DoWork);
        public static CursorData cursordat = new CursorData();  //cursor data
        public static DataRecord lastrec = new DataRecord(0, true); //last (current) record of sensors
        public static SchmittTrigger[] schmitt = new SchmittTrigger[4];
        public static SchmittTrigger[] chschmitt = new SchmittTrigger[4];
        public static LowpassFilterCutoffHighpass[] emgfilter = new LowpassFilterCutoffHighpass[4];
        public static LowpassFilterCutoffHighpass[] chemgfilter = new LowpassFilterCutoffHighpass[4];
        public static InputSimulator inputSim = new InputSimulator();
        public static int gedemoxstate = 0;
        public static int gedemoystate = 0;
        public static int gedemozoompotential = 0;
    }

    //storing the position, velocity and other properties of the cursor
    public class CursorData {

        //encapsulations
        public Vector3D Xbase { get; set; } = new Vector3D(0, -1, 0);
        public Vector3D Ybase { get; set; } = new Vector3D(0, 0, 1);
        public Vector3D Zbase { get; set; } = new Vector3D(-1, 0, 0);
        public double Speed { get; set; } = 0.005;
        public double X { get; set; } = 400.0;
        public double Y { get; set; } = 300.0;
        public double Xsp { get; set; } = 0.0;
        public double Ysp { get; set; } = 0.0;
        public double Xremaining { get; set; } = 0.0;
        public double Yremaining { get; set; } = 0.0;
        public bool Active { get; set; } = false;

        //update cursor position with speed values and clamp the position ranges
        public void UpdateXY(int maxX, int maxY) {
            X += Xsp; Y += Ysp;
            if (X > maxX) X = maxX;
            if (Y > maxY) Y = maxY;
            if (X < 0) X = 0;
            if (Y < 0) Y = 0;
        }

        //update cursor position with speed values without clamp the position ranges
        public void UpdateXY() {
            X += Xsp; Y += Ysp;
        }
    }

    //filters class
    public class Filters {

        //encapsulations
        public LowpassFilter Trend { get; set; }
        public LowpassFilter Denoise { get; set; }
        public LowpassFilterCutoff Tilt { get; set; }
        public double Smooth { get; set; }
        public double Sudden { get; set; }
        public bool Reset { get; set; } = true;

        //constructor
        public Filters(double trendcutoff, double denoisecutoff, double tiltcutoff, double tiltpeakcutoff) {
            Trend = new LowpassFilter(trendcutoff);
            Denoise = new LowpassFilter(denoisecutoff);
            Tilt = new LowpassFilterCutoff(tiltcutoff, tiltpeakcutoff);
        }

        //feed the filters with data input
        public void Feed(double input) {
            if (Reset) {
                //reset filter memory
                Trend.output = input;
                Denoise.output = input;
                Tilt.output = input;
                Reset = false;
            }
            Trend.Feed(input); Denoise.Feed(input); Tilt.Feed(input);
            Smooth = Tilt.output - Trend.output;
            Sudden = Denoise.output - Tilt.output;
        }
    }
}
