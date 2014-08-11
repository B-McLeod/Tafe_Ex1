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
		List<Student> studentList;

		public frmStudentScores()
		{
			InitializeComponent();
			studentList = new List<Student>();
		}
		
		/* Close the application */
		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		/* Open 'New Student' dialog box */
		private void btnAddNew_Click(object sender, EventArgs e)
		{
			Form formNewStudent = new frmNewStudent(studentList);
			formNewStudent.ShowDialog();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			Form formUpdateScores = new frmUpdateScores();
			formUpdateScores.ShowDialog();
		}
	}
}
