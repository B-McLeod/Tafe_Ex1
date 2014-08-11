namespace Maintain_Student_Scores
{
	partial class frmNewStudent
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
			this.lblName = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.lblScore = new System.Windows.Forms.Label();
			this.txtScore = new System.Windows.Forms.TextBox();
			this.txtScores = new System.Windows.Forms.TextBox();
			this.lblScores = new System.Windows.Forms.Label();
			this.btnAddScore = new System.Windows.Forms.Button();
			this.btnClearScores = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(12, 19);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(38, 13);
			this.lblName.TabIndex = 0;
			this.lblName.Text = "Name:";
			this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(56, 16);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(195, 20);
			this.txtName.TabIndex = 1;
			// 
			// lblScore
			// 
			this.lblScore.AutoSize = true;
			this.lblScore.Location = new System.Drawing.Point(12, 45);
			this.lblScore.Name = "lblScore";
			this.lblScore.Size = new System.Drawing.Size(38, 13);
			this.lblScore.TabIndex = 0;
			this.lblScore.Text = "Score:";
			this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtScore
			// 
			this.txtScore.Location = new System.Drawing.Point(56, 42);
			this.txtScore.Name = "txtScore";
			this.txtScore.Size = new System.Drawing.Size(114, 20);
			this.txtScore.TabIndex = 2;
			// 
			// txtScores
			// 
			this.txtScores.Location = new System.Drawing.Point(56, 68);
			this.txtScores.Name = "txtScores";
			this.txtScores.ReadOnly = true;
			this.txtScores.Size = new System.Drawing.Size(195, 20);
			this.txtScores.TabIndex = 0;
			this.txtScores.TabStop = false;
			// 
			// lblScores
			// 
			this.lblScores.AutoSize = true;
			this.lblScores.Location = new System.Drawing.Point(7, 71);
			this.lblScores.Name = "lblScores";
			this.lblScores.Size = new System.Drawing.Size(43, 13);
			this.lblScores.TabIndex = 3;
			this.lblScores.Text = "Scores:";
			this.lblScores.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnAddScore
			// 
			this.btnAddScore.Location = new System.Drawing.Point(176, 40);
			this.btnAddScore.Name = "btnAddScore";
			this.btnAddScore.Size = new System.Drawing.Size(75, 23);
			this.btnAddScore.TabIndex = 3;
			this.btnAddScore.Text = "Add Score";
			this.btnAddScore.UseVisualStyleBackColor = true;
			this.btnAddScore.Click += new System.EventHandler(this.btnAddScore_Click);
			// 
			// btnClearScores
			// 
			this.btnClearScores.Location = new System.Drawing.Point(176, 94);
			this.btnClearScores.Name = "btnClearScores";
			this.btnClearScores.Size = new System.Drawing.Size(75, 23);
			this.btnClearScores.TabIndex = 4;
			this.btnClearScores.Text = "Clear Scores";
			this.btnClearScores.UseVisualStyleBackColor = true;
			this.btnClearScores.Click += new System.EventHandler(this.btnClearScores_Click);
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(95, 137);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 5;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(176, 137);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 6;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// frmNewStudent
			// 
			this.AcceptButton = this.btnAddScore;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(270, 178);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.btnClearScores);
			this.Controls.Add(this.btnAddScore);
			this.Controls.Add(this.lblScores);
			this.Controls.Add(this.txtScores);
			this.Controls.Add(this.txtScore);
			this.Controls.Add(this.lblScore);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.lblName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmNewStudent";
			this.ShowIcon = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Add New Student";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label lblScore;
		private System.Windows.Forms.TextBox txtScore;
		private System.Windows.Forms.TextBox txtScores;
		private System.Windows.Forms.Label lblScores;
		private System.Windows.Forms.Button btnAddScore;
		private System.Windows.Forms.Button btnClearScores;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;
	}
}