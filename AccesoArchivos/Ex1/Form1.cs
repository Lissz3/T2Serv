#nullable disable

namespace Ex1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void BtnIn_Click(object sender, EventArgs e)
		{
			if (txbPath.Text.Trim() != "")
			{
				string path = txbPath.Text.Trim();
				lblDir.Text = "Directorio actual: " + (txbPath.Text.StartsWith('%') && txbPath.Text.EndsWith('%') ? "C:" + Environment.GetEnvironmentVariable(txbPath.Text.Trim('%')) : txbPath.Text);
				DirectoryInfo dir = new(path);
				DirectoryInfo[] subdir = dir.GetDirectories();
				//DirectoryNotFoundException
				AddToListBox(lbSubDir, subdir);
				FileInfo[] files = dir.GetFiles();
				AddToListBox(lbFiles, files);

			}
		}

		private void TxbPath_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				btnIn.PerformClick();
			}
		}

		private void AddToListBox(ListBox lb, Object[] obj)
		{
			if (lb.Tag.ToString() == "Sub")
			{
				lbSubDir.Items.Add("..");
				foreach (DirectoryInfo d in obj)
				{
					lbSubDir.Items.Add(d.Name);
				}
			} else
			{
				foreach (FileInfo f in obj)
				{
					lbFiles.Items.Add(f.Name);
				}
			}
		}
	}
}