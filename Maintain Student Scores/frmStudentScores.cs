using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

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
			Form newStudentForm = new frmNewStudent(allStudents, this);
			newStudentForm.ShowDialog();
		}

		/* Open 'Update Student Score' dialog box */
		private void btnUpdate_Click(object sender, EventArgs e)
		{
			// Get selected Student
			int index = this.lstMain.SelectedIndex;
			if (index >= 1)
			{
				tempStudent = allStudents[index] as Student;
			}
			// Pass student to dialog box
			Form updateScoresForm = new frmUpdateScores(tempStudent, this);
			updateScoresForm.ShowDialog();	
		}

		/* Update listbox when screen is activated */
		private void frmStudentScores_Activated(object sender, EventArgs e)
		{
			UpdateList();
		}

		/* Delete Button */
		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (this.lstMain.SelectedIndex != -1)
			{
				int i = this.lstMain.SelectedIndex;
				this.lstMain.Items.RemoveAt(i);
				allStudents.RemoveAt(i);
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

		/* Update List */
		public void UpdateList()
		{
			this.lstMain.Items.Clear();
			foreach (Student s in allStudents)
			{
				this.lstMain.Items.Add(s.printStudent());
			}
		}

		/* Display Total, Count and Average Scores */
		private void lstMain_SelectedIndexChanged(object sender, EventArgs e)
		{
			int i;
			i = this.lstMain.SelectedIndex;
			tempStudent = allStudents[i] as Student;

			this.txtTotal.Text = tempStudent.totalScore().ToString();
			this.txtCount.Text = tempStudent.countScores().ToString();
			this.txtAverage.Text = tempStudent.averageScore().ToString();
		}
	}
}
