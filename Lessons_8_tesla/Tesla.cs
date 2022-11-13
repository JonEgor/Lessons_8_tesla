using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons_8_tesla
{
    internal interface Tesla
    {
        public void Drive(int dist);
        public void Refuel(int battery);
    }
}
