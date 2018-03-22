using System.Threading;

namespace MuscleControllerFrontend {
    public static class Globals {
        public volatile static byte timestamp = 0;
        public static Serialstate state = Serialstate.Closed;
        public volatile static DataBuffer dbuf = new DataBuffer();
        public static Filters[] filters = new Filters[3];
        public static Filters[] chfilters = new Filters[3];
        public static SerialWorker sworker = new SerialWorker();
        public static Thread sthread = new Thread(sworker.DoWork);
        public static CursorData cursordat = new CursorData();
        public static DataRecord lastrec = new DataRecord(0, true);
    }

    public class CursorData {
        public Vector3D Xvec = new Vector3D(0, -1, 0);
        public Vector3D Yvec = new Vector3D(0, 0, 1);
        public Vector3D Zvec = new Vector3D(-1, 0, 0);
        public double speed = 0.005;
        public double X = 400.0, Y = 300.0;
        public double Xsp = 0.0, Ysp = 0.0;
        public double Xremaining = 0.0, Yremaining = 0.0;
        public bool apply = false;
        public void UpdateXY(int maxX, int maxY) {
            X += Xsp; Y += Ysp;
            if (maxX > 0 && maxY > 0) {
                if (X > maxX)
                    X = maxX;
                if (Y > maxY)
                    Y = maxY;
                if (X < 0)
                    X = 0;
                if (Y < 0)
                    Y = 0;
            }
        }
    }

    public class Filters {
        public LowpassFilter trend;
        public LowpassFilter denoise;
        public LowpassFilterCutoff detilt;
        public double smooth;
        public double sudden;
        public bool reset = true;
        public Filters(double tr, double no, double ti, double ticut) {
            trend = new LowpassFilter(tr);
            denoise = new LowpassFilter(no);
            detilt = new LowpassFilterCutoff(ti, ticut);
        }
        public void Feed(double input) {
            if (reset) {
                trend.output = input;
                denoise.output = input;
                detilt.output = input;
                reset = false;
            }
            trend.Feed(input); denoise.Feed(input); detilt.Feed(input);
            smooth = detilt.output - trend.output;
            sudden = denoise.output - detilt.output;
        }
    }
}
