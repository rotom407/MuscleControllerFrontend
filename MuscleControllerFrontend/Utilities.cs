using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuscleControllerFrontend {
    public class Vector3D {
        public double x, y, z;
        public Vector3D(double xp, double yp, double zp) {
            x = xp; y = yp; z = zp;
        }
        public double Dot(Vector3D vec) {
            return x * vec.x + y * vec.y + z * vec.z;
        }
        public void Scale(double sc) {
            x *= sc; y *= sc; z *= sc;
        }
        public void Assign(Vector3D vec) {
            x = vec.x; y = vec.y; z = vec.z;
        }
        public Vector3D Cross(Vector3D vec) {
            return new Vector3D(-vec.y * z + vec.z * y, vec.x * z - vec.z * x, -vec.x * y + vec.y * x);
        }
        public Vector3D Decompose(Vector3D ve1, Vector3D ve2, Vector3D ve3) {
            double e1, e2, e3, det;
            det = ve3.x * ve2.y * ve1.z - ve2.x * ve3.y * ve1.z - ve3.x * ve1.y * ve2.z + ve1.x * ve3.y * ve2.z + ve2.x * ve1.y * ve3.z - ve1.x * ve2.y * ve3.z;
            e1 = -(-ve3.x * ve2.y * z + ve2.x * ve3.y * z + ve3.x * y * ve2.z - x * ve3.y * ve2.z - ve2.x * y * ve3.z + x * ve2.y * ve3.z);
            e2 = -(ve3.x * ve1.y * z - ve1.x * ve3.y * z - ve3.x * y * ve1.z + x * ve3.y * ve1.z + ve1.x * y * ve3.z - x * ve1.y * ve3.z);
            e3 = ve2.x * ve1.y * z - ve1.x * ve2.y * z - ve2.x * y * ve1.z + x * ve2.y * ve1.z + ve1.x * y * ve2.z - x * ve1.y * ve2.z;
            return new Vector3D(-e1, -e2, -e3);
        }
        public void Normalize() {
            double norm = Math.Sqrt(x * x + y * y + z * z);
            x /= norm;
            y /= norm;
            z /= norm;
        }
        public override string ToString() {
            return string.Format("({0:N3}, {1:N3}, {2:N3})", x, y, z);
        }
    }

    public class LowpassFilter {
        public double alpha;
        public double output = 0.0;
        public LowpassFilter(double alp) {
            alpha = alp;
        }
        public double Feed(double input) {
            return output = alpha * output + (1.0 - alpha) * input;
        }
    }

    public class LowpassFilterCutoff {
        public double alpha, cutoff;
        public double output = 0.0;
        public LowpassFilterCutoff(double alp, double cut) {
            alpha = alp;
            cutoff = cut;
        }
        public double Feed(double input) {
            if (Math.Abs(input - output) < cutoff)
                output = alpha * output + (1.0 - alpha) * input;
            else
                output = Math.Pow(alpha, 0.2) * output + (1.0 - Math.Pow(alpha, 0.2)) * input;
            return output;
        }
    }
}
