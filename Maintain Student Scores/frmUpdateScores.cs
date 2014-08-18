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
		/* Variables */
		private frmStudentScores mainForm;
		//private List<Student> studentList;
		private Student tempStudent;

		/* Default Initializer */
		public frmUpdateScores()
		{
			InitializeComponent();
		}

		/* Overloaded Initializer */
		public frmUpdateScores(Student temp, frmStudentScores callingForm)
		{
			this.tempStudent = temp;
			mainForm = callingForm;
			InitializeComponent();

			// Populate text box and list
			txtName.Text = tempStudent.getName();
			foreach (int score in tempStudent.getScores())
			{
				this.lstScores.Items.Add(score);
			}
		}

		/* Set student to update */
		public void setStudent(Student selectedStudent)
		{
			this.tempStudent = selectedStudent;
		}

		/* Add Button */
		private void btnAdd_Click(object sender, EventArgs e)
		{
			Form formAddScore = new frmAddScore();
			formAddScore.ShowDialog();
		}

		/* Update Button */
		private void btnUpdate_Click(object sender, EventArgs e)
		{
			int i = this.lstScores.SelectedIndex;
			if (i != -1)
			{
				Form formUpdateScore = new frmUpdateScore();
				formUpdateScore.ShowDialog();
			}			
		}

		/* OK Button */
		private void btnOK_Click(object sender, EventArgs e)
		{
			if (tempStudent.getScores().Count > 0)
			{
				Student newStudent = new Student(txtName.Text, tempStudent.getScores());
				//studentList.Add(newStudent);
				mainForm.Update();
				this.Close();
			}
			else
			{
				MessageBox.Show("No scores have been entered for this student", "Enter score");
			}
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			tempStudent.getScores().Clear();
			lstScores.Items.Clear();
		}
	}
}
