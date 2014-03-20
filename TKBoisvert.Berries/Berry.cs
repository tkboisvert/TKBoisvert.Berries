using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TKBoisvert.Berries
{
    public class Berry : IBerry
    {
        public bool Poisenous;
        public string Color;
        public string Name;
        private bool Squished;

        public Berry(bool poisenous, string color, string name)
        {
            Poisenous = poisenous;
            Color = color;
            Name = name;
            Squished = false;
        }
        
        public void Squish()
        {
            Squished = true;
        }


        public bool IsTheBerrySquished()
        {
            return Squished;
        }
    }
}
