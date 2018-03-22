using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Threading;

namespace MuscleControllerFrontend {
    public enum Serialstate {
        Closed, //serial is not connected
        Single, //single shot mode
        Continuous  //continuous mode
    };

    public class DataRecord {
        public byte timestamp;
        public short[] data = new short[10];
        public bool success;
        public DataRecord(byte tsp, bool succ) {
            timestamp = tsp;
            success = succ;
        }
    }

    public class DataBuffer {
        public List<DataRecord> chbuf = new List<DataRecord>();
        public List<DataRecord> buf = new List<DataRecord>();
        public List<string> sbuf = new List<string>();
        public DataBuffer() {
            chbuf.Clear();
            buf.Clear();
            sbuf.Clear();
        }
    }

    public class SerialWorker {
        public void DoWork() {
            running = true;
            //timeBeginPeriod(15);
            Serial1 = new SerialPort("COM4", 115200, Parity.None, 8, StopBits.One) {
                DtrEnable = false,
                RtsEnable = false,
                ReadTimeout = 500
            };

            while (running) {
                if (Serial1.IsOpen && trigcount != 0) {
                    if (trigcount > 0) trigcount--;
                    byte[] bytsnd = new byte[1] { Globals.timestamp };
                    byte[] bytrecv = new byte[21];
                    byte[] bytdata = new byte[20];
                    short[] data = new short[10];
                    int readnum = 0, offset = 0;
                    bool failed = false;
                    Serial1.DiscardInBuffer();
                    Serial1.Write(bytsnd, 0, 1);
                    do {
                        try {
                            readnum = Serial1.Read(bytrecv, offset, 21 - offset);
                            offset += readnum;
                        } catch (TimeoutException) {
                            failed = true;
                        }
                    } while (offset < 21 && failed == false);
                    Array.Copy(bytrecv, 1, bytdata, 0, 20);
                    Buffer.BlockCopy(bytdata, 0, data, 0, 20);
                    if (!failed) {
                        /*
                        string str = "";
                        for (int i = 0; i < 7; i++)
                        {
                            str += data[i].ToString();
                            str += " ";
                        }
                        lock (Globals.dbuf.sbuf)
                            Globals.dbuf.sbuf.Add(str);*/
                        DataRecord rec = new DataRecord(Globals.timestamp, true);
                        for (int i = 0; i < 10; i++) {
                            rec.data[i] = data[i];
                        }
                        lock (Globals.dbuf.buf)
                            Globals.dbuf.buf.Add(rec);
                        lock (Globals.dbuf.chbuf)
                            Globals.dbuf.chbuf.Add(rec);
                    } else {
                        DataRecord rec = new DataRecord(Globals.timestamp, false);
                        for (int i = 0; i < 10; i++) {
                            rec.data[i] = 0;
                        }
                        lock (Globals.dbuf.buf)
                            Globals.dbuf.buf.Add(rec);
                        lock (Globals.dbuf.chbuf)
                            Globals.dbuf.chbuf.Add(rec);
                    }

                    Globals.timestamp++;
                }
                Thread.Sleep(15);
            }
            //timeEndPeriod(15);
        }
        public void SetRunning(bool run, string name) {
            if (run) {
                if (!Serial1.IsOpen) {
                    Serial1.PortName = name;
                    Serial1.Open();
                }
            } else {
                if (Serial1.IsOpen) {
                    Serial1.Close();
                }
            }
        }
        public void SetCount(int count) => trigcount = count;
        public void Kill() => running = false;
        private volatile int trigcount;
        private volatile bool running;
        public volatile SerialPort Serial1;
    }

}
