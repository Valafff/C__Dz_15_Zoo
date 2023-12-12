using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Dz_15_Zoo
{
	internal class Source
	{
		public void Show()
		{

			Console.SetWindowSize(150, 70);
			Overseer zooWorker = new Overseer("Дядя Толя", 50);
			WildCats tiger = new WildCats("Тигр", 3, "самец", "Шерхан");
			WildCats leon = new WildCats("Лев", 1, "самка", "Налла");
			SouthAfricaHerbivoreEnimals zebra = new SouthAfricaHerbivoreEnimals("Зебра", 5, "самка", "Искра");
			SouthAfricaHerbivoreEnimals elephant = new SouthAfricaHerbivoreEnimals("Слон", 10, "самец", "Пи");
			Camera superCanon = new Camera();

			Menu menu = new Menu(new List<string> { "Показать тигра", "Показать льва", "Показать слона", "Показать зебру", "Выход" });
			menu.setMenuPoint = 0;
			int index;
			int randomtime;
			do
			{
				index = menu.KlacKlac_CS_v1();
				Console.Clear();
				Console.SetCursorPosition(0, 5);
				randomtime = zooWorker.startRecord(); // 0 - спит 1 - ест 2 - гуляет 
				Console.WriteLine();
				if (index == 0)
				{
					if (randomtime == 0)
					{
						tiger.sleep();
					}
					else if (randomtime == 1)
					{
						tiger.eat();
					}
					else tiger.walk();
					string path = "1" + Convert.ToString(randomtime) + ".jpg";
					superCanon.printImage(path);
				}
				if (index == 1)
				{
					if (randomtime == 0)
					{
						leon.sleep();
					}
					else if (randomtime == 1)
					{
						leon.eat();
					}
					else leon.walk();
					string path = "2" + Convert.ToString(randomtime) + ".jpg";
					superCanon.printImage(path);
				}
				if (index == 2)
				{

					if (randomtime == 0)
					{
						elephant.sleep();
					}
					else if (randomtime == 1)
					{
						elephant.eat();
					}
					else elephant.walk();
					string path = "3" + Convert.ToString(randomtime) + ".jpg";
					superCanon.printImage(path);
				}
				if (index == 3)
				{
					if (randomtime == 0)
					{
						zebra.sleep();
                    }
					else if (randomtime == 1)
					{
						zebra.eat();
					}
					else zebra.walk();
					string path = "4" + Convert.ToString(randomtime) + ".jpg";
					superCanon.printImage(path);
				}
				if (index == 4)
				{
					index = -1;
				}
			} while (index != -1);

		}
	}
}
