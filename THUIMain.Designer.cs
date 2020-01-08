namespace THUI
{
    partial class THUIMain
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

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucSchedule1 = new THUI.UcSchedule();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.UsernameTxt = new System.Windows.Forms.TextBox();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.UsernameLbl = new System.Windows.Forms.Label();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.ScheduleBtn = new System.Windows.Forms.Button();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.EmployeesListBtn = new System.Windows.Forms.Button();
            this.EditEmployeesBtn = new System.Windows.Forms.Button();
            this.EditScheduleBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucSchedule1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(652, 448);
            this.panel1.TabIndex = 0;
            // 
            // ucSchedule1
            // 
            this.ucSchedule1.AutoSize = true;
            this.ucSchedule1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ucSchedule1.Location = new System.Drawing.Point(3, 3);
            this.ucSchedule1.Name = "ucSchedule1";
            this.ucSchedule1.Size = new System.Drawing.Size(649, 445);
            this.ucSchedule1.TabIndex = 0;
            this.ucSchedule1.Visible = false;
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(751, 416);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(116, 23);
            this.ExitBtn.TabIndex = 1;
            this.ExitBtn.Text = "Wyjście";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Location = new System.Drawing.Point(751, 271);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(116, 23);
            this.LogoutBtn.TabIndex = 2;
            this.LogoutBtn.Text = "Wyloguj";
            this.LogoutBtn.UseVisualStyleBackColor = true;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // UsernameTxt
            // 
            this.UsernameTxt.Location = new System.Drawing.Point(768, 150);
            this.UsernameTxt.Name = "UsernameTxt";
            this.UsernameTxt.Size = new System.Drawing.Size(100, 20);
            this.UsernameTxt.TabIndex = 3;
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Location = new System.Drawing.Point(768, 176);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.Size = new System.Drawing.Size(100, 20);
            this.PasswordTxt.TabIndex = 4;
            // 
            // UsernameLbl
            // 
            this.UsernameLbl.AutoSize = true;
            this.UsernameLbl.Location = new System.Drawing.Point(658, 157);
            this.UsernameLbl.Name = "UsernameLbl";
            this.UsernameLbl.Size = new System.Drawing.Size(104, 13);
            this.UsernameLbl.TabIndex = 5;
            this.UsernameLbl.Text = "Nazwa Użytkownika";
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.Location = new System.Drawing.Point(726, 183);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(36, 13);
            this.PasswordLbl.TabIndex = 6;
            this.PasswordLbl.Text = "Hasło";
            // 
            // ScheduleBtn
            // 
            this.ScheduleBtn.Location = new System.Drawing.Point(751, 13);
            this.ScheduleBtn.Name = "ScheduleBtn";
            this.ScheduleBtn.Size = new System.Drawing.Size(116, 23);
            this.ScheduleBtn.TabIndex = 7;
            this.ScheduleBtn.Text = "Grafik";
            this.ScheduleBtn.UseVisualStyleBackColor = true;
            this.ScheduleBtn.Click += new System.EventHandler(this.ScheduleBtn_Click);
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(751, 242);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(117, 23);
            this.LoginBtn.TabIndex = 8;
            this.LoginBtn.Text = "Zaloguj";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // EmployeesListBtn
            // 
            this.EmployeesListBtn.Location = new System.Drawing.Point(752, 71);
            this.EmployeesListBtn.Name = "EmployeesListBtn";
            this.EmployeesListBtn.Size = new System.Drawing.Size(116, 23);
            this.EmployeesListBtn.TabIndex = 9;
            this.EmployeesListBtn.Text = "Lista Pracowników";
            this.EmployeesListBtn.UseVisualStyleBackColor = true;
            this.EmployeesListBtn.Click += new System.EventHandler(this.EmployeesListBtn_Click);
            // 
            // EditEmployeesBtn
            // 
            this.EditEmployeesBtn.Location = new System.Drawing.Point(752, 100);
            this.EditEmployeesBtn.Name = "EditEmployeesBtn";
            this.EditEmployeesBtn.Size = new System.Drawing.Size(116, 23);
            this.EditEmployeesBtn.TabIndex = 10;
            this.EditEmployeesBtn.Text = "Edycja Pracowników";
            this.EditEmployeesBtn.UseVisualStyleBackColor = true;
            this.EditEmployeesBtn.Click += new System.EventHandler(this.EditEmployeesBtn_Click);
            // 
            // EditScheduleBtn
            // 
            this.EditScheduleBtn.Location = new System.Drawing.Point(752, 42);
            this.EditScheduleBtn.Name = "EditScheduleBtn";
            this.EditScheduleBtn.Size = new System.Drawing.Size(116, 23);
            this.EditScheduleBtn.TabIndex = 11;
            this.EditScheduleBtn.Text = "Edycja Grafiku";
            this.EditScheduleBtn.UseVisualStyleBackColor = true;
            this.EditScheduleBtn.Click += new System.EventHandler(this.EditScheduleBtn_Click);
            // 
            // THUIMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 453);
            this.Controls.Add(this.EditScheduleBtn);
            this.Controls.Add(this.EditEmployeesBtn);
            this.Controls.Add(this.EmployeesListBtn);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.ScheduleBtn);
            this.Controls.Add(this.PasswordLbl);
            this.Controls.Add(this.UsernameLbl);
            this.Controls.Add(this.PasswordTxt);
            this.Controls.Add(this.UsernameTxt);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.panel1);
            this.Name = "THUIMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.THUIMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private UcSchedule ucSchedule1;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.TextBox UsernameTxt;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.Label UsernameLbl;
        private System.Windows.Forms.Label PasswordLbl;
        private System.Windows.Forms.Button ScheduleBtn;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Button EmployeesListBtn;
        private System.Windows.Forms.Button EditEmployeesBtn;
        private System.Windows.Forms.Button EditScheduleBtn;
    }
}

