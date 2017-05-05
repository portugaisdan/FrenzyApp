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
	[Activity (Label = "ConfigSoiree", Icon = "@drawable/Frenzy")]		


	public class ConfigSoiree : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.Config_soiree);

			Button Alcool = FindViewById<Button> (Resource.Id.Alcool);
			Button Extras = FindViewById<Button> (Resource.Id.Extras);
			Button Food = FindViewById<Button> (Resource.Id.Food);
			Button Apero = FindViewById<Button> (Resource.Id.Apero);
			Button Brunch = FindViewById<Button> (Resource.Id.Brunch);
			Button Soft = FindViewById<Button> (Resource.Id.Soft);
			Button Select = FindViewById<Button> (Resource.Id.Select);

			var docsFolder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments); //on spécifie le chemin d'accès
			var pathToDatabase = System.IO.Path.Combine(docsFolder, "db_sqlnet.db");  //on donne un nom à la base de données
			var db = new SQLiteConnection(pathToDatabase);

			string typeSoiree = TypeSoiree.MyType;
			string majeur = db.ExecuteScalar<string> ("SELECT Majeur FROM User WHERE Mail = ? ORDER BY Majeur DESC", MainActivity.MyUser);

			switch (typeSoiree) {
			case "Barbecue":
				
				Alcool.Enabled = true;
				Soft.Enabled = true;
				Food.Enabled = true;
				Extras.Enabled = true;
				Brunch.Enabled = false;
				Apero.Enabled = false;
				break;

			case "BigParty":

				Alcool.Enabled = true;
				Soft.Enabled = true;
				Food.Enabled = false;
				Extras.Enabled = true;
				Brunch.Enabled = false;
				Apero.Enabled = true;
				break;

			case "Posee":

				Alcool.Enabled = true;
				Soft.Enabled = true;
				Food.Enabled = false;
				Extras.Enabled = true;
				Brunch.Enabled = false;
				Apero.Enabled = true;
				break;

			case "Brunch":

				Alcool.Enabled = false;
				Soft.Enabled = true;
				Food.Enabled = false;
				Extras.Enabled = true;
				Brunch.Enabled = true;
				Apero.Enabled = false;
				break;
			}

			if (majeur != "true")
				Alcool.Enabled = false;
				


			Alcool.Click += (sender, e) => {
				var intent = new Intent (this, typeof(Alcool));
				StartActivity (intent);
			};

			Soft.Click += (sender, e) => {
				var intent = new Intent (this, typeof(Soft));
				StartActivity (intent);
			};

			Food.Click += (sender, e) => {
				var intent = new Intent (this, typeof(Barbecue));
				StartActivity (intent);

			};

			Extras.Click += (sender, e) => {
				var intent = new Intent (this, typeof(Extras));
				StartActivity (intent);
			};

			Brunch.Click += (sender, e) => {
				var intent = new Intent (this, typeof(Brunch));
				StartActivity (intent);
			};

			Apero.Click += (sender, e) => {
				var intent = new Intent (this, typeof(Apero));
				StartActivity (intent);

			};

			Select.Click += (object sender, EventArgs e) => {
				var intent = new Intent (this, typeof(MaSoiree));
				StartActivity (intent);
			};

			// Create your application here
		}
	}
}

