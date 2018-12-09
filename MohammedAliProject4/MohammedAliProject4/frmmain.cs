using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MohammedAliProject4
{
    
    public partial class frmmain : Form
    {
        string Mode;

        public frmmain()
        {
            InitializeComponent();
        }
      

        private void coursesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.coursesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.coursesDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'coursesDataSet.Courses' table. You can move, or remove it, as needed.
            this.coursesTableAdapter.Fill(this.coursesDataSet.Courses);

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            CourseUpdate1.SetCourse(txtNOC.Text, txtFLN.Text, mcCSD.SelectionStart.ToShortDateString(), coursesComboBox.Text, Mode);
            
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            Object[] ArrayOfObjects3 = new Object[5];
            ArrayOfObjects3 = CourseUpdate1.GetCourse();
            txtO_NOC.Text = (string)ArrayOfObjects3[0].ToString();
            txtO_FLN.Text = (string)ArrayOfObjects3[1];
            txtO_CSD.Text = (string)ArrayOfObjects3[2];
            txtO_Course.Text = (string)ArrayOfObjects3[3];
            txtO_CM.Text = (string)ArrayOfObjects3[4];



        }

        private void btnHybrid_CheckedChanged(object sender, EventArgs e)
        {
            Mode = "Hybrid";
        }

        private void btnOnline_CheckedChanged(object sender, EventArgs e)
        {
            Mode = "Online";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }


}
