namespace Lab4___Malashkina_Yana
{
	partial class frmScientists
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
			this.grdScientists = new System.Windows.Forms.DataGridView();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnSearch = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtbSurname = new System.Windows.Forms.TextBox();
			this.txtbFaculty = new System.Windows.Forms.TextBox();
			this.txtbKafedra = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.grdScientists)).BeginInit();
			this.SuspendLayout();
			// 
			// grdScientists
			// 
			this.grdScientists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdScientists.Location = new System.Drawing.Point(12, 12);
			this.grdScientists.Name = "grdScientists";
			this.grdScientists.RowHeadersWidth = 62;
			this.grdScientists.RowTemplate.Height = 28;
			this.grdScientists.Size = new System.Drawing.Size(967, 313);
			this.grdScientists.TabIndex = 0;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(12, 331);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(113, 38);
			this.btnAdd.TabIndex = 1;
			this.btnAdd.Text = "Додати";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.Location = new System.Drawing.Point(131, 331);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(125, 38);
			this.btnEdit.TabIndex = 2;
			this.btnEdit.Text = "Редактувати";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(262, 331);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(120, 38);
			this.btnDelete.TabIndex = 3;
			this.btnDelete.Text = "Видалити";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(12, 507);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(113, 38);
			this.btnSearch.TabIndex = 4;
			this.btnSearch.Text = "Пошук ";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(25, 397);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(81, 20);
			this.label1.TabIndex = 5;
			this.label1.Text = "Прізвище";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 435);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(94, 20);
			this.label2.TabIndex = 6;
			this.label2.Text = "Факультет";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(25, 469);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(81, 20);
			this.label3.TabIndex = 7;
			this.label3.Text = "Кафедра";
			// 
			// txtbSurname
			// 
			this.txtbSurname.Location = new System.Drawing.Point(131, 394);
			this.txtbSurname.Name = "txtbSurname";
			this.txtbSurname.Size = new System.Drawing.Size(188, 26);
			this.txtbSurname.TabIndex = 8;
			// 
			// txtbFaculty
			// 
			this.txtbFaculty.Location = new System.Drawing.Point(131, 432);
			this.txtbFaculty.Name = "txtbFaculty";
			this.txtbFaculty.Size = new System.Drawing.Size(188, 26);
			this.txtbFaculty.TabIndex = 9;
			// 
			// txtbKafedra
			// 
			this.txtbKafedra.Location = new System.Drawing.Point(131, 469);
			this.txtbKafedra.Name = "txtbKafedra";
			this.txtbKafedra.Size = new System.Drawing.Size(188, 26);
			this.txtbKafedra.TabIndex = 10;
			// 
			// frmScientists
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(991, 567);
			this.Controls.Add(this.txtbKafedra);
			this.Controls.Add(this.txtbFaculty);
			this.Controls.Add(this.txtbSurname);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.grdScientists);
			this.Name = "frmScientists";
			this.Text = "Кадри науковців (Зарплата)";
			((System.ComponentModel.ISupportInitialize)(this.grdScientists)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.DataGridView grdScientists;
        private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtbSurname;
		private System.Windows.Forms.TextBox txtbFaculty;
		private System.Windows.Forms.TextBox txtbKafedra;
	}
}

