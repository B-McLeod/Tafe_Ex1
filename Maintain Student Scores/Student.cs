using System;
using System.Collections;
using System.Collections.Generic;

namespace Maintain_Student_Scores
{
	public class Student
	{
		/* Variables */
		private String Name { get; set; }
		private ArrayList Scores;

		/* Default Constructor */
		public Student()
		{
			Name = null;
			Scores = null;
		}

		/* Overloaded Constructor */
		public Student(string name, ArrayList scores)
		{
			this.Name = name;
			this.Scores = scores;
		}

		
		/* Methods */

		public ArrayList getScores()
		{
			return this.Scores;
		}

		public int scoreTotal()
		{
			int temp = 0;
			foreach (int i in Scores)
			{
				temp += i;
			}
			return temp;
		}

		public int scoreCount()
		{
			return Scores.ToArray().Length;
		}

		public double scoreAverage()
		{
			int tempTotal;
			int tempCount;
			tempTotal = scoreTotal();
			tempCount = scoreTotal();
			return (tempTotal / tempCount);
		}

		public void setAllScores(ArrayList s)
		{
			this.Scores = s;
		}

		public void setScore(int i, int score)
		{
			this.Scores.RemoveAt(i);
			this.Scores.Insert(i, score);
		}

		public void addScore(int score)
		{
			this.Scores.Add(score);
		}

		public Student getStudent()
		{
			return this;
		}

		/* ---- Helper Methods ---- */

		/* List To String */
		public String printList(List<int> lst)
		{
			String strList = null;
			foreach (int var in lst)
			{
				strList += var + ", ";
			}
			strList = strList.Remove(strList.Length - 2);
			return strList;			
		}


	}
}