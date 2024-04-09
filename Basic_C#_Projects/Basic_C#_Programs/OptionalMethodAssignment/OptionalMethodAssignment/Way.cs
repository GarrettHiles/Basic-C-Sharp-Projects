using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalMethodAssignment
{
    class Way
    {
        public int Math(int num1, int num2 = 0) // num2 = 0 makes it optional
        {
            int answer = num1 + num2;
            return answer;
        }
    }
}
