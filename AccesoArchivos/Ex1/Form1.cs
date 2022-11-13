#nullable disable

using System.IO;
using System.Windows.Forms;

namespace Ex1
{
	public partial class Form1 : Form
	{
		DirectoryInfo[] subdir = null;
		DirectoryInfo dir = null;
		FileInfo[] files = null;
		bool changed = false;

		public Form1()
		{
			InitializeComponent();
			AcceptButton = btnIn;
		}

		private void BtnIn_Click(object sender, EventArgs e)
		{
			lblError.Text = "";
			string aux = txbPath.Text.Trim();
			if (aux != "")
			{
				if (aux.StartsWith('%') && aux.EndsWith('%'))
				{
					aux = Environment.GetEnvironmentVariable(aux.Trim('%'));
				}
				ChangeListsBoxs(aux);
			}
			else
			{
				lblError.Text = "Ruta de acceso o variable de entorno inválida.";
			}

		}

		void ChangeListsBoxs(string path)
		{
			changed = false;
			lbSubDir.Items.Clear();
			lbFiles.Items.Clear();
			try
			{
				lblDir.Text = "Directorio actual: " + path;
				dir = new(path);
				subdir = dir.GetDirectories();

				if (subdir != null)
				{
					AddToListBox(lbSubDir, subdir);
					files = dir.GetFiles();
					AddToListBox(lbFiles, files);
				}
			}
			catch (DirectoryNotFoundException)
			{
				lblError.Text = "Directorio no encontrado.";
			}
			catch (FileNotFoundException)
			{
				lblError.Text = "Archivo no encontrado.";
			}
			catch (UnauthorizedAccessException)
			{
				lblError.Text = "Permisos insuficientes.";
			}
			catch (ArgumentNullException)
			{
				lblError.Text = "Sintaxis incorrecta.";
			}
			catch (IOException)
			{
				lblError.Text = "Sintaxis incorrecta.";
			}
		}

		private void AddToListBox(ListBox lb, object[] obj)
		{
			if (lb.Tag.ToString() == "Sub")
			{
				if (dir.Parent != null)
				{
					lbSubDir.Items.Add("..");
				}
				foreach (DirectoryInfo d in obj.Cast<DirectoryInfo>())
				{
					lbSubDir.Items.Add(d.Name);
				}
			}
			else
			{
				foreach (FileInfo f in obj.Cast<FileInfo>())
				{
					lbFiles.Items.Add(f.Name);
				}
			}
		}

		void ChangeDirs()
		{
			if (dir != null && subdir != null && changed)
			{
				lblSize.Text = "Tamaño del archivo:";
				string newDir;
				if (lbSubDir.SelectedIndex == 0)
				{
					newDir = dir.Parent.FullName;
				}
				else
				{
					newDir = subdir[lbSubDir.SelectedIndex - 1].FullName;
				}
				ChangeListsBoxs(newDir);
			}
		}

		private void MyMouseDoubleClick(object sender, MouseEventArgs e)
		{
			ChangeDirs();
		}
		private void BtnChange_Click(object sender, EventArgs e)
		{
			ChangeDirs();
		}

		private void LbFiles_SelectedIndexChanged(object sender, EventArgs e)
		{
			changed = true;
			if (lbFiles.SelectedItem != null)
			{
				FileInfo file = files[lbFiles.SelectedIndex];
				lblSize.Text = "Tamaño del archivo: " + SizeSuffix(file.Length);
				if (file.Extension == ".txt")
				{
					Form2 f2 = new(file.FullName);
					f2.Show();
				}
			}
		}

		static string SizeSuffix(double value)
		{
			string[] SizeSuffixes = { "bytes", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" };
			if (value <= 0)
			{
				return "0 bytes";
			}

			int i = 0;
			double dValue = value;
			while (Math.Round(dValue / 1024) >= 1)
			{
				dValue /= 1024;
				i++;
			}

			return string.Format("{0:.00} {1}", dValue, SizeSuffixes[i]);
		}

		private void LbSubDir_Enter(object sender, EventArgs e)
		{
			AcceptButton = btnChange;
		}

		private void LbSubDir_Leave(object sender, EventArgs e)
		{
			AcceptButton = btnIn;
		}

		private void LbSubDir_SelectedIndexChanged(object sender, EventArgs e)
		{
			changed = true;
		}
	}
}