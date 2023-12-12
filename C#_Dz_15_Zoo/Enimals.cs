using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Dz_15_Zoo
{
	internal abstract class Enimal
	{
		public string Type { get; set; }
		public int Age { get; set; }
		public string Gender { get; set; }
        public string Nickname { get; set; }

		public void eat()
		{
			Console.WriteLine($"{Type} по кличке {Nickname} сейчас ест");
		}

		public void sleep()
		{
			Console.WriteLine($"{Type} по кличке {Nickname} сейчас спит");
		}

		public void walk()
		{
			Console.WriteLine($"{Type} по кличке {Nickname} сейчас гуляет");
		}
		public abstract void info();
	}
}
