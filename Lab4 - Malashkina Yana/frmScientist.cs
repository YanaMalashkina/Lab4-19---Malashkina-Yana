using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4___Malashkina_Yana
{
	public partial class frmScientist : Form
	{
		private Scientist _scientist;

		public frmScientist()
		{
			InitializeComponent();
		}

		public Scientist Scientist {
			get
			{
				return _scientist;
			}
			set
			{
				_scientist = value;
				BindScientist();
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			ReturnScientist();
			this.DialogResult = DialogResult.OK;
			this.Hide();
		}

		private void BindScientist()
		{
			txtName.Text = Scientist.Name;
			txtFaculty.Text = Scientist.Faculty;
			txtDepartament.Text = Scientist.Department;
			txtPosition.Text = Scientist.Position;
			txtSalary.Text = Scientist.Salary.ToString();
			txtPositionDuration.Text = Scientist.PositionDuration.ToString();
		}

		private void ReturnScientist()
		{
			Scientist.Name = txtName.Text;
			Scientist.Faculty = txtFaculty.Text;
			Scientist.Department = txtDepartament.Text;
			Scientist.Position = txtPosition.Text;

			Decimal salary;
			Decimal.TryParse(txtSalary.Text, out salary);
			Scientist.Salary = salary;

			Decimal positionDuration;
			Decimal.TryParse(txtPositionDuration.Text, out positionDuration);	
			Scientist.PositionDuration = positionDuration;
		}
	}
}
