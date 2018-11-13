using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public delegate void CarEventHandler();
    public abstract class Car
    {
        public event CarEventHandler Finish;

        public string Name { get; set; }
        public int MaxSpeed { get; set; }
        public int DrivenDistance { get; set; }
        public abstract void Drive();
    }
}
