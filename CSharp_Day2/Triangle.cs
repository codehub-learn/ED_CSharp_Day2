using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Day2
{
    internal class Triangle : IShape
    {
        public int baseCM { get; set; }

        public int heightCM { get; set; }

        public float GetArea()
        {
            return 0.5f * baseCM;
        }
    }
}
