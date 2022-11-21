#nullable disable

using Microsoft.VisualBasic;
using System.Diagnostics;
using System.IO;
using System.Runtime.Intrinsics.X86;

namespace Ex2
{
	delegate void MyDelegate(FileInfo file, string toSearch, ListBox lbx, bool caseSensitive);

	public partial class Form1 : Form
	{
		public readonly object l = new();
		DirectoryInfo dir = null;
		List<FileInfo> files = new();
		public Form1()
		{
			InitializeComponent();
			AcceptButton = btnSearch;
		}

		private void BtnSearch_Click(object sender, EventArgs e)
		{
			lbAppearings.Items.Clear();
			files.Clear();
			Debug.WriteLine(files?.Count);
			lblError.Text = "";
			if (txbPath.Text.Trim() != "" && txbForSearch.Text.Trim() != "")
			{
				try
				{
					string toSearch = txbForSearch.Text.Trim();
					dir = new DirectoryInfo(txbPath.Text.Trim());
					FileInfo filters = SearchForFilters();
					if (filters == null)
					{
						Array.ForEach(dir.GetFiles("*.txt"), file => files.Add(file));
						ThreadsForFiles(files, toSearch);
					}
					else
					{
						FilesWithFilters(dir, toSearch, filters);
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
			else
			{
				lblError.Text = "Debe introducir un directorio y una letra, palabra o frase a buscar.";
			}
		}

		private void FilesWithFilters(DirectoryInfo dir, string toSearch, FileInfo filterinfo)
		{
			string[] filt = filters(filterinfo.FullName);

			//Por cada filtro buscamos los archivos que terminen en dicha extension y los añadimos al List de FileInfos
			Array.ForEach(filt, ext => Array.ForEach(dir.GetFiles(ext), file => files.Add(file)));

			ThreadsForFiles(files, toSearch);
		}

		FileInfo SearchForFilters()
		{
			FileInfo filters = new FileInfo("C:\\" + Environment.GetEnvironmentVariable("homepath") + "\\filter.txt");
			if (filters.Exists)
			{
				return filters;
			}
			else
			{
				return null;
			}
		}

		static string[] filters(string path)
		{
			StreamReader sr;
			string aux = "";
			using (sr = new StreamReader(path))
			{
				aux = sr.ReadToEnd();
			}
			return aux.Split(',');
		}

		void ThreadsForFiles(List<FileInfo> files, string toSearch)
		{
			if (files.Count != 0)
			{
				for (int i = 0; i < files.Count; i++)
				{
					MyDelegate d = SearchOnFiles;
					int a = i;
					Thread t = new(() => Invoke(d, files[a], toSearch, lbAppearings, cbxCaseSensitive.Checked))
					{
						IsBackground = true,
					};
					t.Start();
				}
			}
			else
			{
				lblError.Text = "No se han encontrado archivos con la(s) extensiones seleccionadas";
			}
		}

		private void SearchOnFiles(FileInfo file, string toSearch, ListBox lbx, bool caseSensitive)
		{
			FileInfo theFile = file;
			int cont = 0;
			int appear = 0;
			string aux = "";
			StreamReader sr;
			using (sr = new StreamReader(theFile.FullName))
			{
				while ((aux = sr.ReadLine()) != null)
				{
					lock (l)
					{
						if (IgnoreCase(caseSensitive, aux, toSearch))
						{
							lbx.Items.Add(string.Format("Archivo: {0} | {1} | Línea {2}", theFile.Name, aux.Trim(), cont));
							appear++;
						}
						cont++;
					}
				}
				lbx.Items.Add(string.Format("Nº total apariciones en el archivo "+"\"{0}\""+"+: {1}", theFile.Name, appear));
				lbx.Items.Add("----");
			}
		}

		bool IgnoreCase(bool caseSensitive, string aux, string toSearch)
		{
			bool finalCaseSensitive;
			if (!caseSensitive)
			{
				finalCaseSensitive = aux.Contains(toSearch, StringComparison.CurrentCultureIgnoreCase);
			}
			else
			{
				finalCaseSensitive = aux.Contains(toSearch);
			}

			return finalCaseSensitive;
		}

		private void TxbFilters_Enter(object sender, EventArgs e)
		{
			AcceptButton = btnGuardar;
		}

		private void SearchEnter(object sender, EventArgs e)
		{
			AcceptButton = btnSearch;
		}

		private void BtnGuardar_Click(object sender, EventArgs e)
		{
			string wFilters = txbFilters.Text;
			StreamWriter sw;
			using (sw = new StreamWriter("C:\\" + Environment.GetEnvironmentVariable("homepath") + "\\filter.txt"))
			{
				sw.Write(wFilters);
			}
		}
	}
}