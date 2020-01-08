namespace THUI
{
    partial class UcEditUsers
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.EditSpecializationCombo = new System.Windows.Forms.ComboBox();
            this.EditJobCombo = new System.Windows.Forms.ComboBox();
            this.EditSpecializationLbl = new System.Windows.Forms.Label();
            this.EditJobLbl = new System.Windows.Forms.Label();
            this.EditPeselLbl = new System.Windows.Forms.Label();
            this.EditPeselTxt = new System.Windows.Forms.TextBox();
            this.EditPwzLbl = new System.Windows.Forms.Label();
            this.EditPwzTxt = new System.Windows.Forms.TextBox();
            this.RepeatPasswordLbl = new System.Windows.Forms.Label();
            this.EditPasswordLbl = new System.Windows.Forms.Label();
            this.EditUsernameLbl = new System.Windows.Forms.Label();
            this.EditLastNameLbl = new System.Windows.Forms.Label();
            this.EditFistNameLbl = new System.Windows.Forms.Label();
            this.RepeatPasswordTxt = new System.Windows.Forms.TextBox();
            this.EditUsernameTxt = new System.Windows.Forms.TextBox();
            this.EditPasswordTxt = new System.Windows.Forms.TextBox();
            this.EditLastNameTxt = new System.Windows.Forms.TextBox();
            this.EditFirstNameTxt = new System.Windows.Forms.TextBox();
            this.ValidatePeselBtn = new System.Windows.Forms.Button();
            this.ValidatePeselLbl = new System.Windows.Forms.Label();
            this.AddEmployeeBtn = new System.Windows.Forms.Button();
            this.EditEmployeeBtn = new System.Windows.Forms.Button();
            this.RemoveEmployeeBtn = new System.Windows.Forms.Button();
            this.ValidatePwzNummerBtn = new System.Windows.Forms.Button();
            this.ValidatePasswordsMatchBtn = new System.Windows.Forms.Label();
            this.ValidateUsernameExistBtn = new System.Windows.Forms.Button();
            this.ValidateUserExistLbl = new System.Windows.Forms.Label();
            this.ValidatePwzNummerLbl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.jobPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nummerPwz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialization = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // EditSpecializationCombo
            // 
            this.EditSpecializationCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EditSpecializationCombo.FormattingEnabled = true;
            this.EditSpecializationCombo.Items.AddRange(new object[] {
            "Kardiolog",
            "Urolog",
            "Neurolog",
            "Laryngolog"});
            this.EditSpecializationCombo.Location = new System.Drawing.Point(339, 380);
            this.EditSpecializationCombo.Name = "EditSpecializationCombo";
            this.EditSpecializationCombo.Size = new System.Drawing.Size(176, 21);
            this.EditSpecializationCombo.TabIndex = 56;
            // 
            // EditJobCombo
            // 
            this.EditJobCombo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "JobPosition", true));
            this.EditJobCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EditJobCombo.FormattingEnabled = true;
            this.EditJobCombo.Items.AddRange(new object[] {
            "Lekarz",
            "Administrator",
            "Pielęgniarka"});
            this.EditJobCombo.Location = new System.Drawing.Point(339, 191);
            this.EditJobCombo.Name = "EditJobCombo";
            this.EditJobCombo.Size = new System.Drawing.Size(176, 21);
            this.EditJobCombo.TabIndex = 55;
            this.EditJobCombo.SelectedIndexChanged += new System.EventHandler(this.EditJobCombo_SelectedIndexChanged);
            this.EditJobCombo.SelectedValueChanged += new System.EventHandler(this.EditJobCombo_SelectedValueChanged);
            // 
            // EditSpecializationLbl
            // 
            this.EditSpecializationLbl.AutoSize = true;
            this.EditSpecializationLbl.BackColor = System.Drawing.Color.Transparent;
            this.EditSpecializationLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EditSpecializationLbl.Location = new System.Drawing.Point(247, 385);
            this.EditSpecializationLbl.Name = "EditSpecializationLbl";
            this.EditSpecializationLbl.Size = new System.Drawing.Size(69, 13);
            this.EditSpecializationLbl.TabIndex = 54;
            this.EditSpecializationLbl.Text = "Specjalizacja";
            // 
            // EditJobLbl
            // 
            this.EditJobLbl.AutoSize = true;
            this.EditJobLbl.BackColor = System.Drawing.Color.Transparent;
            this.EditJobLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EditJobLbl.Location = new System.Drawing.Point(254, 199);
            this.EditJobLbl.Name = "EditJobLbl";
            this.EditJobLbl.Size = new System.Drawing.Size(62, 13);
            this.EditJobLbl.TabIndex = 53;
            this.EditJobLbl.Text = "Stanowisko";
            // 
            // EditPeselLbl
            // 
            this.EditPeselLbl.AutoSize = true;
            this.EditPeselLbl.BackColor = System.Drawing.Color.Transparent;
            this.EditPeselLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EditPeselLbl.Location = new System.Drawing.Point(275, 172);
            this.EditPeselLbl.Name = "EditPeselLbl";
            this.EditPeselLbl.Size = new System.Drawing.Size(41, 13);
            this.EditPeselLbl.TabIndex = 52;
            this.EditPeselLbl.Text = "PESEL";
            // 
            // EditPeselTxt
            // 
            this.EditPeselTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Pesel", true));
            this.EditPeselTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EditPeselTxt.Location = new System.Drawing.Point(339, 165);
            this.EditPeselTxt.Name = "EditPeselTxt";
            this.EditPeselTxt.Size = new System.Drawing.Size(176, 20);
            this.EditPeselTxt.TabIndex = 51;
            // 
            // EditPwzLbl
            // 
            this.EditPwzLbl.AutoSize = true;
            this.EditPwzLbl.BackColor = System.Drawing.Color.Transparent;
            this.EditPwzLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EditPwzLbl.Location = new System.Drawing.Point(253, 357);
            this.EditPwzLbl.Name = "EditPwzLbl";
            this.EditPwzLbl.Size = new System.Drawing.Size(63, 13);
            this.EditPwzLbl.TabIndex = 50;
            this.EditPwzLbl.Text = "NumerPWZ";
            // 
            // EditPwzTxt
            // 
            this.EditPwzTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EditPwzTxt.Location = new System.Drawing.Point(339, 354);
            this.EditPwzTxt.Name = "EditPwzTxt";
            this.EditPwzTxt.Size = new System.Drawing.Size(176, 20);
            this.EditPwzTxt.TabIndex = 49;
            // 
            // RepeatPasswordLbl
            // 
            this.RepeatPasswordLbl.AutoSize = true;
            this.RepeatPasswordLbl.BackColor = System.Drawing.Color.Transparent;
            this.RepeatPasswordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RepeatPasswordLbl.Location = new System.Drawing.Point(239, 331);
            this.RepeatPasswordLbl.Name = "RepeatPasswordLbl";
            this.RepeatPasswordLbl.Size = new System.Drawing.Size(77, 13);
            this.RepeatPasswordLbl.TabIndex = 48;
            this.RepeatPasswordLbl.Text = "Powtórz Hasło";
            // 
            // EditPasswordLbl
            // 
            this.EditPasswordLbl.AutoSize = true;
            this.EditPasswordLbl.BackColor = System.Drawing.Color.Transparent;
            this.EditPasswordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EditPasswordLbl.Location = new System.Drawing.Point(280, 305);
            this.EditPasswordLbl.Name = "EditPasswordLbl";
            this.EditPasswordLbl.Size = new System.Drawing.Size(36, 13);
            this.EditPasswordLbl.TabIndex = 47;
            this.EditPasswordLbl.Text = "Hasło";
            // 
            // EditUsernameLbl
            // 
            this.EditUsernameLbl.AutoSize = true;
            this.EditUsernameLbl.BackColor = System.Drawing.Color.Transparent;
            this.EditUsernameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EditUsernameLbl.Location = new System.Drawing.Point(214, 278);
            this.EditUsernameLbl.Name = "EditUsernameLbl";
            this.EditUsernameLbl.Size = new System.Drawing.Size(102, 13);
            this.EditUsernameLbl.TabIndex = 46;
            this.EditUsernameLbl.Text = "Nazwa użytkownika";
            // 
            // EditLastNameLbl
            // 
            this.EditLastNameLbl.AutoSize = true;
            this.EditLastNameLbl.BackColor = System.Drawing.Color.Transparent;
            this.EditLastNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EditLastNameLbl.Location = new System.Drawing.Point(263, 247);
            this.EditLastNameLbl.Name = "EditLastNameLbl";
            this.EditLastNameLbl.Size = new System.Drawing.Size(53, 13);
            this.EditLastNameLbl.TabIndex = 45;
            this.EditLastNameLbl.Text = "Nazwisko";
            // 
            // EditFistNameLbl
            // 
            this.EditFistNameLbl.AutoSize = true;
            this.EditFistNameLbl.BackColor = System.Drawing.Color.Transparent;
            this.EditFistNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EditFistNameLbl.Location = new System.Drawing.Point(290, 221);
            this.EditFistNameLbl.Name = "EditFistNameLbl";
            this.EditFistNameLbl.Size = new System.Drawing.Size(26, 13);
            this.EditFistNameLbl.TabIndex = 44;
            this.EditFistNameLbl.Text = "Imię";
            // 
            // RepeatPasswordTxt
            // 
            this.RepeatPasswordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RepeatPasswordTxt.Location = new System.Drawing.Point(339, 328);
            this.RepeatPasswordTxt.Name = "RepeatPasswordTxt";
            this.RepeatPasswordTxt.Size = new System.Drawing.Size(176, 20);
            this.RepeatPasswordTxt.TabIndex = 43;
            this.RepeatPasswordTxt.TextChanged += new System.EventHandler(this.RepeatPasswordTxt_TextChanged);
            // 
            // EditUsernameTxt
            // 
            this.EditUsernameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EditUsernameTxt.Location = new System.Drawing.Point(339, 275);
            this.EditUsernameTxt.Name = "EditUsernameTxt";
            this.EditUsernameTxt.Size = new System.Drawing.Size(176, 20);
            this.EditUsernameTxt.TabIndex = 42;
            // 
            // EditPasswordTxt
            // 
            this.EditPasswordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EditPasswordTxt.Location = new System.Drawing.Point(339, 302);
            this.EditPasswordTxt.Name = "EditPasswordTxt";
            this.EditPasswordTxt.Size = new System.Drawing.Size(176, 20);
            this.EditPasswordTxt.TabIndex = 41;
            // 
            // EditLastNameTxt
            // 
            this.EditLastNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EditLastNameTxt.Location = new System.Drawing.Point(339, 244);
            this.EditLastNameTxt.Name = "EditLastNameTxt";
            this.EditLastNameTxt.Size = new System.Drawing.Size(176, 20);
            this.EditLastNameTxt.TabIndex = 40;
            // 
            // EditFirstNameTxt
            // 
            this.EditFirstNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EditFirstNameTxt.Location = new System.Drawing.Point(339, 218);
            this.EditFirstNameTxt.Name = "EditFirstNameTxt";
            this.EditFirstNameTxt.Size = new System.Drawing.Size(176, 20);
            this.EditFirstNameTxt.TabIndex = 39;
            // 
            // ValidatePeselBtn
            // 
            this.ValidatePeselBtn.Location = new System.Drawing.Point(527, 165);
            this.ValidatePeselBtn.Name = "ValidatePeselBtn";
            this.ValidatePeselBtn.Size = new System.Drawing.Size(107, 23);
            this.ValidatePeselBtn.TabIndex = 58;
            this.ValidatePeselBtn.Text = "Sprawdź poprawność";
            this.ValidatePeselBtn.UseVisualStyleBackColor = true;
            this.ValidatePeselBtn.Click += new System.EventHandler(this.ValidatePeselBtn_Click);
            // 
            // ValidatePeselLbl
            // 
            this.ValidatePeselLbl.AutoSize = true;
            this.ValidatePeselLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ValidatePeselLbl.Location = new System.Drawing.Point(527, 194);
            this.ValidatePeselLbl.Name = "ValidatePeselLbl";
            this.ValidatePeselLbl.Size = new System.Drawing.Size(0, 13);
            this.ValidatePeselLbl.TabIndex = 59;
            // 
            // AddEmployeeBtn
            // 
            this.AddEmployeeBtn.Location = new System.Drawing.Point(519, 407);
            this.AddEmployeeBtn.Name = "AddEmployeeBtn";
            this.AddEmployeeBtn.Size = new System.Drawing.Size(115, 23);
            this.AddEmployeeBtn.TabIndex = 60;
            this.AddEmployeeBtn.Text = "Dodaj Pracownika";
            this.AddEmployeeBtn.UseVisualStyleBackColor = true;
            this.AddEmployeeBtn.Click += new System.EventHandler(this.AddEmployeeBtn_Click);
            // 
            // EditEmployeeBtn
            // 
            this.EditEmployeeBtn.Location = new System.Drawing.Point(387, 407);
            this.EditEmployeeBtn.Name = "EditEmployeeBtn";
            this.EditEmployeeBtn.Size = new System.Drawing.Size(115, 23);
            this.EditEmployeeBtn.TabIndex = 61;
            this.EditEmployeeBtn.Text = "Edytuj Pracownika";
            this.EditEmployeeBtn.UseVisualStyleBackColor = true;
            this.EditEmployeeBtn.Click += new System.EventHandler(this.EditEmployeeBtn_Click);
            // 
            // RemoveEmployeeBtn
            // 
            this.RemoveEmployeeBtn.Location = new System.Drawing.Point(250, 407);
            this.RemoveEmployeeBtn.Name = "RemoveEmployeeBtn";
            this.RemoveEmployeeBtn.Size = new System.Drawing.Size(115, 23);
            this.RemoveEmployeeBtn.TabIndex = 62;
            this.RemoveEmployeeBtn.Text = "Usuń Pracownika";
            this.RemoveEmployeeBtn.UseVisualStyleBackColor = true;
            this.RemoveEmployeeBtn.Click += new System.EventHandler(this.RemoveEmployeeBtn_Click);
            // 
            // ValidatePwzNummerBtn
            // 
            this.ValidatePwzNummerBtn.Location = new System.Drawing.Point(527, 352);
            this.ValidatePwzNummerBtn.Name = "ValidatePwzNummerBtn";
            this.ValidatePwzNummerBtn.Size = new System.Drawing.Size(107, 23);
            this.ValidatePwzNummerBtn.TabIndex = 63;
            this.ValidatePwzNummerBtn.Text = "Sprawdź poprawność";
            this.ValidatePwzNummerBtn.UseVisualStyleBackColor = true;
            this.ValidatePwzNummerBtn.Click += new System.EventHandler(this.ValidatePwzNummerBtn_Click);
            // 
            // ValidatePasswordsMatchBtn
            // 
            this.ValidatePasswordsMatchBtn.AutoSize = true;
            this.ValidatePasswordsMatchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ValidatePasswordsMatchBtn.Location = new System.Drawing.Point(527, 331);
            this.ValidatePasswordsMatchBtn.Name = "ValidatePasswordsMatchBtn";
            this.ValidatePasswordsMatchBtn.Size = new System.Drawing.Size(0, 13);
            this.ValidatePasswordsMatchBtn.TabIndex = 64;
            // 
            // ValidateUsernameExistBtn
            // 
            this.ValidateUsernameExistBtn.Location = new System.Drawing.Point(527, 273);
            this.ValidateUsernameExistBtn.Name = "ValidateUsernameExistBtn";
            this.ValidateUsernameExistBtn.Size = new System.Drawing.Size(107, 23);
            this.ValidateUsernameExistBtn.TabIndex = 65;
            this.ValidateUsernameExistBtn.Text = "Sprawdź poprawność";
            this.ValidateUsernameExistBtn.UseVisualStyleBackColor = true;
            this.ValidateUsernameExistBtn.Click += new System.EventHandler(this.ValidateUsernameExistBtn_Click);
            // 
            // ValidateUserExistLbl
            // 
            this.ValidateUserExistLbl.AutoSize = true;
            this.ValidateUserExistLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ValidateUserExistLbl.Location = new System.Drawing.Point(527, 306);
            this.ValidateUserExistLbl.Name = "ValidateUserExistLbl";
            this.ValidateUserExistLbl.Size = new System.Drawing.Size(0, 13);
            this.ValidateUserExistLbl.TabIndex = 66;
            // 
            // ValidatePwzNummerLbl
            // 
            this.ValidatePwzNummerLbl.AutoSize = true;
            this.ValidatePwzNummerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ValidatePwzNummerLbl.Location = new System.Drawing.Point(527, 385);
            this.ValidatePwzNummerLbl.Name = "ValidatePwzNummerLbl";
            this.ValidatePwzNummerLbl.Size = new System.Drawing.Size(0, 13);
            this.ValidatePwzNummerLbl.TabIndex = 67;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jobPosition,
            this.firstName,
            this.lastName,
            this.pesel,
            this.nummerPwz,
            this.username,
            this.password,
            this.specialization});
            this.dataGridView1.Location = new System.Drawing.Point(15, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(543, 150);
            this.dataGridView1.TabIndex = 68;
            // 
            // jobPosition
            // 
            this.jobPosition.HeaderText = "Stanowisko";
            this.jobPosition.Name = "jobPosition";
            this.jobPosition.ReadOnly = true;
            // 
            // firstName
            // 
            this.firstName.HeaderText = "Imię";
            this.firstName.Name = "firstName";
            this.firstName.ReadOnly = true;
            // 
            // lastName
            // 
            this.lastName.HeaderText = "Nazwisko";
            this.lastName.Name = "lastName";
            this.lastName.ReadOnly = true;
            // 
            // pesel
            // 
            this.pesel.HeaderText = "PESEL";
            this.pesel.Name = "pesel";
            this.pesel.ReadOnly = true;
            this.pesel.Visible = false;
            // 
            // nummerPwz
            // 
            this.nummerPwz.HeaderText = "Numer PWZ";
            this.nummerPwz.Name = "nummerPwz";
            this.nummerPwz.ReadOnly = true;
            // 
            // username
            // 
            this.username.HeaderText = "Nazwa użytkownika";
            this.username.Name = "username";
            this.username.ReadOnly = true;
            this.username.Visible = false;
            // 
            // password
            // 
            this.password.HeaderText = "Hasło";
            this.password.Name = "password";
            this.password.ReadOnly = true;
            this.password.Visible = false;
            // 
            // specialization
            // 
            this.specialization.HeaderText = "Specjalizacja";
            this.specialization.Name = "specialization";
            this.specialization.ReadOnly = true;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(THLIB.Employee);
            // 
            // UcEditUsers
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ValidatePwzNummerLbl);
            this.Controls.Add(this.ValidateUserExistLbl);
            this.Controls.Add(this.ValidateUsernameExistBtn);
            this.Controls.Add(this.ValidatePasswordsMatchBtn);
            this.Controls.Add(this.ValidatePwzNummerBtn);
            this.Controls.Add(this.RemoveEmployeeBtn);
            this.Controls.Add(this.EditEmployeeBtn);
            this.Controls.Add(this.AddEmployeeBtn);
            this.Controls.Add(this.ValidatePeselLbl);
            this.Controls.Add(this.ValidatePeselBtn);
            this.Controls.Add(this.EditSpecializationCombo);
            this.Controls.Add(this.EditJobCombo);
            this.Controls.Add(this.EditSpecializationLbl);
            this.Controls.Add(this.EditJobLbl);
            this.Controls.Add(this.EditPeselLbl);
            this.Controls.Add(this.EditPeselTxt);
            this.Controls.Add(this.EditPwzLbl);
            this.Controls.Add(this.EditPwzTxt);
            this.Controls.Add(this.RepeatPasswordLbl);
            this.Controls.Add(this.EditPasswordLbl);
            this.Controls.Add(this.EditUsernameLbl);
            this.Controls.Add(this.EditLastNameLbl);
            this.Controls.Add(this.EditFistNameLbl);
            this.Controls.Add(this.RepeatPasswordTxt);
            this.Controls.Add(this.EditUsernameTxt);
            this.Controls.Add(this.EditPasswordTxt);
            this.Controls.Add(this.EditLastNameTxt);
            this.Controls.Add(this.EditFirstNameTxt);
            this.Name = "UcEditUsers";
            this.Size = new System.Drawing.Size(649, 445);
            this.Load += new System.EventHandler(this.UcEditUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox EditSpecializationCombo;
        private System.Windows.Forms.ComboBox EditJobCombo;
        private System.Windows.Forms.Label EditSpecializationLbl;
        private System.Windows.Forms.Label EditJobLbl;
        private System.Windows.Forms.Label EditPeselLbl;
        private System.Windows.Forms.TextBox EditPeselTxt;
        private System.Windows.Forms.Label EditPwzLbl;
        private System.Windows.Forms.TextBox EditPwzTxt;
        private System.Windows.Forms.Label RepeatPasswordLbl;
        private System.Windows.Forms.Label EditPasswordLbl;
        private System.Windows.Forms.Label EditUsernameLbl;
        private System.Windows.Forms.Label EditLastNameLbl;
        private System.Windows.Forms.Label EditFistNameLbl;
        private System.Windows.Forms.TextBox RepeatPasswordTxt;
        private System.Windows.Forms.TextBox EditUsernameTxt;
        private System.Windows.Forms.TextBox EditPasswordTxt;
        private System.Windows.Forms.TextBox EditLastNameTxt;
        private System.Windows.Forms.TextBox EditFirstNameTxt;
        private System.Windows.Forms.Button ValidatePeselBtn;
        private System.Windows.Forms.Label ValidatePeselLbl;
        private System.Windows.Forms.Button AddEmployeeBtn;
        private System.Windows.Forms.Button EditEmployeeBtn;
        private System.Windows.Forms.Button RemoveEmployeeBtn;
        private System.Windows.Forms.Button ValidatePwzNummerBtn;
        private System.Windows.Forms.Label ValidatePasswordsMatchBtn;
        private System.Windows.Forms.Button ValidateUsernameExistBtn;
        private System.Windows.Forms.Label ValidateUserExistLbl;
        private System.Windows.Forms.Label ValidatePwzNummerLbl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesel;
        private System.Windows.Forms.DataGridViewTextBoxColumn nummerPwz;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialization;
        private System.Windows.Forms.BindingSource employeeBindingSource;
    }
}
