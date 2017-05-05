using System;
using System.Data;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Mono.Data.Sqlite;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using SQLite;
using System.Security.Cryptography;



namespace Frenzyv1
{
	[Activity (Label = "createUser")]			

	public class createUser : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.Layout2);

			//declaration des boutons
			Button btnCreate = FindViewById<Button>  (Resource.Id.btnValider);
			EditText Mail = FindViewById<EditText> (Resource.Id.editMail);
			EditText Password = FindViewById<EditText> (Resource.Id.editPass);
			EditText Prenom = FindViewById<EditText> (Resource.Id.editPrenom);
			EditText Nom = FindViewById<EditText> (Resource.Id.editNom);
			EditText CP = FindViewById<EditText> (Resource.Id.editCP);
			CheckBox Majeur = FindViewById<CheckBox> (Resource.Id.majorite);
			var docsFolder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments); //on spécifie le chemin d'accès
			var pathToDatabase = System.IO.Path.Combine(docsFolder, "db_sqlnet.db");  //on donne un nom à la base de données

			btnCreate.Click += (object sender, EventArgs e) => {

				if (Mail.Text.Contains ("@") && Password.Text != "" && Prenom.Text != "" && Nom.Text != "" && CP.Text != "" ) {
					if(Majeur.Checked)
					{
					var db = new SQLiteConnection(pathToDatabase);
				    var result =MainActivity.insertUpdateDataUSER (new User {
						Prenom = Prenom.Text  ,
						Nom = Nom.Text,
						Mail = Mail.Text,
						Password = Password.Text,
						Ville = CP.Text,
						Majeur = "true",
					},pathToDatabase );

						var intent= new Intent(this, typeof(MainMenu));
						StartActivity(intent);
					}

				

				else if (Mail.Text.Contains ("@") && Password.Text != "" && Prenom.Text != "" && Nom.Text != "" && CP.Text != "" ) {
					var db = new SQLiteConnection(pathToDatabase);
					var result =MainActivity.insertUpdateDataUSER (new User {
						Prenom = Prenom.Text  ,
						Nom = Nom.Text,
						Mail = Mail.Text,
						Password =Password.Text,
						Ville = CP.Text,
						Majeur = "false",
					},pathToDatabase );

						var intent= new Intent(this, typeof(MainMenu));
						StartActivity(intent);
				}
				}


				else
				{
					AlertDialog.Builder builder = new AlertDialog.Builder (this);
					AlertDialog alert = builder.Create();
					alert.SetTitle ("ERREUR");
					alert.SetMessage ("Merci de remplir tous les champs \n avec des données valides");
					alert.SetCancelable (false);
					alert.SetButton ("OK", (object sender2, DialogClickEventArgs e2) =>
						{
							alert.Cancel();
						});                    
					alert.Show ();
				}
			};
	}
}
}

