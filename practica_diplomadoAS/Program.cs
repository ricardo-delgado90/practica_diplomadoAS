using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_diplomadoAS
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var warrior = new Hereo("Aragorn", "Warrior", new List<string> { "Sword Attack", "Shield Defense" }, experience: 100, level: 5, skillPoints: 10);

			// Clonar el héroe
			var clonedWarrior = (Hereo)warrior.Clone();

			// Personalizar el héroe clonado
			clonedWarrior.Customize("Legolas", "Elf Archer");

			// Mostrar detalles del héroe original y el clonado
			Console.WriteLine("Original Hero:");
			Console.WriteLine(warrior);

			Console.WriteLine("\nCloned Hero:");
			Console.WriteLine(clonedWarrior);

			// Modificar una habilidad en el clon para demostrar que son independientes
			clonedWarrior.Skills.Add("Bow Attack");

			Console.WriteLine("\nAfter modifying cloned hero's skills:");
			Console.WriteLine("Original Hero:");
			Console.WriteLine(warrior);

			Console.WriteLine("\nCloned Hero:");
			Console.WriteLine(clonedWarrior);
		}
	}
}


