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
	[Activity (Label = "MaSoiree")]			
	public class MaSoiree : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.Soirees);

			TextView PrixTotal = FindViewById<TextView> (Resource.Id.Total);
			Button ListeBoissonsSelectionnees = FindViewById<Button> (Resource.Id.ListeBS);
			Button ListeNourritureSelectionnee = FindViewById<Button> (Resource.Id.ListeNS);
			Button ListeExtrasSelectionnes = FindViewById<Button> (Resource.Id.ListeES);
			Button Friend = FindViewById<Button> (Resource.Id.Friend);
			Button ToMenu = FindViewById<Button> (Resource.Id.ToMenu);

			var docsFolder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments); //on spécifie le chemin d'accès
			var pathToDatabase = System.IO.Path.Combine(docsFolder, "db_sqlnet.db");  //on donne un nom à la base de données
			var db = new SQLiteConnection(pathToDatabase);
			// Create your application here

			int codeSoiree = db.ExecuteScalar<int>("SELECT Max(CodeSoiree) FROM soiree");

			long monPrix = db.ExecuteScalar<long> ("SELECT prix FROM DBCourses WHERE CodeSoiree=? ORDER BY prix DESC", codeSoiree);
			string nomSoiree = db.ExecuteScalar<string> ("SELECT Nom FROM soiree WHERE CodeSoiree=?", codeSoiree);
			string prix = System.Convert.ToString(monPrix);
			PrixTotal.Text = string.Format ("Le coût approximatif de votre soirée {0} est de \n {1} €",nomSoiree,prix);

			ListeBoissonsSelectionnees.Click += (sender, e) => {
				var intent = new Intent (this, typeof(coursesBoissons)); 
				StartActivity(intent); 
			};

			ListeNourritureSelectionnee.Click += (sender, e) => {
				var intent = new Intent (this, typeof(coursesNourriture)); 
				StartActivity(intent); 
			};

			ListeExtrasSelectionnes.Click += (sender, e) => {
				var intent = new Intent (this, typeof(coursesExtras)); 
				StartActivity(intent); 
			};
				
			Friend.Click += (sender, e) => {
				var intent = new Intent (this, typeof(Amis)); 
				StartActivity(intent); 
			};

			ToMenu.Click += (sender, e) => {
				var intent = new Intent (this, typeof(MainMenu)); 
				StartActivity(intent); 
			};
				
		}
	}
}

