namespace Maintain_Student_Scores
{
	partial class frmUpdateScore
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtUpdateScore = new System.Windows.Forms.TextBox();
			this.lblScore = new System.Windows.Forms.Label();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtUpdateScore
			// 
			this.txtUpdateScore.Location = new System.Drawing.Point(75, 15);
			this.txtUpdateScore.Name = "txtUpdateScore";
			this.txtUpdateScore.Size = new System.Drawing.Size(100, 20);
			this.txtUpdateScore.TabIndex = 7;
			// 
			// lblScore
			// 
			this.lblScore.AutoSize = true;
			this.lblScore.Location = new System.Drawing.Point(30, 18);
			this.lblScore.Name = "lblScore";
			this.lblScore.Size = new System.Drawing.Size(38, 13);
			this.lblScore.TabIndex = 6;
			this.lblScore.Text = "Score:";
			this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(108, 50);
			this.btnCancel.Margin = new System.Windows.Forms.Padding(5);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 5;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(23, 50);
			this.btnUpdate.Margin = new System.Windows.Forms.Padding(5);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(75, 23);
			this.btnUpdate.TabIndex = 4;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			// 
			// frmUpdateScore
			// 
			this.AcceptButton = this.btnUpdate;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(209, 87);
			this.Controls.Add(this.txtUpdateScore);
			this.Controls.Add(this.lblScore);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnUpdate);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmUpdateScore";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Update Score";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtUpdateScore;
		private System.Windows.Forms.Label lblScore;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnUpdate;
	}
}