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
	[Activity (Label = "coursesNourriture")]			
	public class coursesNourriture : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.coursesNourriture);

			var docsFolder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments); //on spécifie le chemin d'accès
			var pathToDatabase = System.IO.Path.Combine(docsFolder, "db_sqlnet.db");  //on donne un nom à la base de données
			var db = new SQLiteConnection(pathToDatabase);

			int codeSoiree = db.ExecuteScalar<int>("SELECT Max(CodeSoiree) FROM soiree");

			string apero1=db.ExecuteScalar<string> ("SELECT Apero1 FROM DBCourses WHERE CodeSoiree = ? ORDER BY Apero1 DESC", codeSoiree);
			string apero2=db.ExecuteScalar<string> ("SELECT Apero2 FROM DBCourses WHERE CodeSoiree = ? ORDER BY Apero2 DESC", codeSoiree);
			string apero3=db.ExecuteScalar<string> ("SELECT Apero3 FROM DBCourses WHERE CodeSoiree = ? ORDER BY Apero3 DESC", codeSoiree);
			string apero4=db.ExecuteScalar<string> ("SELECT Apero4 FROM DBCourses WHERE CodeSoiree = ? ORDER BY Apero4 DESC", codeSoiree);
			string apero5=db.ExecuteScalar<string> ("SELECT Apero5 FROM DBCourses WHERE CodeSoiree = ? ORDER BY Apero5 DESC", codeSoiree);

			string brunch1=db.ExecuteScalar<string> ("SELECT Brunch1 FROM DBCourses WHERE CodeSoiree = ? ORDER BY Brunch1 DESC", codeSoiree);
			string brunch2=db.ExecuteScalar<string> ("SELECT Brunch2 FROM DBCourses WHERE CodeSoiree = ? ORDER BY Brunch2 DESC", codeSoiree);
			string brunch3=db.ExecuteScalar<string> ("SELECT Brunch3 FROM DBCourses WHERE CodeSoiree = ? ORDER BY Brunch3 DESC", codeSoiree);
			string brunch4=db.ExecuteScalar<string> ("SELECT Brunch4 FROM DBCourses WHERE CodeSoiree = ? ORDER BY Brunch4 DESC", codeSoiree);
			string brunch5=db.ExecuteScalar<string> ("SELECT Brunch5 FROM DBCourses WHERE CodeSoiree = ? ORDER BY Brunch5 DESC", codeSoiree);

			string barbecue1=db.ExecuteScalar<string> ("SELECT Food1 FROM DBCourses WHERE CodeSoiree = ? ORDER BY Food1 DESC", codeSoiree);
			string barbecue2=db.ExecuteScalar<string> ("SELECT Food2 FROM DBCourses WHERE CodeSoiree = ? ORDER BY Food2 DESC", codeSoiree);
			string barbecue3=db.ExecuteScalar<string> ("SELECT Food3 FROM DBCourses WHERE CodeSoiree = ? ORDER BY Food3 DESC", codeSoiree);
			string barbecue4=db.ExecuteScalar<string> ("SELECT Food4 FROM DBCourses WHERE CodeSoiree = ? ORDER BY Food4 DESC", codeSoiree);
			string barbecue5=db.ExecuteScalar<string> ("SELECT Food5 FROM DBCourses WHERE CodeSoiree = ? ORDER BY Food5 DESC", codeSoiree);

			TextView courseN1 = FindViewById<TextView> (Resource.Id.cN1);
			TextView courseN2 = FindViewById<TextView> (Resource.Id.cN2);
			TextView courseN3 = FindViewById<TextView> (Resource.Id.cN3);
			TextView courseN4 = FindViewById<TextView> (Resource.Id.cN4);
			TextView courseN5 = FindViewById<TextView> (Resource.Id.cN5);
			TextView courseN6 = FindViewById<TextView> (Resource.Id.cN6);
			TextView courseN7 = FindViewById<TextView> (Resource.Id.cN7);
			TextView courseN8 = FindViewById<TextView> (Resource.Id.cN8);
			TextView courseN9 = FindViewById<TextView> (Resource.Id.cN9);
			TextView courseN10 = FindViewById<TextView> (Resource.Id.cN10);
			TextView courseN11 = FindViewById<TextView> (Resource.Id.cN11);
			TextView courseN12 = FindViewById<TextView> (Resource.Id.cN12);
			TextView courseN13 = FindViewById<TextView> (Resource.Id.cN13);
			TextView courseN14 = FindViewById<TextView> (Resource.Id.cN14);
			TextView courseN15 = FindViewById<TextView> (Resource.Id.cN15);

			courseN1.Text = apero1;
			courseN2.Text = apero2;
			courseN3.Text = apero3;
			courseN4.Text = apero4;
			courseN5.Text = apero5;
			courseN6.Text = barbecue1;
			courseN7.Text = barbecue2;
			courseN8.Text = barbecue3;
			courseN9.Text = barbecue4;
			courseN10.Text = barbecue5;
			courseN11.Text = brunch1;
			courseN12.Text = brunch2;
			courseN13.Text = brunch3;
			courseN14.Text = brunch4;
			courseN15.Text = brunch5;
		}
	}
}

