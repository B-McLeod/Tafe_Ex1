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
	public partial class frmStudentScores : Form
	{
		private List<Student> allStudents;

		/* Default Initializer */
		public frmStudentScores()
		{
			InitializeComponent();
			allStudents = new List<Student>();
		}
				
		/* Open 'New Student' dialog box */
		private void btnAddNew_Click(object sender, EventArgs e)
		{
			Form formNewStudent = new frmNewStudent(allStudents);
			formNewStudent.ShowDialog();
		}

		/* Open 'Update Student Score' dialog box */
		private void btnUpdate_Click(object sender, EventArgs e)
		{
			Form formUpdateScores = new frmUpdateScores();
			formUpdateScores.ShowDialog();
		}

		/* Close the application */
		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		/* Update listbox when screen is activated */
		private void frmStudentScores_Activated(object sender, EventArgs e)
		{
			allStudents = testStudentList();
			this.lstMain.Items.Clear();
			foreach (Student s in allStudents)
			{
				this.lstMain.Items.Add(s.printStudent());
			}
		}

		/* Test Data */
		private List<Student> testStudentList()
		{
			List<Student> studentList = new List<Student>();

			// Student - Robin Williams (Rest in peace)
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
			List<int> student3scores = new List<int> { 87, 96, 98 };
			student3.setScores(student3scores);
			studentList.Add(student3);
			
			return studentList;
		}

		private void lstMain_SelectedIndexChanged(object sender, EventArgs e)
		{
			// WORKING ON GETTING THE TOTAL, COUNT AND AVERAGE VALUES TO DISPLAY WHEN SELECTED LIST ITEM HAS CHANGED.
		}




	}
}
