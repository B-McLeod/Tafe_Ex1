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
		}

		/* Overloaded Initializer */
		private void frmStudentScores(object sender, EventArgs e)
		{
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
			lstMain.Items.Clear();
			foreach (Student s in allStudents)
			{
				lstMain.Items.Add(s);
			}
		}

		///* Helpers */
		//private ArrayList popDefaultList();
		//{
		//	ArrayList studentList = new ArrayList();
		//	Student default1 = new Student();
		//	Student default2 = new Student();
		//	Student default3 = new Student();
		//	ArrayList tempScores = new ArrayList { 97, 71, 83 };

		//	default1.setName("Blake McLeod");
		//	default1.setAllScores(tempScores);

		//	default2.setName("James Bond");
		//	tempScores = new ArrayList { 0, 0, 7 };
		//	default2.setAllScores(tempScores);

		//	default3.setName("Robin Williams");
		//	tempScores = new ArrayList { 100, 100, 100 };
		//	default3.setAllScores(tempScores);

		//	studentList.Add(default1);
		//	studentList.Add(default2);
		//	studentList.Add(default3);

		//	return studentList;
		//}
	}
}
