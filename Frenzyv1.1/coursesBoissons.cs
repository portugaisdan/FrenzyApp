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
	[Activity (Label = "coursesBoissons")]			
	public class coursesBoissons : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.coursesBoissons);

			var docsFolder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments); //on spécifie le chemin d'accès
			var pathToDatabase = System.IO.Path.Combine(docsFolder, "db_sqlnet.db");  //on donne un nom à la base de données
			var db = new SQLiteConnection(pathToDatabase);

			int codeSoiree = db.ExecuteScalar<int>("SELECT Max(CodeSoiree) FROM soiree");

			string alcool1=db.ExecuteScalar<string> ("SELECT Alcool1 FROM DBCourses WHERE CodeSoiree = ? ORDER BY Alcool1 DESC", codeSoiree);
			string alcool2=db.ExecuteScalar<string> ("SELECT Alcool2 FROM DBCourses WHERE CodeSoiree = ? ORDER BY Alcool2 DESC", codeSoiree);
			string alcool3=db.ExecuteScalar<string> ("SELECT Alcool3 FROM DBCourses WHERE CodeSoiree = ? ORDER BY Alcool3 DESC", codeSoiree);
			string alcool4=db.ExecuteScalar<string> ("SELECT Alcool4 FROM DBCourses WHERE CodeSoiree = ? ORDER BY Alcool4 DESC", codeSoiree);
			string alcool5=db.ExecuteScalar<string> ("SELECT Alcool5 FROM DBCourses WHERE CodeSoiree = ? ORDER BY Alcool5 DESC", codeSoiree);

			string soft1=db.ExecuteScalar<string> ("SELECT Soft1 FROM DBCourses WHERE CodeSoiree = ? ORDER BY Soft1 DESC", codeSoiree);
			string soft2=db.ExecuteScalar<string> ("SELECT Soft2 FROM DBCourses WHERE CodeSoiree = ? ORDER BY Soft2 DESC", codeSoiree);
			string soft3=db.ExecuteScalar<string> ("SELECT Soft3 FROM DBCourses WHERE CodeSoiree = ? ORDER BY Soft3 DESC", codeSoiree);
			string soft4=db.ExecuteScalar<string> ("SELECT Soft4 FROM DBCourses WHERE CodeSoiree = ? ORDER BY Soft4 DESC", codeSoiree);
			string soft5=db.ExecuteScalar<string> ("SELECT Soft5 FROM DBCourses WHERE CodeSoiree = ? ORDER BY Soft5 DESC", codeSoiree);

			TextView courseB1 = FindViewById<TextView> (Resource.Id.cB1);
			TextView courseB2 = FindViewById<TextView> (Resource.Id.cB2);
			TextView courseB3 = FindViewById<TextView> (Resource.Id.cB3);
			TextView courseB4 = FindViewById<TextView> (Resource.Id.cB4);
			TextView courseB5 = FindViewById<TextView> (Resource.Id.cB5);
			TextView courseB6 = FindViewById<TextView> (Resource.Id.cB6);
			TextView courseB7 = FindViewById<TextView> (Resource.Id.cB7);
			TextView courseB8 = FindViewById<TextView> (Resource.Id.cB8);
			TextView courseB9 = FindViewById<TextView> (Resource.Id.cB9);
			TextView courseB10 = FindViewById<TextView> (Resource.Id.cB10);

			courseB1.Text = alcool1;
			courseB2.Text = alcool2;
			courseB3.Text = alcool3;
			courseB4.Text = alcool4;
			courseB5.Text = alcool5;
			courseB6.Text = soft1;
			courseB7.Text = soft2;
			courseB8.Text = soft3;
			courseB9.Text = soft4;
			courseB10.Text = soft5;
		}
	}
}

