using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Maintain_Student_Scores
{
	public partial class frmAddScore : Form
	{
		/* Variables */
		private int addScore;
		private List<int> scoreList;

		/* Default Initializer */

		public frmAddScore()
		{
			InitializeComponent();
			txtScoreAdd.Focus();
		}

		/* Overloaded Initializer
		 * Import: Score List(List<int>) */

		public frmAddScore(List<int> inList)
		{
			scoreList = inList;
			InitializeComponent();
			txtScoreAdd.Focus();
		}

		/* Cancel */

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		/* Add Button */

		private void btnAdd_Click(object sender, EventArgs e)
		{
			try
			{
				addScore = Convert.ToInt32(txtScoreAdd.Text);
				if (addScore >= 0 && addScore <= 100)
				{
					scoreList.Add(addScore);
					this.Close();
				}
				else
				{
					MessageBox.Show("Enter a number between 0 and 100.", "Error");
				}
			}
			catch (FormatException)
			{
				MessageBox.Show("Enter a valid number!", "Error");
			}
		}
	}
}