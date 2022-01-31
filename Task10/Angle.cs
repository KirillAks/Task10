using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    class Angle
    {
        int gradus;
        int min;
        int sec;
        public bool positive = true;

        public int Gradus
        {
            set
            {
                if (value < 0)
                {
                    positive = false;
                }
                else
                {
                    gradus = value % 360;
                }                
            }
            get
            {
                return gradus;
            }
        }
        public int Min
        {
            set
            {
                if (value < 0)
                {
                    positive = false;
                }
                else
                {
                    Gradus += value / 60;
                    min = value % 60;
                }                
            }
            get
            {
                return min;
            }
        }
        public int Sec
        {
            set
            {
                if (value < 0)
                {
                    positive = false;
                }
                else
                {
                    Min += value / 60;
                    sec = value % 60;
                }               
            }
            get
            {
                return sec;
            }
        }
        public Angle(int gradus, int min, int sec)
        {
            this.Gradus = gradus;
            this.Min = min;
            this.Sec = sec;
        }

        public double ToRadians()
        {
            return Math.PI * (gradus + (min / 60) + (sec / 3600)) / 180;
        }
    }
}
