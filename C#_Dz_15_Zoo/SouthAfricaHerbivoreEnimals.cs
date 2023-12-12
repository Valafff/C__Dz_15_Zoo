using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Dz_15_Zoo
{
	internal class SouthAfricaHerbivoreEnimals : Enimal, IHerbivore
	{

		public void graze()
		{
			Console.WriteLine($"{Nickname} - травоядное, он питается растительной пищей");
		}
		public SouthAfricaHerbivoreEnimals(string arg_type, int arg_age, string arg_gender, string arg_nick)
        {
			Type = arg_type;
			Age = arg_age;
			Gender = arg_gender;
			Nickname = arg_nick;
		}

		public override void info()
		{
			Console.WriteLine($"Вид животного: {Type} Возраст: {Age} Пол: {Gender} Кличка: {Nickname}");
			graze();
		}
	}
}
