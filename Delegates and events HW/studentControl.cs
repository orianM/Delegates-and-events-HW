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
    public partial class studentControl : UserControl
    {
        StudentList studentsManager = new StudentList();
        public studentControl()
        {
            InitializeComponent();
        }

        private void studentControl_Load(object sender, EventArgs e)
        {
            studentsManager.Add(new Student("1113", "Kevin", "Lamar", 23, 100, 300));
            studentsManager.Add(new Student("2223", "Buddy", "Lamar", 28, 50, 400));
            studentsManager.Add(new Student("1333", "Chance", "Perl", 22, 150, 200));
            studentsManager.Add(new Student("2333", "Cherry", "Dope", 20, 350, 800));
        }
    }
}
