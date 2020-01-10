using System;
using System.Drawing;
using System.Windows.Forms;
using THLIB;
using Newtonsoft.Json;
using System.Linq;

namespace THUI
{
    public partial class UcEditUsers : UserControl
    {
        private static UcEditUsers _instance;

        public static UcEditUsers Instance {
            get {
                if (_instance == null)
                {
                    _instance = new UcEditUsers();
                }
                return _instance;
            }
        }

        public UcEditUsers()
        {
            InitializeComponent();
        }

        private void ValidatePeselBtn_Click(object sender, EventArgs e)
        {
            // todo check if user with this PESEL exist
            if (PeselValidator.ValidatePesel(EditPeselTxt.Text) == true)
            {
                ValidatePeselLbl.ForeColor = Color.Green;
                ValidatePeselLbl.Text = "PESEL ✔";
                EditJobCombo.Enabled = true;
            }
            else
            {
                // Note debugging
                ValidatePeselLbl.ForeColor = Color.Red;
                ValidatePeselLbl.Text = "PESEL NIEPOPRAWNY.";
                EditJobCombo.Enabled = true;
            }
        }

        private void EditJobCombo_SelectedValueChanged(object sender, EventArgs e)
        {
            // if
        }

        private void RepeatPasswordTxt_TextChanged(object sender, EventArgs e)
        {
            // todo if both passwords are true, OK, else passwords missmatch
            if (EditPasswordTxt.Text == RepeatPasswordTxt.Text)
            {
                ValidatePasswordsMatchBtn.ForeColor = Color.Green;
                ValidatePasswordsMatchBtn.Text = "HASŁA ✔";
            }
            else
            {
                ValidatePasswordsMatchBtn.ForeColor = Color.Red;
                ValidatePasswordsMatchBtn.Text = "HASŁA NIE SĄ TAKIE SAME";
                AddEmployeeBtn.Enabled = false;
            }
        }

        private void AddEmployeeBtn_Click(object sender, EventArgs e)
        {
            switch (EditJobCombo.Text)
            {
                case "Administrator":
                    {
                        Employee employee = new Employee
                        {
                            Pesel = EditPeselTxt.Text,
                            JobPosition = EditJobCombo.Text,
                            FirstName = EditFirstNameTxt.Text,
                            LastName = EditLastNameTxt.Text,
                            Password = EditPasswordTxt.Text,
                            Username = EditUsernameTxt.Text
                        };
                        Employee.AllEmployeeDictionary.Add(employee.Username, employee);
                    }
                    break;

                case "Lekarz":
                    {
                        Doctor doctor = new Doctor()
                        {
                            Pesel = EditPeselTxt.Text,
                            JobPosition = EditJobCombo.Text,
                            FirstName = EditFirstNameTxt.Text,
                            LastName = EditLastNameTxt.Text,
                            Password = EditPasswordTxt.Text,
                            Username = EditUsernameTxt.Text,
                            Specialization = EditSpecializationCombo.Text,
                            NummerPwz = int.Parse(EditPwzTxt.Text)
                        };

                        Doctor.AllEmployeeDictionary.Add(doctor.Username, doctor);
                    }
                        break;
                case "Pielęgniarka":
                    {
                        Nurse nurse = new Nurse
                        {
                            Pesel = EditPeselTxt.Text,
                            JobPosition = EditJobCombo.Text,
                            FirstName = EditFirstNameTxt.Text,
                            LastName = EditLastNameTxt.Text,
                            Password = EditPasswordTxt.Text,
                            Username = EditUsernameTxt.Text
                        };
                        Nurse.AllEmployeeDictionary.Add(nurse.Username, nurse);
                    }
                        break;

            }
        }//end of private void AddEmployeeBtn_Click

        // todo add all visible fields validation before adding new user


        // todo tryAdd if doesn't exist
        // employee.EmployeesList.Add(new
        
        //    FirstName= EditFirstNameTxt.Text;
        //employee.Pesel= EditPeselTxt.Text;
        //employee.JobPosition=EditJobCombo.Text;
        //employee.Password=EditPasswordTxt.Text;

        private void EditEmployeeBtn_Click(object sender, EventArgs e)
        {
            // todo edit employee (update dialog and save to file and datagrid)
        }

        private void RemoveEmployeeBtn_Click(object sender, EventArgs e)
        {
            //todo add dialog are you sure that you want to delete user?
        }

        private void ValidateUsernameExistBtn_Click(object sender, EventArgs e)
        {
            // todo check if username exist
            if (EditUsernameTxt.Text == "admin")
            {
                ValidateUserExistLbl.ForeColor = Color.Green;
                ValidateUserExistLbl.Text = "✔";
            }
            else
            {
                ValidateUserExistLbl.Text = "NAZWA ZAJĘTA";
                ValidateUserExistLbl.ForeColor = Color.Red;
            }
        }

        private void ValidatePwzNummerBtn_Click(object sender, EventArgs e)
        {
            // todo add validation of PWZ nummer
            if (EditPwzTxt.Text == "")
            {
                ValidatePwzNummerLbl.ForeColor = Color.Green;
                ValidatePwzNummerLbl.Text = "✔";
            }
            else
            {
                ValidatePwzNummerLbl.Text = "NUMER NIEPOPRAWNY";
                ValidatePwzNummerLbl.ForeColor = Color.Red;
            }
        }

        private void EditJobCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EditJobCombo.Text == "Lekarz")
            {
                EditSpecializationCombo.Enabled = true;
            }
            else
            {
                EditSpecializationCombo.Enabled = false;
                EditSpecializationCombo.Text = String.Empty;
            }
        }

        private void UcEditUsers_Load(object sender, EventArgs e)
        {
            EditSpecializationCombo.Enabled = false;
            EditJobCombo.Enabled = true;
           var _employeeDataArray = from row in THLIB.Employee.AllEmployeeDictionary select new {pesel = row.Key, row = row.Value };
            dataGridView1.DataSource = THLIB.Employee.AllEmployeeDictionary.ToArray();
            
        }

        private void ValidateUserExistLbl_Click(object sender, EventArgs e)
        {

        }

        private void ValidatePasswordsMatchBtn_Click(object sender, EventArgs e)
        {

        }

        private void ValidatePeselLbl_Click(object sender, EventArgs e)
        {

        }

        private void EditSpecializationCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ValidatePwzNummerLbl_Click(object sender, EventArgs e)
        {

        }

        private void EditSpecializationLbl_Click(object sender, EventArgs e)
        {

        }

        private void EditJobLbl_Click(object sender, EventArgs e)
        {

        }

        private void EditPeselLbl_Click(object sender, EventArgs e)
        {

        }

        private void EditPeselTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void EditPwzLbl_Click(object sender, EventArgs e)
        {

        }

        private void EditPwzTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void RepeatPasswordLbl_Click(object sender, EventArgs e)
        {

        }

        private void EditPasswordLbl_Click(object sender, EventArgs e)
        {

        }

        private void EditUsernameLbl_Click(object sender, EventArgs e)
        {

        }

        private void EditLastNameLbl_Click(object sender, EventArgs e)
        {

        }

        private void EditFistNameLbl_Click(object sender, EventArgs e)
        {

        }

        private void EditUsernameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void EditPasswordTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void EditLastNameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void EditFirstNameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}