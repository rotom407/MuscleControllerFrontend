using System.Collections.Generic;
using System.Threading;

namespace MuscleControllerFrontend {
    public class InteropWorker {
        public volatile bool running = true;
        public volatile string addr;
        public volatile int itimestamp;
        //constructor
        public InteropWorker(string address) {
            addr = address;
        }

        //to kill the thread
        public void Kill() => running = false;

        //sleep until message (interrupt)?

        public void SendDataRecord(List<DataRecord> records) {
            foreach(DataRecord rec in records) {
                SendString(rec.ToString());
            }
        }

        public void SendString(string str) {

        }

        public void DoWork() {
            while (running) {
                Thread.Sleep(5);
            }
        }
    }
}
