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
		
		public Student getStudent()
		{
			return this;
		}

		/* ---- Helper Methods ---- */

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

		/* Student.ToString */
		public String printStudent()
		{
			String strStudent = null;
			String x = getName();
			String y = null;

			foreach (int i in Scores)
			{
				y += ", " + i;
			}

			strStudent = x + " - " + y.Remove(0, 2);
			return strStudent;
		}

		/* -- Score Methods -- */

		/* Total Score */
		private int totalScore(List<int> lstScr)
		{
			int total = 0;

			foreach(int i in lstScr)
			{
				total += i;
			}

			return total;
		}

		/* Count Score */

		/* Average Score */
	}
}