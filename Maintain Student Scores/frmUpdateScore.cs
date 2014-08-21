using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Maintain_Student_Scores
{
	public partial class frmUpdateScore : Form
	{
		/* Temporary Variables */
		private int tempIndex;		// Score index
		private int tempScore;		// Score value
		private List<int> tempList;	// Score list

		/* Overloaded Initializer
			* Import: Score list(List<int>) and Selected index(int)
			*
			* Get score from inList @ inIndex and
			* display it in the text box */

		public frmUpdateScore(List<int> inList, int inIndex)
		{
			InitializeComponent();
			tempIndex = inIndex;			// Set index
			tempList = inList;				// Set list
			tempScore = inList[inIndex];	// Set score value
			txtUpdateScore.Text = tempScore.ToString(); // Display original score value
			txtUpdateScore.Focus();
		}

		/* Cancel Button */

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		/* Update Button */

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			try
			{
				// Set tempScore to the new value
				tempScore = Convert.ToInt32(txtUpdateScore.Text);

				// If tempScore between 0 - 100
				if (tempScore >= 0 && tempScore <= 100)
				{
					tempList.RemoveAt(tempIndex); // Remove score at index specified
					tempList.Insert(tempIndex, tempScore); // Insert new score at index specified
					this.Close();
				}
			}
			catch (FormatException)
			{
				MessageBox.Show("Enter a valid number.", "Error");
			}
		}
	}
}