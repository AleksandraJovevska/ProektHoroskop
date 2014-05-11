using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Horoskop
{
    class Znak
    {
        public string kar1;
        public string kar2;
        public string kar3;
        public Znak(string kar1, string kar2, string kar3)
        {
            this.kar1 = kar1;
            this.kar2 = kar2;
            this.kar3 = kar3;
        }
        public override string ToString()
        {
            return kar1;
        }
    }
}
