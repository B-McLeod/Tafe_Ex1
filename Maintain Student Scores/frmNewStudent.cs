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
	public partial class 
		frmNewStudent : Form
	{
		List<Student> newStudentList;
		List<int> newScores = new List<int>();

		public frmNewStudent()
		{
			InitializeComponent();
		}

		public frmNewStudent(List<Student> mainStudentList)
		{
			newStudentList = mainStudentList;
			InitializeComponent();
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			if (newScores.Count >= 1)
			{
				String newName = txtName.Text;
				/* Sort out multiple Student list only 1 instance created */
				Student person = new Student(newName, newScores);
				this.Close();
			}
			else
			{
				MessageBox.Show("No scores have been entered for this student", "Enter score");
			}
		}

		private void btnAddScore_Click(object sender, EventArgs e)
		{
			try
			{
				int score = Convert.ToInt32(txtScore.Text);

				if (score >= 0 && score <= 100)
				{
					newScores.Add(score);
					txtScore.Clear();
					txtScore.Focus();
				}
				else
				{
					MessageBox.Show("Please enter a score between 0 and 100.", "Invalid score");
				}
			}
			catch (FormatException)
			{
				MessageBox.Show("Please enter a valid number", "Invalid Entry");
			}

			String printList = null;
			foreach (Int32 x in newScores)
			{
				printList += x.ToString() + ", ";
			}

			txtScores.Text = printList;
		}

		private void btnClearScores_Click(object sender, EventArgs e)
		{
			newScores.Clear();
			txtScores.Text = null;
		}
	}
}
