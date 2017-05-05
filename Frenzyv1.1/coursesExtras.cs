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
	[Activity (Label = "coursesExtras")]			
	public class coursesExtras : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.coursesExtras);

			var docsFolder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments); //on spécifie le chemin d'accès
			var pathToDatabase = System.IO.Path.Combine(docsFolder, "db_sqlnet.db");  //on donne un nom à la base de données
			var db = new SQLiteConnection(pathToDatabase);

			int codeSoiree = db.ExecuteScalar<int>("SELECT Max(CodeSoiree) FROM soiree");

			string extra1=db.ExecuteScalar<string> ("SELECT Extras1 FROM DBCourses WHERE CodeSoiree = ? ORDER BY Extras1 DESC", codeSoiree);
			string extra2=db.ExecuteScalar<string> ("SELECT Extras2 FROM DBCourses WHERE CodeSoiree = ? ORDER BY Extras2 DESC", codeSoiree);
			string extra3=db.ExecuteScalar<string> ("SELECT Extras3 FROM DBCourses WHERE CodeSoiree = ? ORDER BY Extras3 DESC", codeSoiree);
			string extra4=db.ExecuteScalar<string> ("SELECT Extras4 FROM DBCourses WHERE CodeSoiree = ? ORDER BY Extras4 DESC", codeSoiree);
			string extra5=db.ExecuteScalar<string> ("SELECT Extras5 FROM DBCourses WHERE CodeSoiree = ? ORDER BY Extras5 DESC", codeSoiree);


			TextView courseE1 = FindViewById<TextView> (Resource.Id.cE1);
			TextView courseE2 = FindViewById<TextView> (Resource.Id.cE2);
			TextView courseE3 = FindViewById<TextView> (Resource.Id.cE3);
			TextView courseE4 = FindViewById<TextView> (Resource.Id.cE4);
			TextView courseE5 = FindViewById<TextView> (Resource.Id.cE5);

			courseE1.Text = extra1;
			courseE2.Text = extra2;
			courseE3.Text = extra3;
			courseE4.Text = extra4;
			courseE5.Text = extra5;
		}
	}
}

