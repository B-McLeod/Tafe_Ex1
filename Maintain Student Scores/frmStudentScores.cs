using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Maintain_Student_Scores
{
	public partial class frmStudentScores : Form
	{
		/* Variables */
		private List<Student> allStudents;
		private Student tempStudent;

		/* Default Initializer */

		public frmStudentScores()
		{
			InitializeComponent();
			allStudents = new List<Student>();
			allStudents = testStudentList();
		}

		/* Close the application */

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		/* Open 'New Student' dialog box */

		private void btnAddNew_Click(object sender, EventArgs e)
		{
			Form newStudentForm = new frmNewStudent(allStudents);
			newStudentForm.ShowDialog();
		}

		/* Open 'Update Student Score' dialog box */

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			// Get selected Student
			int index = this.lstMain.SelectedIndex;
			if (index != -1)
			{
				tempStudent = allStudents[index] as Student;

				// Pass student to dialog box
				Form updateScoresForm = new frmUpdateScores(tempStudent);
				updateScoresForm.ShowDialog();
			}
		}

		/* Update listbox when screen is activated */

		private void frmStudentScores_Activated(object sender, EventArgs e)
		{
			rebuildList();
		}

		/* Delete Button */

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (this.lstMain.SelectedIndex >= 0)
			{
				int i = this.lstMain.SelectedIndex;
				this.lstMain.Items.RemoveAt(i);
				allStudents.RemoveAt(i);
				rebuildList();
			}
		}

		/* ---- Helper Methods ---- */

		/* Test Data */

		private List<Student> testStudentList()
		{
			List<Student> studentList = new List<Student>();

			// Student - Robin Williams
			Student CaptainMyCaptain = new Student();
			CaptainMyCaptain.setName("Robin Williams");
			List<int> student1scores = new List<int> { 100, 100, 100 };
			CaptainMyCaptain.setScores(student1scores);
			studentList.Add(CaptainMyCaptain);

			// Student - James Bond
			Student student2 = new Student();
			student2.setName("James Bond");
			List<int> student2scores = new List<int> { 0, 0, 7 };
			student2.setScores(student2scores);
			studentList.Add(student2);

			// Student - Blake McLeod
			Student student3 = new Student();
			student3.setName("Blake McLeod");
			List<int> student3scores = new List<int> { 94, 96, 98 };
			student3.setScores(student3scores);
			studentList.Add(student3);

			return studentList;
		}

		/* Display Total, Count and Average Scores
		 * Clear text boxes if no selection is made */

		private void lstMain_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lstMain.SelectedIndex >= 0)
			{
				int i = this.lstMain.SelectedIndex;
				if (i >= 0)
				{
					tempStudent = allStudents[i] as Student;

					this.txtTotal.Text = tempStudent.getTotal().ToString();
					this.txtCount.Text = tempStudent.getCount().ToString();
					this.txtAverage.Text = tempStudent.getAverage().ToString();
				}
			}
			else
			{
				tempStudent = null;
				this.txtTotal.Text = "";
				this.txtCount.Text = "";
				this.txtAverage.Text = "";
			}
		}

		/* Rebuild the list */

		private void rebuildList()
		{
			this.lstMain.Items.Clear(); // Clear listbox
			foreach (Student s in allStudents) // Rebuild listbox
			{
				this.lstMain.Items.Add(s.displayStudent());
			}
			lblStudentCount.Text = "Students: " + lstMain.Items.Count.ToString();
		}
	}
}