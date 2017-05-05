using System;
using System.Collections.Generic;
using Android.App;
using Android.Widget;
using Android.OS;
using SQLite;


namespace Frenzyv1
{
	public class soiree
	{
		[PrimaryKey, AutoIncrement]
			
		public int CodeSoiree { get; set; }   //Clé primaire, toujours vérifier qu'il n'y en a pas 2 pareils, sinon: update

		public string Type { get; set; }

		public string Majeur { get; set; }

		public DateTime Date { get; set; }

		public int NombrePersonnes { get; set; }

		public string Nom { get ; set; }

		public string Mail { get; set; }      // Clé étrangère, issue de la table USER qui permet d'associer la soirée à son organisateur
				
	}
}

