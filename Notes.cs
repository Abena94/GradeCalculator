using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeCalculator
{
   public class Notes
	{
		public int NumeroEtudiant { get; set; }
		public int NumeroCours { get; set; }
		public float Note { get; set; }
		public Notes(int numeroEtudiant, int numeroCours, int note)
		{
			this.NumeroEtudiant = numeroEtudiant;
			this.NumeroCours = numeroCours;
			this.Note = note;
		}
		public string ToString()
		{
			return
				 "  *NumeroEtudiant:" + this.NumeroEtudiant + 
				"  *Note:" + this.Note + "  *Numerodecours:" + this.NumeroCours + "\n";
		}
	}
}
