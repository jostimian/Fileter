using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fileter
{
	public partial class Form1 : Form
	{
		string fileExtention;
		string rootDir;
		string toDir;
		public Form1()
		{
			InitializeComponent();
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			Console.Beep(100,100);
			progBar.Value = 0;
		}

		private void chooseLastDir_Click(object sender, EventArgs e)
		{
			using (FolderBrowserDialog folderBrowser = new FolderBrowserDialog())
			{
				DialogResult result = folderBrowser.ShowDialog();
				if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowser.SelectedPath))
				{
					toDir = folderBrowser.SelectedPath;
					toFolderDir.Text = toDir;
				}
			}
		}

		private void chooseParentDir_Click(object sender, EventArgs e)
		{
			using (FolderBrowserDialog folderBrowser = new FolderBrowserDialog())
			{
				DialogResult result = folderBrowser.ShowDialog();
				if(result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowser.SelectedPath))
				{
					rootDir = folderBrowser.SelectedPath;
					parentDir.Text = rootDir;
				}
			}
		}

		private void transferFile(string folderPath, string fileExt, string toDir)
		{
			string[] files = Directory.GetFiles(rootDir,fileExt ,SearchOption.AllDirectories);
			int filesLen = files.Length;
			int numOfTransferedFile = 0;
			foreach (string file in files)
			{
				numOfTransferedFile++;
				string fileName = Path.GetFileName(file);
				File.Move(file, toDir + "\\" + fileName);
				progBar.Value = numOfTransferedFile / filesLen * 100;
			}
		}

		private void submit_Click(object sender, EventArgs e)
		{
			fileExtention = "*" + fileExtentionBar.Text + "*";
			rootDir = parentDir.Text;
			toDir = toFolderDir.Text;
			if (string.IsNullOrWhiteSpace(rootDir))
			{
				MessageBox.Show("Please add or specify the origin folder","Fileter");
			}
			if (string.IsNullOrWhiteSpace(toDir))
			{
				MessageBox.Show("Please add or specify the folder where we will transfer the files", "Fileter Status");
			}
			transferFile(rootDir, fileExtention, toDir);
			MessageBox.Show("Done Filetering","Fileter Status");
			progBar.Value = 0;
		}
	}
}
