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
            this.EditAdminCheck = new System.Windows.Forms.CheckBox();
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
            this.EditAdminLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EditAdminCheck
            // 
            this.EditAdminCheck.AutoSize = true;
            this.EditAdminCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EditAdminCheck.Location = new System.Drawing.Point(163, 25);
            this.EditAdminCheck.Name = "EditAdminCheck";
            this.EditAdminCheck.Size = new System.Drawing.Size(15, 14);
            this.EditAdminCheck.TabIndex = 57;
            this.EditAdminCheck.UseVisualStyleBackColor = true;
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
            this.EditSpecializationCombo.Location = new System.Drawing.Point(163, 271);
            this.EditSpecializationCombo.Name = "EditSpecializationCombo";
            this.EditSpecializationCombo.Size = new System.Drawing.Size(176, 21);
            this.EditSpecializationCombo.TabIndex = 56;
            // 
            // EditJobCombo
            // 
            this.EditJobCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EditJobCombo.FormattingEnabled = true;
            this.EditJobCombo.Location = new System.Drawing.Point(163, 82);
            this.EditJobCombo.Name = "EditJobCombo";
            this.EditJobCombo.Size = new System.Drawing.Size(176, 21);
            this.EditJobCombo.TabIndex = 55;
            // 
            // EditSpecializationLbl
            // 
            this.EditSpecializationLbl.AutoSize = true;
            this.EditSpecializationLbl.BackColor = System.Drawing.Color.Transparent;
            this.EditSpecializationLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EditSpecializationLbl.Location = new System.Drawing.Point(71, 276);
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
            this.EditJobLbl.Location = new System.Drawing.Point(77, 90);
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
            this.EditPeselLbl.Location = new System.Drawing.Point(99, 63);
            this.EditPeselLbl.Name = "EditPeselLbl";
            this.EditPeselLbl.Size = new System.Drawing.Size(41, 13);
            this.EditPeselLbl.TabIndex = 52;
            this.EditPeselLbl.Text = "PESEL";
            // 
            // EditPeselTxt
            // 
            this.EditPeselTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EditPeselTxt.Location = new System.Drawing.Point(163, 56);
            this.EditPeselTxt.Name = "EditPeselTxt";
            this.EditPeselTxt.Size = new System.Drawing.Size(176, 20);
            this.EditPeselTxt.TabIndex = 51;
            // 
            // EditPwzLbl
            // 
            this.EditPwzLbl.AutoSize = true;
            this.EditPwzLbl.BackColor = System.Drawing.Color.Transparent;
            this.EditPwzLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EditPwzLbl.Location = new System.Drawing.Point(77, 248);
            this.EditPwzLbl.Name = "EditPwzLbl";
            this.EditPwzLbl.Size = new System.Drawing.Size(63, 13);
            this.EditPwzLbl.TabIndex = 50;
            this.EditPwzLbl.Text = "NumerPWZ";
            // 
            // EditPwzTxt
            // 
            this.EditPwzTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EditPwzTxt.Location = new System.Drawing.Point(163, 245);
            this.EditPwzTxt.Name = "EditPwzTxt";
            this.EditPwzTxt.Size = new System.Drawing.Size(176, 20);
            this.EditPwzTxt.TabIndex = 49;
            // 
            // RepeatPasswordLbl
            // 
            this.RepeatPasswordLbl.AutoSize = true;
            this.RepeatPasswordLbl.BackColor = System.Drawing.Color.Transparent;
            this.RepeatPasswordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RepeatPasswordLbl.Location = new System.Drawing.Point(63, 222);
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
            this.EditPasswordLbl.Location = new System.Drawing.Point(103, 196);
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
            this.EditUsernameLbl.Location = new System.Drawing.Point(38, 169);
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
            this.EditLastNameLbl.Location = new System.Drawing.Point(87, 138);
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
            this.EditFistNameLbl.Location = new System.Drawing.Point(114, 112);
            this.EditFistNameLbl.Name = "EditFistNameLbl";
            this.EditFistNameLbl.Size = new System.Drawing.Size(26, 13);
            this.EditFistNameLbl.TabIndex = 44;
            this.EditFistNameLbl.Text = "Imię";
            // 
            // RepeatPasswordTxt
            // 
            this.RepeatPasswordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RepeatPasswordTxt.Location = new System.Drawing.Point(163, 219);
            this.RepeatPasswordTxt.Name = "RepeatPasswordTxt";
            this.RepeatPasswordTxt.Size = new System.Drawing.Size(176, 20);
            this.RepeatPasswordTxt.TabIndex = 43;
            // 
            // EditUsernameTxt
            // 
            this.EditUsernameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EditUsernameTxt.Location = new System.Drawing.Point(163, 166);
            this.EditUsernameTxt.Name = "EditUsernameTxt";
            this.EditUsernameTxt.Size = new System.Drawing.Size(176, 20);
            this.EditUsernameTxt.TabIndex = 42;
            // 
            // EditPasswordTxt
            // 
            this.EditPasswordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EditPasswordTxt.Location = new System.Drawing.Point(163, 193);
            this.EditPasswordTxt.Name = "EditPasswordTxt";
            this.EditPasswordTxt.Size = new System.Drawing.Size(176, 20);
            this.EditPasswordTxt.TabIndex = 41;
            // 
            // EditLastNameTxt
            // 
            this.EditLastNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EditLastNameTxt.Location = new System.Drawing.Point(163, 135);
            this.EditLastNameTxt.Name = "EditLastNameTxt";
            this.EditLastNameTxt.Size = new System.Drawing.Size(176, 20);
            this.EditLastNameTxt.TabIndex = 40;
            // 
            // EditFirstNameTxt
            // 
            this.EditFirstNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EditFirstNameTxt.Location = new System.Drawing.Point(163, 109);
            this.EditFirstNameTxt.Name = "EditFirstNameTxt";
            this.EditFirstNameTxt.Size = new System.Drawing.Size(176, 20);
            this.EditFirstNameTxt.TabIndex = 39;
            // 
            // EditAdminLbl
            // 
            this.EditAdminLbl.AutoSize = true;
            this.EditAdminLbl.BackColor = System.Drawing.Color.Transparent;
            this.EditAdminLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EditAdminLbl.Location = new System.Drawing.Point(73, 25);
            this.EditAdminLbl.Name = "EditAdminLbl";
            this.EditAdminLbl.Size = new System.Drawing.Size(67, 13);
            this.EditAdminLbl.TabIndex = 38;
            this.EditAdminLbl.Text = "Administrator";
            // 
            // UcEditUsers
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.EditAdminCheck);
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
            this.Controls.Add(this.EditAdminLbl);
            this.Name = "UcEditUsers";
            this.Size = new System.Drawing.Size(565, 442);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox EditAdminCheck;
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
        private System.Windows.Forms.Label EditAdminLbl;
    }
}
