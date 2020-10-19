using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace HandsOnActivity2
{


    public partial class frmRegistration : Form
    {

        private String _FullName;
        private int _Age;
        private long _ContactNo;
        private long _StudentNo;

        public frmRegistration()
        {
            InitializeComponent();
        }
        public class StudentInformationClass
        {

            public static string SetFullName = "";
            public static string SetBirthday = "";
            public static string SetProgram = "";
            public static string SetGender = "";
            public static int SetStudentNo = 0;
            public static int SetContactNo = 0;
            public static int SetAge;

        }



        private void frmRegistration_Load(object sender, EventArgs e)
        {
            string[] ListOfProgram = new string[]{
            
            "BS Information Technology",
            "BS Computer Science",
            "BS Information Systems",
            "BS in Accountancy",
            "BS in Hospitality Management",
            "BS in Tourism Management"
            };
            for (int i = 0; i < 6; i++)
            {
                cbPrograms.Items.Add(ListOfProgram[i].ToString());
            }


            string[] Genders = new string[]{
                "Male", "Female"
            };
            for (int i = 0; i < 2; i++)
            {
                cbGender.Items.Add(Genders[i].ToString());
            }
        }
     
        public long StudentNumber(string studNum)
        {
            try
            {
                _StudentNo = long.Parse(studNum);

            }
            catch (FormatException e)
            {
                String error = "Student Number Error: " + e.Message;
                MessageBox.Show(error);
            }
            catch (IndexOutOfRangeException e)
            {
                String error = "Student Number Error: " + e.Message;
                MessageBox.Show(error);
            }
            catch (ArgumentNullException e)
            {
                String error = "Student Number Error: " + e.Message;
                MessageBox.Show(error);
            }
            catch (OverflowException e)
            {
                String error = "Student Number Error: " + e.Message;
                MessageBox.Show(error);
            }
            finally
            {

                Console.WriteLine("Student Number is Executed");
            }
            
                return _StudentNo;
            }
           
    
    
        public long ContactNo(string Contact)
        {
            try
            {
                if (Regex.IsMatch(Contact, @"^[0-9]{10,11}$"))
                {
                    _ContactNo = long.Parse(Contact);

                }
                else
                {
                    throw new IndexOutOfRangeException("Please Check the Contact Number Data");
                }
            }
           
            catch (FormatException e)
            {
                String error = "Contact Number Error: " + e.Message;
                MessageBox.Show(error);
            }
            catch (IndexOutOfRangeException e)
            {
                String error = "Contact Number Error: " + e.Message;
                MessageBox.Show(error);
            }
            catch (ArgumentException e)
            {
                String error = "Contact Number Error: " + e.Message;
                MessageBox.Show(error);
            }
         
            catch (OverflowException e)
            {
                String error = "Contact Number Error: " + e.Message;
                MessageBox.Show(error);
            }
            finally
            {

                Console.WriteLine("Contact Number is Executed");
            }
                    return _ContactNo;
              
        }

        public string FullName(string LastName, string FirstName, string MiddleInitial)
        {
            try
            {

                if (Regex.IsMatch(LastName, @"^[a-zA-Z]+$") || Regex.IsMatch(FirstName, @"^[a-zA-Z]+$") || Regex.IsMatch(MiddleInitial, @"^[a-zA-Z]+$"))
                {
                    _FullName = LastName + ", " + FirstName + ", " + MiddleInitial;
                }
                else
                {
                    throw new ArgumentException("Please Check Name");
                }
            }
            catch (FormatException e)
            {
                String error = "Name Error: " + e.Message;
                MessageBox.Show(error);
            }
            catch (IndexOutOfRangeException e)
            {
                String error = "Name Error: " + e.Message;
                MessageBox.Show(error);
            }
            catch (ArgumentException e)
            {
                String error = "Name Error: " + e.Message;
                MessageBox.Show(error);
            }
         
            catch (OverflowException e)
            {
                String error = "Name Error: " + e.Message;
                MessageBox.Show(error);
            }
            finally
            {
                Console.WriteLine("Name is Executed");
            }
            return _FullName;
        }
          

        public int Age(string age)
        {
            try
            {
                if (Regex.IsMatch(age, @"^[0-9]{1,3}$"))
                {
                    _Age = Int32.Parse(age);
                }
                else
                {
                    throw new IndexOutOfRangeException("Please Check Age");
                }
            }

            catch (FormatException e)
            {
                String error = "Age Error: " + e.Message;
                MessageBox.Show(error);
            }
            catch (IndexOutOfRangeException e)
            {
                String error = "Age Error: " + e.Message;
                MessageBox.Show(error);
            }
            catch (ArgumentNullException e)
            {
                String error = "Age Error: " + e.Message;
                MessageBox.Show(error);
            }
            catch (OverflowException e)
            {
                String error = "Age Error: " + e.Message;
                MessageBox.Show(error);
            }
            finally {

                Console.WriteLine("Age is Executed");
            }
            return _Age;
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {

            StudentInformationClass.SetFullName = FullName(txtLastName.Text, txtFirstName.Text, txtMiddleInitial.Text);
            StudentInformationClass.SetStudentNo = (int)StudentNumber(txtStudentNo.Text);
            StudentInformationClass.SetProgram = cbPrograms.Text;
            StudentInformationClass.SetGender = cbGender.Text;
            StudentInformationClass.SetContactNo = (int)ContactNo(txtContactNo.Text);
            StudentInformationClass.SetBirthday = datePickerBirthday.Value.ToString("yyyy-MM-dd");
            StudentInformationClass.SetAge = Age(txtAge.Text);

            frmConfirmation frm = new frmConfirmation();
            frm.ShowDialog();

          
        }

    }
}
        
    

