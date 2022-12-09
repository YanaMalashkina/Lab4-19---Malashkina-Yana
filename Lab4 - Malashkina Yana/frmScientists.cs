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
	public partial class frmScientists : Form
	{
		private BindingList<Scientist> list = new BindingList<Scientist>();

		public frmScientists()
		{
			InitializeComponent();
			LoadData();
		}

		private void LoadData()
		{
			grdScientists.AutoGenerateColumns = true;
			grdScientists.DataSource = list;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			Scientist scientist = ShowForm(new Scientist());
			list.Add(scientist);
			LoadData();
		}

		private Scientist ShowForm(Scientist person)
		{
			Scientist scientist = new Scientist();
			var form = new frmScientist();
			form.Scientist = person;
			form.ShowDialog();
			if (form.DialogResult == DialogResult.OK)
			{
				scientist = form.Scientist;
			}
			return scientist;
		}
		public Scientist CurrentScientist { get; set; }
		public int CurrentScientistIndex { get; set; }

		private void btnEdit_Click(object sender, EventArgs e)
		{
			CurrentScientist = (Scientist)grdScientists.CurrentRow.DataBoundItem;
			CurrentScientistIndex = list.IndexOf(CurrentScientist);
			Scientist editedscientist = ShowForm(CurrentScientist);
			list[CurrentScientistIndex] = editedscientist;
			LoadData();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			CurrentScientist = (Scientist)grdScientists.CurrentRow.DataBoundItem;
			list.Remove(CurrentScientist);
			LoadData();
		}
	}
}
