using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wykres
{
    public class Model
    {
        int liczba_punktow = 100;
        int x1,x2;
        String axis_x,axis_y,title;

        public double X1 {
            get { return x1; }  
        }
        
        public bool InterpretujX1(String a)
        {
            try
            {
                x1 = Convert.ToInt32(a);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public double X2
        {
            get { return x2; }
        }

        public bool InterpretujX2(String b)
        {
            try
            {
                x2 = Convert.ToInt32(b);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public PointF[] valuesY(){
            float krok_x=(float)Math.Abs(x2-x1)/200;
            PointF[] values_y=new PointF[200];
            for (int i = 0; i < 200; i++)
            {
                float x = (float)(x1 + i * krok_x);
                float y = function(x1 + i * krok_x);
                values_y[i] = new PointF(x, y);

            }
            return values_y;
        }

        public float function(float x)
        {
            return (float)(Math.Cos(x) + 0.2 * x);
        }
    }
}
