#define TEST

using System.IO;

namespace Ex3
{
	internal class Program
	{
		public static string directory = Environment.GetEnvironmentVariable("APPDATA");

		public static double money(IPastaGansa interf)
		{
			Console.WriteLine("Indique las ganancias de la empresa: ");
			double money = Convert.ToDouble(Console.ReadLine());
			return interf.GanarPasta(money);
		}

		public static void ReadPersons(UserInterface ui)
		{
			FileInfo f = new(directory + "\\people.dat");
			if (f.Exists)
			{
				using (Reader r = new Reader(new FileStream(directory + "\\people.dat", FileMode.Open)))
				{
					try
					{
						while (true)
						{
							byte header = r.ReadByte();
							ui.gest.personal.Add(r.ReadPerson(header));
						}
					}
					catch (EndOfStreamException)
					{
						return;
					}
				}
			}
		}

		public static void WritePersons(UserInterface ui)
		{
			using (Writer w = new Writer(new FileStream(directory + "\\people.dat", FileMode.Create)))
			{
				foreach (var item in ui.gest.personal)
				{
					w.WritePerson(item);
				}
			}
		}

		static void Main(string[] args)
		{
			UserInterface ui = new UserInterface();
#if TES
			ui.gest.personal.Add(new Empleado("Nombre11111", "MiApellido1", "47407434", 18, 1000, "600000000"));
			ui.gest.personal.Add(new Empleado("Nombre2", "Apellido2", "47407434", 20, 1100, "600000001"));
			ui.gest.personal.Add(new Directivo("Nombre3", "Apellido3333", "47407434", 22, "RRHH", 50));
#endif
			ReadPersons(ui);
			ui.Inicio();
			WritePersons(ui);
		}

	}
}