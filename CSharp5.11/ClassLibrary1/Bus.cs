using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Bus : Car
    {
#pragma warning disable CS0108 // Член скрывает унаследованный член: отсутствует новое ключевое слово
        public event CarEventHandler Finish;
        public string Name { get; set; }
        public int MaxSpeed { get; set; }
        public int DrivenDistance { get; set; }
#pragma warning restore CS0108
        private Random rand;
        public Bus()
        {
            rand = new Random();
        }
        public override void Drive()
        {
            
            int distancePerSec = rand.Next(1, MaxSpeed);

            DrivenDistance += distancePerSec;

            if (DrivenDistance >= 100)
            {
                Finish();
            }
        }
    }
}
