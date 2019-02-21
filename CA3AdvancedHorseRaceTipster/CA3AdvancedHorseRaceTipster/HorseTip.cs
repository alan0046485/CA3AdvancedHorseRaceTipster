using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CA3AdvancedHorseRaceTipster
{
    class HorseTip
    {
        public string Course { get; set; }
        public string Horse { get; set; }
        public string Date { get; set; }
        public double Distance { get; set; }
        public bool Won { get; set; }

        public HorseTip()
        {

        }

        public HorseTip(string course, string horse, string date, double distance, bool won)
        {
            course = Course;
            horse = Horse;
            date = Date;
            distance = Distance;
            won = Won;

        }

        
    }
}