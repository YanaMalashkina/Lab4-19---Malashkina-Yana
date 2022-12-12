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
	    Scientists scientists;

		public frmScientists()
		{
			InitializeComponent();
			scientists = new Scientists();	
			LoadData();
		}

		private void LoadData()
		{
			scientists.OpenFromFile();
			BindGrid(scientists.List);
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			Scientist scientist = ShowForm(new Scientist());
			scientists.List.Add(scientist);
			scientists.SaveToFile();
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
			CurrentScientistIndex = scientists.List.IndexOf(CurrentScientist);
			Scientist editedscientist = ShowForm(CurrentScientist);
			scientists.List[CurrentScientistIndex] = editedscientist;
			scientists.SaveToFile();
			LoadData();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			CurrentScientist = (Scientist)grdScientists.CurrentRow.DataBoundItem;
			scientists.List.Remove(CurrentScientist);
			scientists.SaveToFile();
			LoadData();
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			List<Scientist> filteredItems = Helper.Filter(scientists.List, txtbSurname.Text, txtbFaculty.Text, txtbKafedra.Text);
			BindGrid(filteredItems);
		}

		private void BindGrid(List<Scientist> list)
		{
			grdScientists.AutoGenerateColumns = true;
			grdScientists.DataSource = list;
		}

		private void btnInfo_Click(object sender, EventArgs e)
		{
			frmAbout frmAbout = new frmAbout();
			frmAbout.ShowDialog();
		}
	}
}
