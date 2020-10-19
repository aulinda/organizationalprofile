using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HandsOnActivity2
{
    public partial class frmConfirmation : Form
    {
        
    
        public frmConfirmation()
        {
            InitializeComponent();
        }

        private void frmConfirmation_Load(object sender, EventArgs e)
        {
            
            lblStudentNo.Text = HandsOnActivity2.frmRegistration.StudentInformationClass.SetStudentNo.ToString();
            lblName.Text = HandsOnActivity2.frmRegistration.StudentInformationClass.SetFullName;
            lblProgram.Text = HandsOnActivity2.frmRegistration.StudentInformationClass.SetProgram;
            lblBirthday.Text = HandsOnActivity2.frmRegistration.StudentInformationClass.SetBirthday;
            lblGender.Text = HandsOnActivity2.frmRegistration.StudentInformationClass.SetGender;
            lblContactNo.Text = HandsOnActivity2.frmRegistration.StudentInformationClass.SetContactNo.ToString();
            lblAge.Text = HandsOnActivity2.frmRegistration.StudentInformationClass.SetAge.ToString();
        }
        
        

    }
}
