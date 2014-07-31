using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maintain_Student_Scores
{
	public partial class frmUpdateScores : Form
	{
		public frmUpdateScores()
		{
			InitializeComponent();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			Form formAddScore = new frmAddScore();
			formAddScore.ShowDialog();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			Form formUpdateScore = new frmUpdateScore();
			formUpdateScore.ShowDialog();
		}
	}
}
