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
	[Activity (Label = "CreerSoiree", Icon = "@drawable/Frenzy")]	



	public class CreerSoiree : Activity
	{

		public static string MaSoiree="";
		public static int codeSoiree;


		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.Creer_sa_soiree);
			//On clic pour aller vers le menu lié au calendrier
			Button btnCalendrier = FindViewById<Button> (Resource.Id.btnCalendrier);
			Button btnNombreInvites = FindViewById<Button> (Resource.Id.btnNombreInvites);
			Button btnTypeDeSoiree = FindViewById<Button> (Resource.Id.btnTypeDeSoiree);
			Button CreerSoiree = FindViewById<Button> (Resource.Id.CreerSoiree);
			EditText nomSoiree = FindViewById<EditText> (Resource.Id.Nom);
			var docsFolder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments); //on spécifie le chemin d'accès
			var pathToDatabase = System.IO.Path.Combine(docsFolder, "db_sqlnet.db");  //on donne un nom à la base de données
			CreerSoiree.Enabled = false;
			nomSoiree.Enabled = false;
			var db = new SQLiteConnection(pathToDatabase);
			string Major = db.ExecuteScalar<string> ("SELECT Majeur FROM User WHERE Mail = ?", MainActivity.MyUser);

			if (invites.nombreInvites != 0 && TypeSoiree.MyType != "") {
				CreerSoiree.Enabled = true;
				nomSoiree.Enabled = true;
			}
		
			btnCalendrier.Click += (sender, e) => {
				var intent = new Intent (this, typeof(calendrier)); 
				StartActivity(intent); 
			};
					

			btnNombreInvites.Click += (sender, e) => {
				var intent = new Intent (this, typeof(invites)); 
				StartActivity(intent); 
			};

		
			btnTypeDeSoiree.Click += (sender, e) => {
				var intent = new Intent (this, typeof(TypeSoiree)); 
				StartActivity(intent); 
			};



			CreerSoiree.Click += (sender, e) => {	

				MaSoiree=nomSoiree.Text;
				var result = MainActivity.insertUpdateDataSOIREE (new soiree {
					Type = string.Format("{0}" ,TypeSoiree.MyType),
					Mail = string.Format("{0}",MainActivity.MyUser),
					Majeur = Major,
					NombrePersonnes=invites.nombreInvites,
					Date= calendrier.DateDeMaSoiree,
					Nom = nomSoiree.Text,
					},pathToDatabase );

				codeSoiree = db.ExecuteScalar<int>("SELECT Max(CodeSoiree) FROM soiree");
				
				var intent = new Intent (this, typeof(ConfigSoiree)); 
				StartActivity(intent); 
			};

		}
	}
}

