﻿namespace Lab4___Malashkina_Yana
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
			// frmScientists
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(991, 376);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.grdScientists);
			this.Name = "frmScientists";
			this.Text = "Кадри науковців (Зарплата)";
			((System.ComponentModel.ISupportInitialize)(this.grdScientists)).EndInit();
			this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.DataGridView grdScientists;
        private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnDelete;
	}
}
