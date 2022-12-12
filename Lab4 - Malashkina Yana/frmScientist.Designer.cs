namespace Lab4___Malashkina_Yana
{
	partial class frmScientist
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.txtFaculty = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtDepartament = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtPosition = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtSalary = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtPositionDuration = new System.Windows.Forms.TextBox();
			this.ScientistBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.scientistBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.ScientistBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.scientistBindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(36, 51);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "П.І.П.";
			// 
			// txtName
			// 
			this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scientistBindingSource1, "Name", true, System.Windows.Forms.DataSourceUpdateMode.Never));
			this.txtName.Location = new System.Drawing.Point(150, 45);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(321, 26);
			this.txtName.TabIndex = 1;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(78, 337);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(108, 35);
			this.btnSave.TabIndex = 2;
			this.btnSave.Text = "Зберегти";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(36, 94);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(94, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "Факультет";
			// 
			// txtFaculty
			// 
			this.txtFaculty.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ScientistBindingSource, "Faculty", true, System.Windows.Forms.DataSourceUpdateMode.Never));
			this.txtFaculty.Location = new System.Drawing.Point(150, 88);
			this.txtFaculty.Name = "txtFaculty";
			this.txtFaculty.Size = new System.Drawing.Size(321, 26);
			this.txtFaculty.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(36, 136);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(81, 20);
			this.label3.TabIndex = 5;
			this.label3.Text = "Кафедра";
			// 
			// txtDepartament
			// 
			this.txtDepartament.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ScientistBindingSource, "Department", true, System.Windows.Forms.DataSourceUpdateMode.Never));
			this.txtDepartament.Location = new System.Drawing.Point(150, 130);
			this.txtDepartament.Name = "txtDepartament";
			this.txtDepartament.Size = new System.Drawing.Size(321, 26);
			this.txtDepartament.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(36, 180);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(67, 20);
			this.label4.TabIndex = 7;
			this.label4.Text = "Посада";
			// 
			// txtPosition
			// 
			this.txtPosition.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ScientistBindingSource, "Position", true, System.Windows.Forms.DataSourceUpdateMode.Never));
			this.txtPosition.Location = new System.Drawing.Point(150, 177);
			this.txtPosition.Name = "txtPosition";
			this.txtPosition.Size = new System.Drawing.Size(321, 26);
			this.txtPosition.TabIndex = 8;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(36, 251);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(153, 20);
			this.label5.TabIndex = 9;
			this.label5.Text = "Посадковий оклад";
			// 
			// txtSalary
			// 
			this.txtSalary.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ScientistBindingSource, "Salary", true, System.Windows.Forms.DataSourceUpdateMode.Never, null, "C2"));
			this.txtSalary.Location = new System.Drawing.Point(274, 245);
			this.txtSalary.Name = "txtSalary";
			this.txtSalary.Size = new System.Drawing.Size(197, 26);
			this.txtSalary.TabIndex = 10;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(36, 288);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(214, 40);
			this.label6.TabIndex = 11;
			this.label6.Text = "Час перебування на посаді\r\n(кількість місяців)";
			// 
			// txtPositionDuration
			// 
			this.txtPositionDuration.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ScientistBindingSource, "PositionDuration", true, System.Windows.Forms.DataSourceUpdateMode.Never, null, "N2"));
			this.txtPositionDuration.Location = new System.Drawing.Point(274, 282);
			this.txtPositionDuration.Name = "txtPositionDuration";
			this.txtPositionDuration.Size = new System.Drawing.Size(197, 26);
			this.txtPositionDuration.TabIndex = 12;
			// 
			// ScientistBindingSource
			// 
			this.ScientistBindingSource.DataSource = typeof(Lab4___Malashkina_Yana.Scientist);
			// 
			// scientistBindingSource1
			// 
			this.scientistBindingSource1.DataSource = typeof(Lab4___Malashkina_Yana.Scientist);
			// 
			// frmScientist
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(525, 405);
			this.Controls.Add(this.txtPositionDuration);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtSalary);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtPosition);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtDepartament);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtFaculty);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label1);
			this.Name = "frmScientist";
			this.Text = "Науковець";
			((System.ComponentModel.ISupportInitialize)(this.ScientistBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.scientistBindingSource1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
		public System.Windows.Forms.BindingSource ScientistBindingSource;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtFaculty;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtDepartament;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtPosition;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtSalary;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtPositionDuration;
		private System.Windows.Forms.BindingSource scientistBindingSource1;
	}
}