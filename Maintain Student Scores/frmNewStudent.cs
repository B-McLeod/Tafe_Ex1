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
		private List<Student> studentList;
		private List<int> newStudentScores = new List<int>();
			
		/* Default Initializer */
		public frmNewStudent()
		{
			InitializeComponent();
		}

		///* Overloaded Initializer */
		public frmNewStudent(List<Student> allStudents)
		{
			studentList = allStudents;
			InitializeComponent();
		}

		/* OK Button */
		private void btnOK_Click(object sender, EventArgs e)
		{
			if (newStudentScores.Count > 0)
			{
				Student newStudent = new Student(txtName.Text, newStudentScores);
				studentList.Add(newStudent);
				this.Close();
			}
			else
			{
				MessageBox.Show("No scores have been entered for this student", "Enter score");
			}
		}

		/* Add Score Button */
		private void btnAddScore_Click(object sender, EventArgs e)
		{
			try
			{
				//String input = this.txtScore.Text;
				//int value;
				//int.TryParse(input, out value);

				int value = Convert.ToInt32(txtScore.Text);

				if (validScore(value))
				{
					newStudentScores.Add(value);
					txtScores.Text = printList(newStudentScores);
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
		}

		/* Clear Scores Button */
		private void btnClearScores_Click(object sender, EventArgs e)
		{
			newStudentScores.Clear();
			txtScores.Text = null;
		}

		/* Cancel Button */
		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		/* ---- Helper Methods ---- */

		/* Score Validation Methods */
		private bool validScore(int s)
		{
			return (s >= 0 && s <= 100);
		}

		/* List.ToString */
		public String printList(List<int> list)
		{
			String strList = null;
			foreach (int s in list)
			{
				strList += s + ", ";
			}
			strList = strList.Remove(strList.Length - 2);
			return strList;
		}
	}
}
