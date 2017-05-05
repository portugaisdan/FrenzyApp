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
	[Activity (Label = "Extras")]			
	public class Extras : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView(Resource.Layout.Choix);

			Button Sel1 = FindViewById<Button> (Resource.Id.Sel1);
			Button Sel2 = FindViewById<Button> (Resource.Id.Sel2);
			Button Sel3 = FindViewById<Button> (Resource.Id.Sel3);
			Button Sel4 = FindViewById<Button> (Resource.Id.Sel4);
			Button Sel5 = FindViewById<Button> (Resource.Id.Sel5);
			Button valider = FindViewById<Button> (Resource.Id.MonChoix);
			TextView FirstChoice = FindViewById<TextView> (Resource.Id.textView1);
			TextView SecondChoice = FindViewById<TextView> (Resource.Id.textView2);
			TextView ThirdChoice = FindViewById<TextView> (Resource.Id.textView3);
			TextView FourthChoice = FindViewById<TextView> (Resource.Id.textView4);
			TextView FifthChoice = FindViewById<TextView> (Resource.Id.textView5);


			var docsFolder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments); //on spécifie le chemin d'accès
			var pathToDatabase = System.IO.Path.Combine(docsFolder, "db_sqlnet.db");  //on donne un nom à la base de données
			var db = new SQLiteConnection(pathToDatabase);


			string choix1=db.ExecuteScalar<string> ("SELECT Extras1 FROM DBCourses WHERE CodeSoiree = ? ORDER BY Extras1 DESC", CreerSoiree.codeSoiree);
			string choix2=db.ExecuteScalar<string> ("SELECT Extras2 FROM DBCourses WHERE CodeSoiree = ? ORDER BY Extras2 DESC", CreerSoiree.codeSoiree);
			string choix3=db.ExecuteScalar<string> ("SELECT Extras3 FROM DBCourses WHERE CodeSoiree = ? ORDER BY Extras3 DESC", CreerSoiree.codeSoiree);
			string choix4=db.ExecuteScalar<string> ("SELECT Extras4 FROM DBCourses WHERE CodeSoiree = ? ORDER BY Extras4 DESC", CreerSoiree.codeSoiree);
			string choix5=db.ExecuteScalar<string> ("SELECT Extras5 FROM DBCourses WHERE CodeSoiree = ? ORDER BY Extras5 DESC", CreerSoiree.codeSoiree);


			if (choix1 != null)
				FirstChoice.Text = choix1;

			if (choix2 != null)
				SecondChoice.Text = choix2;

			if (choix3 != null)
				ThirdChoice.Text = choix3;

			if (choix4 != null)
				FourthChoice.Text = choix4;

			if (choix5 != null)
				FifthChoice.Text = choix5;
			

			Sel1.Click += (sender, e) => {
				var intent = new Intent (this, typeof(ListeExtras));
				intent.PutExtra("choix","1");
				StartActivity (intent);
			} ;

			Sel2.Click += (sender, e) => {
				var intent = new Intent (this, typeof(ListeExtras));
				intent.PutExtra("choix","2");
				StartActivity (intent);	

			} ;

			Sel3.Click += (sender, e) => {
				var intent = new Intent (this, typeof(ListeExtras));
				intent.PutExtra("choix","3");
				StartActivity (intent);
			} ;

			Sel4.Click += (sender, e) => {
				var intent = new Intent (this, typeof(ListeExtras));
				intent.PutExtra("choix","4");
				StartActivity (intent);
			} ;

			Sel5.Click += (sender, e) => {
				var intent = new Intent (this, typeof(ListeExtras));
				intent.PutExtra("choix","5");
				StartActivity (intent);
			};

			valider.Click += (sender, e) => {
				var intent = new Intent (this, typeof(ConfigSoiree));
				StartActivity (intent);
			} ;



			// Create your application here
		}
	}
}

