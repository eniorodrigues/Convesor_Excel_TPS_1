using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convesor_Excel_TPS
{
    internal class Campos
    {

      
            private string make;
            private string model;
            private string year;

            public Campos()
            {
            }

            public Campos(string Make, string Model )
            {
                make = Make;
                model = Model;
            }

            public string Make
            {
                get
                {
                    return make;
                }
                set
                {
                    make = value;
                }
            }

            public string Model
            {
                get
                {
                    return model;
                }
                set
                {
                    model = value;
                }
            }

            public string Year
            {
                get
                {
                    return year;
                }
                set
                {
                    year = value;
                }
        }
    }
}
