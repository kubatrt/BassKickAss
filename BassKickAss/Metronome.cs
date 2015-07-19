using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Media;

/*

    4 String	5 String	5 String
    (tenor)

    6 String	Note	Frequency
    5	6	C3	130.813 Hz
    4	5	4	5	G2	97.999 Hz
    3	4	3	4	D2	73.416 Hz
    2	3	2	3	A1	55 Hz
    1	2	1	2	E1	41.204 Hz
    1		1	B0	30.868 Hz

    Basic tempo markings

    Larghissimo – very, very slow (24 BPM and under)
    Grave – very slow (25–45 BPM)
    Largo – broadly (40–60 BPM)
    Lento – slowly (45–60 BPM)
    Larghetto – rather broadly (60–66 BPM)
    Adagio – slow and stately (literally, "at ease") (66–76 BPM)
    Adagietto – slower than andante (72–76 BPM)
    Andante – at a walking pace (76–108 BPM)
    Andantino – slightly faster than Andante (although in some cases it can be taken to mean slightly slower than andante) (80–108 BPM)
    Marcia moderato – moderately, in the manner of a march[4][5] (83–85 BPM)
    Andante moderato – between andante and moderato (thus the name andante moderato) (92–112 BPM)
    Moderato – moderately (108–120 BPM)
    Allegretto – moderately fast (112–120 BPM)
    Allegro moderato – close to but not quite allegro (116–120 BPM)
    Allegro – fast, quickly, and bright (120–168 BPM) (molto allegro is slightly faster than allegro, but always in its range)
    Vivace – lively and fast (168–176 BPM)
    Vivacissimo – very fast and lively (172–176 BPM)
    Allegrissimo or Allegro vivace – very fast (172–176 BPM)
    Presto – extremely fast (168–200 BPM)
    Prestissimo – even faster than Presto (200 BPM and over)


*/

namespace BassKickAss
{
    public class Metronome
    {
        public static readonly int TEMPO_MIN = 40;
        public static readonly int TEMPO_MAX = 240;
        public static readonly int TEMPO_STEP = 2;

        public Timer    BPMTimer;

        public event OnTickEventHandler TickEvent;

        private int tempo;
        private int beat;

        public int Meter;  // 4/4

        public delegate void OnTickEventHandler();


        public bool IsPlaying
        {
            get { return BPMTimer.Enabled; }
            private set { }
        }

        public int Tempo
        {
            set
            {
                if (value < TEMPO_MIN)
                    tempo = TEMPO_MIN;
                else if (value > TEMPO_MAX)
                    tempo = TEMPO_MAX;
                else
                    tempo = value;
            }
            get { return tempo; }
        }

        public int Beat
        {
            get { return beat; }
            private set { }
        }


        public Metronome()
        {
            tempo = 80;
            Meter = 4;
            beat = 0;

            BPMTimer = new System.Timers.Timer();
            BPMTimer.Interval = 60000 / tempo;
            BPMTimer.Elapsed += new ElapsedEventHandler(OnTickInternal);
        }

        private void OnTickInternal(object source, ElapsedEventArgs e)
        {

            beat++;
            if (beat > Meter)
                beat = 1;

            if (TickEvent != null)
                TickEvent();
        }


        public void Play()
        {
            BPMTimer.Interval = 60000 / tempo;
            BPMTimer.Enabled = true;
        }

        public void Stop()
        {
            BPMTimer.Stop();
            beat = 0;
        }

        
    }
}
