using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Angle
    {
        int gradus;
        int min;
        int sec;
        public int Gradus
        {
            get
            {
                return gradus;
            }
            set 
            {
                gradus = value;
            }
        }
        public int Min
        {
            get
            {
                return min;
            }
            set
            {
                min = value;
            }
        }
        public int Sec
        {
            get
            {
                return sec;
            }
            set
            {
                sec = value;
            }
        }

        public Angle(int gradus, int min, int sec)
        {
            this.gradus = gradus;
            this.min = min;
            this.sec = sec;
        }
        public double ToRadians()
        {
            return gradus * Math.PI /180 + min * Math.PI / (180 * 60) + sec * Math.PI / (180 * 3600);
        }
    }
}
