using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Dz_15_Zoo
{
	internal class Overseer
	{
		public string Name { get; set; }
		public int Age { get; set; }

		public Overseer(string arg_name, int arg_age)
		{
			Name = arg_name;
			Age = arg_age;
		}
		//Смотритеь осущесталяет случйную съемку выбранного животного
		public int startRecord()
		{
			Random rn = new Random();
			int temp = rn.Next(0, 24);
			if (temp >= 0 && temp < 8) { return 0; }//Животное спит
			else if (temp >= 8 && temp < 16) { return 1; }//Животное ест
			else { return 2; } //Животное гуляет
		}

	}
}
