#nullable disable

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1
{
	public partial class Form2 : Form
	{
		readonly string path;
		string title;

		public Form2(string path)
		{
			InitializeComponent();
			this.path = path;
			StreamReader sr;
			title = path.Substring(path.LastIndexOf('/') + 1);
			using (sr = new StreamReader(path))
			{
				txbTxt.Text = sr.ReadToEnd();
			}
			Text = title;
		}

		private void TxbTxt_TextChanged(object sender, EventArgs e)
		{
			Text = title + "*";
		}

		private void Form2_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (Text.EndsWith('*'))
			{
				if (MessageBox.Show("¿Desea guardar los cambios realizados?", "Guardar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
				{
					StreamWriter sw;
					using (sw = new StreamWriter(path))
					{
						sw.Write(txbTxt.Text);
					}
				} else
				{
					Text= title;
				}
			}
		}
	}
}
