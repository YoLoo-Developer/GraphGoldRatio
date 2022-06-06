using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphGoldRatio
{ 
    public static class MathG
    {
        public static void GoldRatioMinimum(float x)
        {
            while (true)
            {
                xLeftBorder.Add(a);
                xRightBorder.Add(b);
                x1 = b - (b - a) / 1.618f;
                x2 = a + (b - a) / 1.618f;
                if (maximum)
                {
                    if (func[0].calculate(x1) <= func[0].calculate(x2))
                        a = x1;
                    else
                        b = x2;
                }
                else
                {
                    if (func[0].calculate(x1) >= func[0].calculate(x2))
                        a = x1;
                    else
                        b = x2;
                }
                if (Math.Abs(b - a) < eps)
                    break;
            }
        }
    }
}
