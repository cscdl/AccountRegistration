using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountRegistration
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();



        }

        private void bttnNext_Click(object sender, EventArgs e)
        {
            

            StudentInfoClass.StudNo = Convert.ToInt64(txtBoxSudNo.Text.ToString());
            StudentInfoClass.Program = comBoxProgram.Text.ToString();
            StudentInfoClass.Lname = txtBoxLname.Text.ToString();
            StudentInfoClass.Fname = txtBoxFname.Text.ToString();
            StudentInfoClass.Mname = txtBoxMname.Text.ToString();
            StudentInfoClass.Age = Convert.ToInt32(txtBoxAge.Text.ToString());
            StudentInfoClass.ConNo = Convert.ToInt64(txtBoxConNo.Text.ToString());
            StudentInfoClass.Address = txtBoxAddress.Text.ToString();

            using (FrmConfirm fc = new FrmConfirm())
            {
                if (fc.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    txtBoxSudNo.Clear();
                    comBoxProgram.SelectedIndex = 1;
                    txtBoxLname.Clear();
                    txtBoxFname.Clear();
                    txtBoxMname.Clear();
                    txtBoxAge.Clear();
                    txtBoxConNo.Clear();
                    txtBoxAddress.Clear();
                }
            }
        }
    }
}
