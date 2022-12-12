#nullable disable

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ex3
{
	internal class Writer : BinaryWriter
	{


		public Writer(Stream str) : base(str)
		{
		}

		public void WritePerson(Persona p)
		{
			bool e = false;
			byte header;

			if (p is Empleado)
			{
				header = 0;
				e = true;
			}
			else
			{
				header = 1;
			}

			base.Write(header);
			base.Write(p.Name);
			base.Write(p.LastName);
			base.Write(p.Dni);
			base.Write(p.Age);

			if (e)
			{
				base.Write(((Empleado)p).salario);
				base.Write(((Empleado)p).Phone);
			}
			else
			{
				base.Write(((Directivo)p).dept);
				base.Write(((Directivo)p).Workers);
			}

		}
	}
}
