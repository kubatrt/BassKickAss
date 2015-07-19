using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.InteropServices;
using System.Collections;


namespace BassKickAss
{
    // Poor class to enumerate recording audio devices
    public class RecordingDevices
    {
        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public struct WaveInCaps
        {
            public short wMid;
            public short wPid;
            public int vDriverVersion;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public char[] szPname;
            public uint dwFormats;
            public short wChannels;
            public short wReserved1;
        }

        //return total Sound Recording Devices
        [DllImport("winmm.dll")]
        public static extern int waveInGetNumDevs();
        //return spesific Sound Recording Devices spec
        [DllImport("winmm.dll", EntryPoint = "waveInGetDevCaps")]
        public static extern int waveInGetDevCapsA(int uDeviceID, ref WaveInCaps lpCaps, int uSize);

        ArrayList deviceList = new ArrayList();

        public int Count
        {
            get { return deviceList.Count; }
        }

        public string this[int index]
        {
            get { return (string)deviceList[index]; }
        }

        public RecordingDevices() //fill sound recording devices array
        {
            int waveInDevicesCount = waveInGetNumDevs(); //get total
            if (waveInDevicesCount > 0)
            {
                for (int uDeviceID = 0; uDeviceID < waveInDevicesCount; uDeviceID++)
                {
                    WaveInCaps waveInCaps = new WaveInCaps();
                    waveInGetDevCapsA(uDeviceID, ref waveInCaps,
                                      Marshal.SizeOf(typeof(WaveInCaps)));
                    deviceList.Add(new string(waveInCaps.szPname).Remove(new string(waveInCaps.szPname).IndexOf('\0')).Trim());
                    //clean garbage
                }
            }
        }

    }
}
