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
            this.components = new System.ComponentModel.Container();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EmployeeListBox = new System.Windows.Forms.ListBox();
            this.LoadFromFileBtn = new System.Windows.Forms.Button();
            this.EmployeeListLbl = new System.Windows.Forms.Label();
            this.SearchFileBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(THLIB.Employee);
            this.employeeBindingSource.CurrentChanged += new System.EventHandler(this.employeeBindingSource_CurrentChanged);
            // 
            // EmployeeListBox
            // 
            this.EmployeeListBox.FormattingEnabled = true;
            this.EmployeeListBox.Location = new System.Drawing.Point(16, 55);
            this.EmployeeListBox.Name = "EmployeeListBox";
            this.EmployeeListBox.Size = new System.Drawing.Size(187, 173);
            this.EmployeeListBox.TabIndex = 0;
            // 
            // LoadFromFileBtn
            // 
            this.LoadFromFileBtn.Location = new System.Drawing.Point(209, 205);
            this.LoadFromFileBtn.Name = "LoadFromFileBtn";
            this.LoadFromFileBtn.Size = new System.Drawing.Size(75, 23);
            this.LoadFromFileBtn.TabIndex = 1;
            this.LoadFromFileBtn.Text = "Wczytaj";
            this.LoadFromFileBtn.UseVisualStyleBackColor = true;
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
            this.SearchFileBtn.Location = new System.Drawing.Point(209, 176);
            this.SearchFileBtn.Name = "SearchFileBtn";
            this.SearchFileBtn.Size = new System.Drawing.Size(75, 23);
            this.SearchFileBtn.TabIndex = 3;
            this.SearchFileBtn.Text = "Przeglądaj...";
            this.SearchFileBtn.UseVisualStyleBackColor = true;
            this.SearchFileBtn.Click += new System.EventHandler(this.SearchFileBtn_Click);
            // 
            // UcUsersList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.SearchFileBtn);
            this.Controls.Add(this.EmployeeListLbl);
            this.Controls.Add(this.LoadFromFileBtn);
            this.Controls.Add(this.EmployeeListBox);
            this.Name = "UcUsersList";
            this.Size = new System.Drawing.Size(565, 442);
            
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.ListBox EmployeeListBox;
        private System.Windows.Forms.Button LoadFromFileBtn;
        private System.Windows.Forms.Label EmployeeListLbl;
        private System.Windows.Forms.Button SearchFileBtn;
    }
}
