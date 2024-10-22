using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Day2
{
    internal class Cat : Animal
    {
        internal override string Name { get; set; } = "Cat";
        internal FurColor Fur { get; set; }
    }

    internal enum FurColor
    {
        Black,
        Brown,
        Red,
        White,
        Calico
    }
}



