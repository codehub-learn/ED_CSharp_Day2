using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Day2
{
    internal class Square : Rectangle, IShape
    {
        public int heightCM { get; set; }
        public int widthCM { get; set; }

        public float GetArea()
        {
            return heightCM * widthCM;
        }
    }
}
