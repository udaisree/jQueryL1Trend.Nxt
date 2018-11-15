using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace Progress_Bar_2._0
{
	public partial class Gif : Form
	{
		public Gif()
		{
			InitializeComponent();
		}

		private void Gif_Load(object sender, EventArgs e)
		{
			pictureBox1.Visible = true;
			pictureBox1.Dock = DockStyle.Fill;
			backgroundWorker1.WorkerReportsProgress = true;
			backgroundWorker1.RunWorkerAsync();
		}
		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{
			Thread.Sleep(4000);
		}
		private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			this.Close();
		}


	}
}
