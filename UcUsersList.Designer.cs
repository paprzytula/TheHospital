namespace THUI
{
    partial class UcUsersList
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
            this.LoadFromFileBtn = new System.Windows.Forms.Button();
            this.EmployeeListLbl = new System.Windows.Forms.Label();
            this.SearchFileBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.jobPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nummerPwz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialization = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadFromFileBtn
            // 
            this.LoadFromFileBtn.Location = new System.Drawing.Point(460, 16);
            this.LoadFromFileBtn.Name = "LoadFromFileBtn";
            this.LoadFromFileBtn.Size = new System.Drawing.Size(75, 23);
            this.LoadFromFileBtn.TabIndex = 1;
            this.LoadFromFileBtn.Text = "Wczytaj";
            this.LoadFromFileBtn.UseVisualStyleBackColor = true;
            this.LoadFromFileBtn.Click += new System.EventHandler(this.LoadFromFileBtn_Click);
            // 
            // EmployeeListLbl
            // 
            this.EmployeeListLbl.AutoSize = true;
            this.EmployeeListLbl.Location = new System.Drawing.Point(16, 36);
            this.EmployeeListLbl.Name = "EmployeeListLbl";
            this.EmployeeListLbl.Size = new System.Drawing.Size(96, 13);
            this.EmployeeListLbl.TabIndex = 2;
            this.EmployeeListLbl.Text = "Lista Pracowników";
            // 
            // SearchFileBtn
            // 
            this.SearchFileBtn.Location = new System.Drawing.Point(541, 16);
            this.SearchFileBtn.Name = "SearchFileBtn";
            this.SearchFileBtn.Size = new System.Drawing.Size(75, 23);
            this.SearchFileBtn.TabIndex = 3;
            this.SearchFileBtn.Text = "Przeglądaj...";
            this.SearchFileBtn.UseVisualStyleBackColor = true;
            this.SearchFileBtn.Click += new System.EventHandler(this.SearchFileBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jobPosition,
            this.pesel,
            this.nummerPwz,
            this.lastName,
            this.username,
            this.password,
            this.specialization,
            this.firstName});
            this.dataGridView1.Location = new System.Drawing.Point(19, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(543, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // jobPosition
            // 
            this.jobPosition.HeaderText = "Stanowisko";
            this.jobPosition.Name = "jobPosition";
            this.jobPosition.ReadOnly = true;
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
            // lastName
            // 
            this.lastName.HeaderText = "Nazwisko";
            this.lastName.Name = "lastName";
            this.lastName.ReadOnly = true;
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
            // firstName
            // 
            this.firstName.HeaderText = "Imię";
            this.firstName.Name = "firstName";
            this.firstName.ReadOnly = true;
            // 
            // UcUsersList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SearchFileBtn);
            this.Controls.Add(this.EmployeeListLbl);
            this.Controls.Add(this.LoadFromFileBtn);
            this.Name = "UcUsersList";
            this.Size = new System.Drawing.Size(649, 445);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button LoadFromFileBtn;
        private System.Windows.Forms.Label EmployeeListLbl;
        private System.Windows.Forms.Button SearchFileBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesel;
        private System.Windows.Forms.DataGridViewTextBoxColumn nummerPwz;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialization;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
    }
}
