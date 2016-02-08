using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComplexNumbers
{
    class Complex
    {

        int re, im;
        static ListBox lb;

        public static void init(ListBox _lb) {
            lb = _lb;
        }

        public Complex(int re, int im) {
            this.re = re;
            this.im = im;
        }

        public static Complex operator +(Complex c1,Complex c2){
            return new Complex (c1.re+c2.re,c1.im+c2.im);
        }

        public void show(){
            if(this.im<0)
            lb.Items.Add(this.re + "  " + this.im + " i");
            else
                lb.Items.Add(this.re + " + " + this.im+ " i");
        }
    }
}
