using System;
using System.Collections;
using System.Collections.Generic;

namespace Maintain_Student_Scores
{
	public class Student
	{
		/* Variables */
		private String Name;
		private List<int> Scores;

		///* Default Constructor */
		public Student()
		{
			Name = null;
			Scores = null;
		}

		/* Overloaded Constructor */
		public Student(string name, List<int> scores)
		{
			this.Name = name;
			this.Scores = scores;
		}

		/* Setters and Getters */
		public String getName()
		{
			return this.Name;
		}

		public void setName(string Name)
		{
			this.Name = Name;
		}

		public List<int> getScores()
		{
			return this.Scores;
		}

		public void setScores(List<int> Scores)
		{
			this.Scores = Scores;
		}

		/* ---- Helper Methods ---- */

		/* Student.ToString */
		public String displayStudent()
		{
			String strStudent = null;
			String strName = getName();
			String strScore = null;

			foreach (int i in Scores)
			{
				strScore += ", " + i;
			}

			strStudent = strName + " - " + strScore.Remove(0, 2);
			return strStudent;
		}

		/* Total Score */
		public int getTotal()
		{
			int total = 0;
			foreach(int i in Scores)
			{
				total += i;
			}
			return total;
		}

		/* Count Score */
		public int getCount()
		{
			return Scores.ToArray().Length;
		}

		/* Average Score */
		public double getAverage()
		{
			int tempTotal;
			int tempCount;
			tempTotal = getTotal();
			tempCount = getCount();
			if (tempCount != 0)
			{
				return (tempTotal / tempCount);
			}
			else
			{
				return 0;
			}
		}
	}
}