using System;
using System.Collections.Generic;
using Android.App;
using Android.Widget;
using Android.OS;
using SQLite;

namespace Frenzyv1
{
		
	public class DBCourses 
	{
		
		[PrimaryKey, AutoIncrement]
		public int CoursesReference { get; set; } // Cle primaire

		public int CodeSoiree { get; set; } // clé étrangère issue de la table DBSoirée

		public string Alcool1 { get; set; }

		public string Alcool2 { get; set; }

		public string Alcool3 { get; set; }

		public string Alcool4 { get; set; }

		public string Alcool5 { get; set; }

		public string Soft1 { get; set; }

		public string Soft2 { get; set; }

		public string Soft3 { get; set; }

		public string Soft4 { get; set; }

		public string Soft5 { get; set; }

		public string Apero1 { get; set; }

		public string Apero2 { get; set; }

		public string Apero3 { get; set; }

		public string Apero4 { get; set; }

		public string Apero5 { get; set; }

		public string Extras1 { get; set; }

		public string Extras2 { get; set; }

		public string Extras3 { get; set; }

		public string Extras4 { get; set; }

		public string Extras5 { get; set; }

		public string Brunch1 { get; set; }

		public string Brunch2 { get; set; }

		public string Brunch3 { get; set; }

		public string Brunch4 { get; set; }

		public string Brunch5 { get; set; }

		public string Food1 { get; set; }

		public string Food2 { get; set; }

		public string Food3 { get; set; }

		public string Food4 { get; set; }

		public string Food5 { get; set; }

		public long prix { get; set; }

	}
}

