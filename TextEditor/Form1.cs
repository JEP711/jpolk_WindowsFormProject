using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			openFileDialog1.ShowDialog();
		}

		private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			saveFileDialog1.ShowDialog();
		}

		private void fontToolStripMenuItem_Click(object sender, EventArgs e)
		{
			fontDialog1.ShowDialog();
		}

		private void fontColorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			colorDialog1.ShowDialog();
		}
	}
}
