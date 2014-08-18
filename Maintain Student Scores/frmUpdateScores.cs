using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Maintain_Student_Scores
{
	public partial class frmUpdateScores : Form
	{
		/* Variables */
		private Student tempStudent;
		private List<int> originalList;

		/* Overloaded Initializer */
		public frmUpdateScores(Student inStudent)
		{
			this.tempStudent = inStudent; // Set Student
			originalList = tempStudent.getScores(); // Save original imported list
			InitializeComponent();

			// Populate name textbox and score list
			txtName.Text = tempStudent.getName();
			foreach (int score in tempStudent.getScores())
			{
				this.lstScores.Items.Add(score);
			}
		}

		/* Cancel Button */
		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.lstScores.Items.Clear(); // Clear list

			// Set student scores back to original list
			tempStudent.setScores(originalList);
		}

		/* Add Button */
		private void btnAdd_Click(object sender, EventArgs e)
		{
			Form formAddScore = new frmAddScore(tempStudent.getScores());
			formAddScore.ShowDialog();
		}

		/* Update Button */
		private void btnUpdate_Click(object sender, EventArgs e)
		{
			int index = this.lstScores.SelectedIndex;
			if (index != -1)
			{
				Form formUpdateScore = new frmUpdateScore(tempStudent.getScores(), index);
				formUpdateScore.ShowDialog();
			}
		}

		/* OK Button */
		private void btnOK_Click(object sender, EventArgs e)
		{
			if (tempStudent.getScores().Count > 0)
			{
				this.Close();
			}
			else
			{
				MessageBox.Show("No scores have been entered for this student", "Enter score");
			}
		}

		/* Clear Scores Button */
		private void btnClear_Click(object sender, EventArgs e)
		{
			tempStudent.getScores().Clear();
			lstScores.Items.Clear();
		}

		/* Update list when window activated */
		private void frmUpdateScores_Activated(object sender, EventArgs e)
		{
			this.lstScores.Items.Clear();
			foreach (int x in tempStudent.getScores())
			{
				this.lstScores.Items.Add(x);
			}
		}

		/* Remove Button */
		private void btnRemove_Click(object sender, EventArgs e)
		{
			if (this.lstScores.SelectedIndex != -1)
			{
				int i = this.lstScores.SelectedIndex;	// Get selected index
				this.lstScores.Items.RemoveAt(i);		// Remove from listbox
				tempStudent.getScores().RemoveAt(i);	// Remove from student scorelist
			}
		}
	}
}