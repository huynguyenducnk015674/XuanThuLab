using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceCollectionLab
{
    class Car
    {
        readonly Horn _horn;
        public Car(Horn horn) => this._horn = horn;
        public void Beep()
        {
          //  Horn h = new Horn();
            _horn.Beep();
        }
        
    }
}
