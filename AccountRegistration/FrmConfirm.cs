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
    public partial class FrmConfirm : Form
    {
        private DelegateText DelProgram, DelLName, DelFname, DelMname, DelAddress;
        private DelegateNumber DelAge, DelConNo, DelStudentNo;
        private DelegateNumber DelContNo { get;  }
        public FrmConfirm()
        {
            InitializeComponent();

            DelStudentNo = new DelegateNumber(StudentInfoClass.getStudentNo);
            DelProgram = new DelegateText(StudentInfoClass.getProgram);
            DelFname = new DelegateText(StudentInfoClass.getFirstName);
            DelMname = new DelegateText(StudentInfoClass.getMiddlName);
            DelLName = new DelegateText(StudentInfoClass.getLastName);
            DelAddress = new DelegateText(StudentInfoClass.getAddress);
            DelAge = new DelegateNumber(StudentInfoClass.getAge);
            DelContNo = new DelegateNumber(StudentInfoClass.getContactNum);
        }

        private void FrmConfirm_Load(object sender, EventArgs e)
        {
            lblStuNo.Text = Convert.ToString(DelStudentNo(StudentInfoClass.StudNo));
            lblProgram.Text = DelProgram(StudentInfoClass.Program);
            lblLname.Text = DelLName(StudentInfoClass.Lname);
            lblFname.Text = DelFname(StudentInfoClass.Fname);
            lblMname.Text = DelMname(StudentInfoClass.Mname);
            lblAddress.Text = DelAddress(StudentInfoClass.Address);
            lblAge.Text = Convert.ToString(DelAge(StudentInfoClass.Age));
            lblConNo.Text = Convert.ToString(DelContNo(StudentInfoClass.ConNo));
           
        }
    }
}
