using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using THLIB;

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

        



        private void UcEditUsers_Load(object sender, EventArgs e)
        {
            EditSpecializationCombo.Enabled = false;
            EditJobCombo.Enabled = true;

            //employeeBindingSource.Add(new Employee(){Pesel="0", Imię = "admin", JobPosition="Lekarz", Nazwisko="Admin", Hasło ="admin",NazwaUżytkownika= "admin" });
            ////table.Columns.Add("Pesel", typeof(string));
            //table.Columns.Add("Imię", typeof(string));
            //table.Columns.Add("Nazwisko", typeof(string));
            //table.Columns.Add("Nazwa użytkownika", typeof(string));
            //table.Columns.Add("Stanowisko", typeof(string));
            //table.Columns.Add("Hasło", typeof(string));
            //table.Columns.Add("Specjalizacja", typeof(string));
            //table.Columns.Add("Numer PWZ", typeof(int));
           // employeeBindingSource = Hospital.AllEmployee;
           

     dataGridView1.DataSource = Hospital.AllEmployee;
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
            Employee employee = new Employee();
            // todo add rows with data on click
            int n = dataGridView1.Rows.Add();
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
        {
            Employee emp = row.DataBoundItem as Employee;
            
        }

            switch (EditJobCombo.Text)
            {
                case "Administrator":
                    {
                        Employee employee1 = new Employee
                        {
                            Pesel = EditPeselTxt.Text,
                            Stanowisko = EditJobCombo.Text,
                            Imię = EditFirstNameTxt.Text,
                            Nazwisko = EditLastNameTxt.Text,
                            Hasło = EditPasswordTxt.Text,
                            NazwaUżytkownika = EditUsernameTxt.Text
                        };

                        // check if the object exist
                        if (!Hospital.AllEmployee.Any(x => x.Pesel == employee1.Pesel))
                        {
                            Hospital.AllEmployee.Add(employee1);
                        }
                    }
                    break;

                case "Lekarz":
                    {
                        Doctor doctor = new Doctor()
                        {
                            Pesel = EditPeselTxt.Text,
                            Stanowisko = EditJobCombo.Text,
                            Imię = EditFirstNameTxt.Text,
                            Nazwisko = EditLastNameTxt.Text,
                            Hasło = EditPasswordTxt.Text,
                            NazwaUżytkownika = EditUsernameTxt.Text,
                            Specjalizacja = EditSpecializationCombo.Text,
                            NumerPWZ = int.Parse(EditPwzTxt.Text)
                        };

                        if (!(Hospital.AllEmployee.Any(x => x.Pesel == doctor.Pesel)))
                        {
                            Hospital.AllEmployee.Add(doctor);
                        }
                    }
                    break;

                case "Pielęgniarka":
                    {
                        Nurse nurse = new Nurse
                        {
                            Pesel = EditPeselTxt.Text,
                            Stanowisko = EditJobCombo.Text,
                            Imię = EditFirstNameTxt.Text,
                            Nazwisko = EditLastNameTxt.Text,
                            Hasło = EditPasswordTxt.Text,
                            NazwaUżytkownika = EditUsernameTxt.Text
                        };
                        if (!(Hospital.AllEmployee.Any(x => x.Pesel == nurse.Pesel)))
                        {
                            Hospital.AllEmployee.Add(nurse);
                        }
                    }
                    break;
            }
        }//end of private void AddEmployeeBtn_Click

        // todo add all visible fields validation before adding new user

        // todo tryAdd if doesn't exist
        // employee.EmployeesList.Add(new

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

        
    }
}