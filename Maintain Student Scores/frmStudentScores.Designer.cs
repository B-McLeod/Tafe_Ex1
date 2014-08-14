namespace Maintain_Student_Scores
{
	partial class frmStudentScores
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
			this.btnExit = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnAddNew = new System.Windows.Forms.Button();
			this.lstMain = new System.Windows.Forms.ListBox();
			this.lblStudents = new System.Windows.Forms.Label();
			this.txtTotal = new System.Windows.Forms.TextBox();
			this.lblTotal = new System.Windows.Forms.Label();
			this.lblCount = new System.Windows.Forms.Label();
			this.txtCount = new System.Windows.Forms.TextBox();
			this.lblAverage = new System.Windows.Forms.Label();
			this.txtAverage = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnExit
			// 
			this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnExit.Location = new System.Drawing.Point(270, 229);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(75, 23);
			this.btnExit.TabIndex = 5;
			this.btnExit.Text = "E&xit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(270, 92);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 23);
			this.btnDelete.TabIndex = 4;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(270, 63);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(75, 23);
			this.btnUpdate.TabIndex = 3;
			this.btnUpdate.Text = "Update...";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnAddNew
			// 
			this.btnAddNew.Location = new System.Drawing.Point(270, 34);
			this.btnAddNew.Name = "btnAddNew";
			this.btnAddNew.Size = new System.Drawing.Size(75, 23);
			this.btnAddNew.TabIndex = 2;
			this.btnAddNew.Text = "Add New...";
			this.btnAddNew.UseVisualStyleBackColor = true;
			this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
			// 
			// lstMain
			// 
			this.lstMain.FormattingEnabled = true;
			this.lstMain.Location = new System.Drawing.Point(17, 34);
			this.lstMain.Name = "lstMain";
			this.lstMain.Size = new System.Drawing.Size(247, 134);
			this.lstMain.TabIndex = 1;
			// 
			// lblStudents
			// 
			this.lblStudents.AutoSize = true;
			this.lblStudents.Location = new System.Drawing.Point(12, 9);
			this.lblStudents.Name = "lblStudents";
			this.lblStudents.Size = new System.Drawing.Size(52, 13);
			this.lblStudents.TabIndex = 0;
			this.lblStudents.Text = "Students:";
			this.lblStudents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtTotal
			// 
			this.txtTotal.Location = new System.Drawing.Point(207, 180);
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.ReadOnly = true;
			this.txtTotal.Size = new System.Drawing.Size(56, 20);
			this.txtTotal.TabIndex = 0;
			this.txtTotal.TabStop = false;
			// 
			// lblTotal
			// 
			this.lblTotal.AutoSize = true;
			this.lblTotal.Location = new System.Drawing.Point(136, 183);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(65, 13);
			this.lblTotal.TabIndex = 0;
			this.lblTotal.Text = "Score Total:";
			this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblCount
			// 
			this.lblCount.AutoSize = true;
			this.lblCount.Location = new System.Drawing.Point(132, 209);
			this.lblCount.Name = "lblCount";
			this.lblCount.Size = new System.Drawing.Size(69, 13);
			this.lblCount.TabIndex = 0;
			this.lblCount.Text = "Score Count:";
			this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtCount
			// 
			this.txtCount.Location = new System.Drawing.Point(207, 206);
			this.txtCount.Name = "txtCount";
			this.txtCount.ReadOnly = true;
			this.txtCount.Size = new System.Drawing.Size(56, 20);
			this.txtCount.TabIndex = 0;
			this.txtCount.TabStop = false;
			// 
			// lblAverage
			// 
			this.lblAverage.AutoSize = true;
			this.lblAverage.Location = new System.Drawing.Point(151, 235);
			this.lblAverage.Name = "lblAverage";
			this.lblAverage.Size = new System.Drawing.Size(50, 13);
			this.lblAverage.TabIndex = 0;
			this.lblAverage.Text = "Average:";
			this.lblAverage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtAverage
			// 
			this.txtAverage.Location = new System.Drawing.Point(207, 232);
			this.txtAverage.Name = "txtAverage";
			this.txtAverage.ReadOnly = true;
			this.txtAverage.Size = new System.Drawing.Size(56, 20);
			this.txtAverage.TabIndex = 0;
			this.txtAverage.TabStop = false;
			// 
			// frmStudentScores
			// 
			this.AcceptButton = this.btnAddNew;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnExit;
			this.ClientSize = new System.Drawing.Size(359, 262);
			this.Controls.Add(this.lblAverage);
			this.Controls.Add(this.txtAverage);
			this.Controls.Add(this.lblCount);
			this.Controls.Add(this.txtCount);
			this.Controls.Add(this.lblTotal);
			this.Controls.Add(this.txtTotal);
			this.Controls.Add(this.lblStudents);
			this.Controls.Add(this.lstMain);
			this.Controls.Add(this.btnAddNew);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnExit);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "frmStudentScores";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Student Scores";
			this.Activated += new System.EventHandler(this.frmStudentScores_Activated);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnAddNew;
		private System.Windows.Forms.ListBox lstMain;
		private System.Windows.Forms.Label lblStudents;
		private System.Windows.Forms.TextBox txtTotal;
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.Label lblCount;
		private System.Windows.Forms.TextBox txtCount;
		private System.Windows.Forms.Label lblAverage;
		private System.Windows.Forms.TextBox txtAverage;
	}
}

