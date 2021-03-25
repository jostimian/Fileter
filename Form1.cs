using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
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
			MessageBox.Show(string.Join("",files));
			foreach (string file in files)
			{
				string fileName = Path.GetFileName(file);
				File.Move(file, toDir + "\\" + fileName);
			}
		}

		private void submit_Click(object sender, EventArgs e)
		{
			fileExtention = "*" + fileExtentionBar.Text + "*";
			rootDir = parentDir.Text;
			toDir = toFolderDir.Text;
			transferFile(rootDir, fileExtention, toDir);
			MessageBox.Show("Done Filetering");
		}
	}
}
