
namespace Fileter
{
	partial class Form1
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
			this.Main = new System.Windows.Forms.TabControl();
			this.FilterPage = new System.Windows.Forms.TabPage();
			this.chooseParentDir = new System.Windows.Forms.Button();
			this.chooseLastDir = new System.Windows.Forms.Button();
			this.submit = new System.Windows.Forms.Button();
			this.parentDir = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.toFolderDir = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.fileExtentionBar = new System.Windows.Forms.TextBox();
			this.About = new System.Windows.Forms.TabPage();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.Title = new System.Windows.Forms.Label();
			this.Main.SuspendLayout();
			this.FilterPage.SuspendLayout();
			this.About.SuspendLayout();
			this.SuspendLayout();
			// 
			// Main
			// 
			this.Main.Controls.Add(this.FilterPage);
			this.Main.Controls.Add(this.About);
			this.Main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Main.Location = new System.Drawing.Point(0, 0);
			this.Main.Name = "Main";
			this.Main.SelectedIndex = 0;
			this.Main.Size = new System.Drawing.Size(404, 145);
			this.Main.TabIndex = 0;
			// 
			// FilterPage
			// 
			this.FilterPage.Controls.Add(this.chooseParentDir);
			this.FilterPage.Controls.Add(this.chooseLastDir);
			this.FilterPage.Controls.Add(this.submit);
			this.FilterPage.Controls.Add(this.parentDir);
			this.FilterPage.Controls.Add(this.label3);
			this.FilterPage.Controls.Add(this.label2);
			this.FilterPage.Controls.Add(this.toFolderDir);
			this.FilterPage.Controls.Add(this.label1);
			this.FilterPage.Controls.Add(this.fileExtentionBar);
			this.FilterPage.Location = new System.Drawing.Point(4, 22);
			this.FilterPage.Name = "FilterPage";
			this.FilterPage.Padding = new System.Windows.Forms.Padding(3);
			this.FilterPage.Size = new System.Drawing.Size(396, 119);
			this.FilterPage.TabIndex = 1;
			this.FilterPage.Text = "Home";
			// 
			// chooseParentDir
			// 
			this.chooseParentDir.Location = new System.Drawing.Point(327, 34);
			this.chooseParentDir.Name = "chooseParentDir";
			this.chooseParentDir.Size = new System.Drawing.Size(56, 22);
			this.chooseParentDir.TabIndex = 8;
			this.chooseParentDir.Text = "Choose";
			this.chooseParentDir.UseVisualStyleBackColor = true;
			this.chooseParentDir.Click += new System.EventHandler(this.chooseParentDir_Click);
			// 
			// chooseLastDir
			// 
			this.chooseLastDir.Location = new System.Drawing.Point(120, 80);
			this.chooseLastDir.Name = "chooseLastDir";
			this.chooseLastDir.Size = new System.Drawing.Size(56, 25);
			this.chooseLastDir.TabIndex = 7;
			this.chooseLastDir.Text = "Choose";
			this.chooseLastDir.UseVisualStyleBackColor = true;
			this.chooseLastDir.Click += new System.EventHandler(this.chooseLastDir_Click);
			// 
			// submit
			// 
			this.submit.Location = new System.Drawing.Point(206, 80);
			this.submit.Name = "submit";
			this.submit.Size = new System.Drawing.Size(177, 25);
			this.submit.TabIndex = 6;
			this.submit.Text = "Fileter";
			this.submit.UseVisualStyleBackColor = true;
			this.submit.Click += new System.EventHandler(this.submit_Click);
			// 
			// parentDir
			// 
			this.parentDir.Location = new System.Drawing.Point(206, 34);
			this.parentDir.Name = "parentDir";
			this.parentDir.Size = new System.Drawing.Size(115, 22);
			this.parentDir.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(203, 14);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(89, 17);
			this.label3.TabIndex = 4;
			this.label3.Text = "Transfer From";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(8, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 17);
			this.label2.TabIndex = 3;
			this.label2.Text = "Transfer To";
			// 
			// toFolderDir
			// 
			this.toFolderDir.Location = new System.Drawing.Point(11, 83);
			this.toFolderDir.Name = "toFolderDir";
			this.toFolderDir.Size = new System.Drawing.Size(103, 22);
			this.toFolderDir.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(86, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "File Extension";
			// 
			// fileExtentionBar
			// 
			this.fileExtentionBar.Location = new System.Drawing.Point(11, 34);
			this.fileExtentionBar.Name = "fileExtentionBar";
			this.fileExtentionBar.Size = new System.Drawing.Size(165, 22);
			this.fileExtentionBar.TabIndex = 0;
			// 
			// About
			// 
			this.About.Controls.Add(this.label5);
			this.About.Controls.Add(this.label4);
			this.About.Controls.Add(this.Title);
			this.About.Location = new System.Drawing.Point(4, 21);
			this.About.Name = "About";
			this.About.Padding = new System.Windows.Forms.Padding(3);
			this.About.Size = new System.Drawing.Size(396, 120);
			this.About.TabIndex = 2;
			this.About.Text = "About";
			this.About.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("W95FA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(6, 92);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(35, 18);
			this.label5.TabIndex = 2;
			this.label5.Text = "V1.0";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("W95FA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(6, 23);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(200, 18);
			this.label4.TabIndex = 1;
			this.label4.Text = "Developed by Timothy Ganoza";
			// 
			// Title
			// 
			this.Title.AutoSize = true;
			this.Title.Font = new System.Drawing.Font("W95FA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Title.Location = new System.Drawing.Point(6, 3);
			this.Title.Name = "Title";
			this.Title.Size = new System.Drawing.Size(46, 18);
			this.Title.TabIndex = 0;
			this.Title.Text = "Fileter";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
			this.ClientSize = new System.Drawing.Size(404, 145);
			this.Controls.Add(this.Main);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MaximumSize = new System.Drawing.Size(420, 184);
			this.MinimumSize = new System.Drawing.Size(420, 184);
			this.Name = "Form1";
			this.Text = "Fileter";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Main.ResumeLayout(false);
			this.FilterPage.ResumeLayout(false);
			this.FilterPage.PerformLayout();
			this.About.ResumeLayout(false);
			this.About.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl Main;
		private System.Windows.Forms.TabPage FilterPage;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox toFolderDir;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox fileExtentionBar;
		private System.Windows.Forms.TextBox parentDir;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button submit;
		private System.Windows.Forms.TabPage About;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label Title;
		private System.Windows.Forms.Button chooseParentDir;
		private System.Windows.Forms.Button chooseLastDir;
	}
}

