using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract7
{
    internal class Equilateral : Triangle//триангл базовый класс, е... нследуемый класс
    {
        public Equilateral(uint length1, uint length2, uint length3) : base(length1, length2, length3)// е.. вызывает метод base с параметрами из родительского класса триангл
        {
            length2 = length1;
            length3 = length1;
        }
        public void Area(out double perimeter)
        {
            perimeter = (((Math.Pow(Length1,2)) * Math.Sqrt(3)) / 4);
            
        }

       
    }
}
