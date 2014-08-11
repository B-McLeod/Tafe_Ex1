using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maintain_Student_Scores
{
	public class Student
	{
		public String Name { get; set; }
		public List<int> Scores { get; set; }

		public Student(String name, List<int> scores)
		{
			Name = name;
			Scores = scores;
		}

	}
}
