using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegates_and_events_HW
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void BtnShalom_Click(object sender, EventArgs e)
        {
            MyFirstDelegate shalom = Methods.Shalom;
            shalom();
        }

        private void BtnPrint2_Click(object sender, EventArgs e)
        {
            MyFirstDelegate anotherInstance = Methods.Print2;
            anotherInstance();
        }

        private void BtnShalomName_Click(object sender, EventArgs e)
        {
            Greet greet1 = Methods.ShalomName;
            greet1(txtBoxEnterName1.Text);
        }

        private void BtnWelcomeName_Click(object sender, EventArgs e)
        {
            Greet greet2 = Methods.WelcomeName;
            greet2(txtBoxEnterName2.Text);

            //greet2 = Methods.Print2; //doesn't work because the "Greet" delegate Only accepts methods with a string argument.
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddOrSub Add = Methods.Add;
            int result = Add(int.Parse(txtAddNum1.Text), int.Parse(txtAddNum2.Text));
            MessageBox.Show($"{txtAddNum1.Text} + {txtAddNum2.Text} = {result}");
        }

        private void BtnSubtract_Click(object sender, EventArgs e)
        {
            AddOrSub Sub = Methods.Sub;
            int result = Sub(int.Parse(txtSubNum1.Text), int.Parse(txtSubNum2.Text));
            MessageBox.Show($"{txtSubNum1.Text} - {txtSubNum2.Text} = {result}");
        }
    }
}
