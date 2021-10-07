using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegates_and_events_HW
{
    public static class Methods
    {
        public static void Shalom()
        {
            MessageBox.Show("Shalom");
        }
        public static void Print2()
        {
            MessageBox.Show("Another function called with same delegate");
        }

        public static void ShalomName(string name)
        {
            MessageBox.Show($"Shalom {name}");
        }
        public static void WelcomeName(string name)
        {
            MessageBox.Show($"Welcome {name}");
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Sub(int a, int b)
        {
            return a - b;
        }
    }
}
