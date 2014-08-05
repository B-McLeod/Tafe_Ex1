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
	public partial class frmNewStudent : Form
	{
		List<Student> newStudentList;
		List<int> newScores;

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
			String newName = txtName.Text;
			Student person = new Student(newName, newScores);
		}

		private void btnAddScore_Click(object sender, EventArgs e)
		{
			int score = Convert.ToInt32(txtScore.Text);
			newScores.Add(score);

			txtScores.Text = "Bum";
		}

		public static string Concatenate<T>(this IEnumerable<T> source, string delimiter)
		{
			var s = new StringBuilder();
			bool first = true;
			foreach (T t in source)
			{
				if (first)
				{
					first = false;
				}
				else
				{
					s.Append(delimiter);
				}
				s.Append(t);
			}
			return s.ToString();
		}
	}
}
