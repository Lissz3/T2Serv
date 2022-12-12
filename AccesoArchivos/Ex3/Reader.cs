#nullable disable

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ex3
{
	internal class Reader : BinaryReader
	{
		public Reader(Stream input) : base(input)
		{
		}
		public Persona ReadPerson(byte header)
		{
			Persona p;
			string name = base.ReadString();
			string lastName = base.ReadString();
			string dni = base.ReadString();
			int age = base.ReadInt32();

			if (header == 0)
			{
				p = new Empleado
				{
					Name = name,
					LastName = lastName,
					Dni = dni,
					Age = age,
					salario = base.ReadDouble(),
					Phone = base.ReadString()
				};

			}
			else
			{
				p = new Directivo
				{
					Name = name,
					LastName = lastName,
					Dni = dni,
					Age = age,
					dept = base.ReadString(),
					Workers = base.ReadInt32()
				};

			}

			return p;
		}

	}
}
