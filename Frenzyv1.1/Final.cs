using System;
using System.Data;
using System.IO;
using System.Collections.Generic;
using Android.Runtime;
using Android.Views;
using Android.App;
using Android.Content;
using Android.Widget;
using Android.OS;
using Mono.Data.Sqlite;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using SQLite;
using Materiel;
using System.Security.Cryptography;

namespace Frenzyv1


{
	[Activity (Label = "Final")]			
	public class Final : ListActivity
	{
		string[] items;
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			//SetContentView(Resource.Layout.finis);

			var docsFolder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments); //on spécifie le chemin d'accès
			var pathToDatabase = System.IO.Path.Combine(docsFolder, "db_sqlnet.db");  //on donne un nom à la base de données
			var db = new SQLiteConnection(pathToDatabase);

			string alcool1=db.ExecuteScalar<string> ("SELECT Alcool1 FROM DBCourses WHERE CodeSoiree = ? ORDER BY Alcool1 DESC", CreerSoiree.codeSoiree);
			string alcool2=db.ExecuteScalar<string> ("SELECT Alcool2 FROM DBCourses WHERE CodeSoiree = ? ORDER BY Alcool2 DESC", CreerSoiree.codeSoiree);
			string alcool3=db.ExecuteScalar<string> ("SELECT Alcool3 FROM DBCourses WHERE CodeSoiree = ? ORDER BY Alcool3 DESC", CreerSoiree.codeSoiree);
			string alcool4=db.ExecuteScalar<string> ("SELECT Alcool4 FROM DBCourses WHERE CodeSoiree = ? ORDER BY Alcool4 DESC", CreerSoiree.codeSoiree);
			string alcool5=db.ExecuteScalar<string> ("SELECT Alcool5 FROM DBCourses WHERE CodeSoiree = ? ORDER BY Alcool5 DESC", CreerSoiree.codeSoiree);

			string soft1=db.ExecuteScalar<string> ("SELECT Soft1 FROM DBCourses WHERE CodeSoiree = ? ORDER BY Soft1 DESC", CreerSoiree.codeSoiree);
			string soft2=db.ExecuteScalar<string> ("SELECT Soft2 FROM DBCourses WHERE CodeSoiree = ? ORDER BY Soft2 DESC", CreerSoiree.codeSoiree);
			string soft3=db.ExecuteScalar<string> ("SELECT Soft3 FROM DBCourses WHERE CodeSoiree = ? ORDER BY Soft3 DESC", CreerSoiree.codeSoiree);
			string soft4=db.ExecuteScalar<string> ("SELECT Soft4 FROM DBCourses WHERE CodeSoiree = ? ORDER BY Soft4 DESC", CreerSoiree.codeSoiree);
			string soft5=db.ExecuteScalar<string> ("SELECT Soft5 FROM DBCourses WHERE CodeSoiree = ? ORDER BY Soft5 DESC", CreerSoiree.codeSoiree);

			string apero1=db.ExecuteScalar<string> ("SELECT Apero1 FROM DBCourses WHERE CodeSoiree = ? ORDER BY Apero1 DESC", CreerSoiree.codeSoiree);
			string apero2=db.ExecuteScalar<string> ("SELECT Apero2 FROM DBCourses WHERE CodeSoiree = ? ORDER BY Apero2 DESC", CreerSoiree.codeSoiree);
			string apero3=db.ExecuteScalar<string> ("SELECT Apero3 FROM DBCourses WHERE CodeSoiree = ? ORDER BY Apero3 DESC", CreerSoiree.codeSoiree);
			string apero4=db.ExecuteScalar<string> ("SELECT Apero4 FROM DBCourses WHERE CodeSoiree = ? ORDER BY Apero4 DESC", CreerSoiree.codeSoiree);
			string apero5=db.ExecuteScalar<string> ("SELECT Apero5 FROM DBCourses WHERE CodeSoiree = ? ORDER BY Apero5 DESC", CreerSoiree.codeSoiree);

			string brunch1=db.ExecuteScalar<string> ("SELECT Brunch1 FROM DBCourses WHERE CodeSoiree = ? ORDER BY Brunch1 DESC", CreerSoiree.codeSoiree);
			string brunch2=db.ExecuteScalar<string> ("SELECT Brunch2 FROM DBCourses WHERE CodeSoiree = ? ORDER BY Brunch2 DESC", CreerSoiree.codeSoiree);
			string brunch3=db.ExecuteScalar<string> ("SELECT Brunch3 FROM DBCourses WHERE CodeSoiree = ? ORDER BY Brunch3 DESC", CreerSoiree.codeSoiree);
			string brunch4=db.ExecuteScalar<string> ("SELECT Brunch4 FROM DBCourses WHERE CodeSoiree = ? ORDER BY Brunch4 DESC", CreerSoiree.codeSoiree);
			string brunch5=db.ExecuteScalar<string> ("SELECT Brunch5 FROM DBCourses WHERE CodeSoiree = ? ORDER BY Brunch5 DESC", CreerSoiree.codeSoiree);

			string barbecue1=db.ExecuteScalar<string> ("SELECT Food1 FROM DBCourses WHERE CodeSoiree = ? ORDER BY Food1 DESC", CreerSoiree.codeSoiree);
			string barbecue2=db.ExecuteScalar<string> ("SELECT Food2 FROM DBCourses WHERE CodeSoiree = ? ORDER BY Food2 DESC", CreerSoiree.codeSoiree);
			string barbecue3=db.ExecuteScalar<string> ("SELECT Food3 FROM DBCourses WHERE CodeSoiree = ? ORDER BY Food3 DESC", CreerSoiree.codeSoiree);
			string barbecue4=db.ExecuteScalar<string> ("SELECT Food4 FROM DBCourses WHERE CodeSoiree = ? ORDER BY Food4 DESC", CreerSoiree.codeSoiree);
			string barbecue5=db.ExecuteScalar<string> ("SELECT Food5 FROM DBCourses WHERE CodeSoiree = ? ORDER BY Food5 DESC", CreerSoiree.codeSoiree);

			string extras1=db.ExecuteScalar<string> ("SELECT Extras1 FROM DBCourses WHERE CodeSoiree = ? ORDER BY Extras1 DESC", CreerSoiree.codeSoiree);
			string extras2=db.ExecuteScalar<string> ("SELECT Extras2 FROM DBCourses WHERE CodeSoiree = ? ORDER BY Extras2 DESC", CreerSoiree.codeSoiree);
			string extras3=db.ExecuteScalar<string> ("SELECT Extras3 FROM DBCourses WHERE CodeSoiree = ? ORDER BY Extras3 DESC", CreerSoiree.codeSoiree);
			string extras4=db.ExecuteScalar<string> ("SELECT Extras4 FROM DBCourses WHERE CodeSoiree = ? ORDER BY Extras4 DESC", CreerSoiree.codeSoiree);
			string extras5=db.ExecuteScalar<string> ("SELECT Extras5 FROM DBCourses WHERE CodeSoiree = ? ORDER BY Extras5 DESC", CreerSoiree.codeSoiree);

			items = new string[] { alcool1, alcool2, alcool3, alcool4, alcool5,
				soft1, soft2, soft3, soft4, soft5,
				apero1, apero2, apero3, apero4, apero5,
				brunch1, brunch2, brunch3, brunch4, brunch5,
				barbecue1, barbecue2, barbecue3, barbecue4, barbecue5,
				extras1, extras2, extras3, extras4, extras5
			};
		
			ListAdapter = new ArrayAdapter<String> (this, Android.Resource.Layout.SimpleListItem1, items);

		}
	}
}

