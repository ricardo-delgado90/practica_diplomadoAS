using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace practica_diplomadoAS
{
	public class Hereo : ICloneable
	{
		public string Name { get; set; }
		public string ClassType { get; set; }
		public List<string> Skills { get; set; }
		public int Experience { get; set; }
		public int Level { get; set; }
		public int SkillPoints { get; set; }

		// Constructor
		public Hereo(string name, string classType, List<string> skills, int experience = 0, int level = 1, int skillPoints = 0)
		{
			Name = name;
			ClassType = classType;
			Skills = new List<string>(skills); // Copia la lista de habilidades
			Experience = experience;
			Level = level;
			SkillPoints = skillPoints;
		}

		// Método para clonar el héroe
		public object Clone()
		{
			// Realiza una clonación profunda
			return new Hereo(Name, ClassType, new List<string>(Skills), Experience, Level, SkillPoints);
		}

		// Método para personalizar el héroe clonado
		public void Customize(string newName, string newAppearance)
		{
			Name = newName;
			// Aquí podrías agregar lógica para cambiar el aspecto visual
			Console.WriteLine($"Hero {Name} now has a new appearance: {newAppearance}");
		}

		// Método para mostrar detalles del héroe
		public override string ToString()
		{
			return $"{Name} ({ClassType}) - Level: {Level}, Experience: {Experience}, Skill Points: {SkillPoints}, Skills: {string.Join(", ", Skills)}";
		}
	}
}

