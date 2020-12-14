using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceCollectionLab
{
    class Horn
    {
        readonly int level;
        public Horn(int level, string data)
        {
            this.level = level;
        }
        public Horn() { }

        public void Beep() => Console.WriteLine($"Beep -beep with {this.level}!!!!");
    }
}
