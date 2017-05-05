using System;
using System.Collections.Generic;
using Android.App;
using Android.Widget;
using Android.OS;
using SQLite;


namespace Frenzyv1
{
	public class DBMateriel
	{
		[PrimaryKey, AutoIncrement]
		public int MaterielReference { get; set; }

		public string Type { get; set; }   //Clé primaire, toujours vérifier qu'il n'y en a pas 2 pareils, sinon: update

		public string Categorie { get; set; }

		public long Prix { get; set; }

	}
}

