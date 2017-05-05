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
	[Activity (Label = "Frenzy v2.0", MainLauncher = true, Icon = "@drawable/Frenzy")]
	public class MainActivity : Activity
	{

		public static string MyUser="";
		//gestion android: le on create sert à lancer le code
	

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// create DB path
			var docsFolder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments); //on spécifie le chemin d'accès
			var pathToDatabase = System.IO.Path.Combine(docsFolder, "db_sqlnet.db");  //on donne un nom à la base de données
			var result = createDatabase(pathToDatabase);     //crée la base de données (sauf si elle existe déjà)
			if (result == "Database created") 
				
				SetContentView (Resource.Layout.Main);// on affiche l'écran d'accueil
			
			Button btnLogin = FindViewById<Button>  (Resource.Id.btnLogin);
			Button Compte = FindViewById<Button> (Resource.Id.Compte);
			EditText text1 = FindViewById<EditText> (Resource.Id.editText1);
			EditText text2 = FindViewById<EditText> (Resource.Id.editText2);


			btnLogin.Click += (object sender, EventArgs e) => {
				if (text1.Text.Contains ("@") && text2.Text != "") {

					MyUser = text1.Text;
					var db = new SQLiteConnection (pathToDatabase);
					var mail = db.ExecuteScalar<string> ("SELECT Mail FROM User WHERE Mail = ?", text1.Text);
					if (mail != null) {	
						string password = db.ExecuteScalar<string> ("SELECT Password FROM User WHERE Mail = ?", text1.Text);	
						if (password == text2.Text) {	
							var intent = new Intent (this, typeof(MainMenu));
							StartActivity (intent);
						} else {
							AlertDialog.Builder builder = new AlertDialog.Builder (this);
							AlertDialog alert = builder.Create ();
							alert.SetTitle ("ERREUR");
							alert.SetMessage ("ENTRER UN MDP VALIDE");
							alert.SetCancelable (false);
							alert.SetButton ("OK", (object sender2, DialogClickEventArgs e2) => {
								alert.Cancel ();
							});                    
							alert.Show ();
						}
							
					} else {
						var intent = new Intent (this, typeof(createUser));
						StartActivity (intent);
					}
				} else {
					AlertDialog.Builder builder = new AlertDialog.Builder (this);
					AlertDialog alert = builder.Create ();
					alert.SetTitle ("ERREUR");
					alert.SetMessage ("ENTRER UN MAIL OU UN MDP VALIDE");
					alert.SetCancelable (false);
					alert.SetButton ("OK", (object sender2, DialogClickEventArgs e2) => {
						alert.Cancel ();
					});                    
					alert.Show ();
				}
			};
			Compte.Click += (object sender, EventArgs e) => {
				var intent = new Intent (this, typeof(createUser));
				StartActivity (intent);
			};
		}
								
		

	public string insertUpdateAllDataUSER(IEnumerable<User> data, string path)
	{
		try
		{
			var db = new SQLiteConnection(path);
			if (db.InsertAll(data) != 0)
			db.UpdateAll(data);
			return "List of data inserted or updated";
		}
		catch (SQLiteException ex)
		{
			return ex.Message;
		}
	}

		public string insertUpdateAllDataMATERIEL(IEnumerable<User> data, string path)
		{
			try
			{
				var db = new SQLiteConnection(path);
				if (db.InsertAll(data) != 0)
					db.UpdateAll(data);
				return "List of data inserted or updated";
			}
			catch (SQLiteException ex)
			{
				return ex.Message;
			}
		}

		public string insertUpdateAllDataSOIREE(IEnumerable<soiree> data, string path)
		{
			try
			{
				var db = new SQLiteConnection(path);
				if (db.InsertAll(data) != 0)
					db.UpdateAll(data);
				return "List of data inserted or updated";
			}
			catch (SQLiteException ex)
			{
				return ex.Message;
			}
		}

		public string insertUpdateAllDataCOURSES(IEnumerable<DBCourses> data, string path)
		{
			try
			{
				var db = new SQLiteConnection(path);
				if (db.InsertAll(data) != 0)
					db.UpdateAll(data);
				return "List of data inserted or updated";
			}
			catch (SQLiteException ex)
			{
				return ex.Message;
			}
		}

	public int findNumberRecordsInUSER(string path)
	{
		try
		{
			var db = new SQLiteConnection(path);
			// this counts all records in the database, it can be slow depending on the size of the database
			var count = db.ExecuteScalar<int>("SELECT Count(*) FROM USER");

			// for a non-parameterless query
			// var count = db.ExecuteScalar<int>("SELECT Count(*) FROM Person WHERE FirstName="Amy");

			return count;
		}
		catch (SQLiteException)
		{
			return -1;
		}
	}

		public int findNumberRecordsInSOIREE(string path)
		{
			try
			{
				var db = new SQLiteConnection(path);
				// this counts all records in the database, it can be slow depending on the size of the database
				var count = db.ExecuteScalar<int>("SELECT Count(*) FROM SOIREE");

				// for a non-parameterless query
				// var count = db.ExecuteScalar<int>("SELECT Count(*) FROM Person WHERE FirstName="Amy");

				return count;
			}
			catch (SQLiteException)
			{
				return -1;
			}
		}

		public int findNumberRecordsInMATERIEL(string path)
		{
			try
			{
				var db = new SQLiteConnection(path);
				// this counts all records in the database, it can be slow depending on the size of the database
				var count = db.ExecuteScalar<int>("SELECT Count(*) FROM DBMATERIEL");



				return count;
			}
			catch (SQLiteException)
			{
				return -1;
			}
		}

		public int findNumberRecordsInCOURSES(string path)
		{
			try
			{
				var db = new SQLiteConnection(path);
				// this counts all records in the database, it can be slow depending on the size of the database
				var count = db.ExecuteScalar<int>("SELECT Count(*) FROM DBCOURSES");



				return count;
			}
			catch (SQLiteException)
			{
				return -1;
			}
		}

	private string createDatabase(string path)
	{
		try
		{
		var connection = new SQLiteConnection(path);
		connection.CreateTable<User>();
		connection.CreateTable<DBMateriel>();
		connection.CreateTable<soiree>();
		connection.CreateTable<DBCourses>();
		Materiel.Initialization.initialisation();
		return "Database created";
		}
		catch (SQLiteException ex)
		{
		return ex.Message;
		}
	}

	public static string insertUpdateDataUSER(User data, string path)
	{
		try
		{
			var db = new SQLiteConnection(path);
			if (db.Insert(data) != 0)
			db.Update(data);
			return "Single data file inserted or updated";
		}
		catch (SQLiteException ex)
		{
		return ex.Message;
		}
	}

		public static string insertUpdateDataMATERIEL(DBMateriel data, string path)
		{
			try
			{
				var db = new SQLiteConnection(path);
				if (db.Insert(data) != 0)
					db.Update(data);
				return "Single data file inserted or updated";
			}
			catch (SQLiteException ex)
			{
				return ex.Message;
			}
		}

		public static string insertUpdateDataSOIREE(soiree data, string path)
		{
			try
			{
				var db = new SQLiteConnection(path);
				if (db.Insert(data) != 0)
					db.Update(data);
				return "Single data file inserted or updated";
			}
			catch (SQLiteException ex)
			{
				return ex.Message;
			}
		}

		public static string insertUpdateDataCOURSES(DBCourses data, string path)
		{
			try
			{
				var db = new SQLiteConnection(path);
				if (db.Insert(data) != 0)
					db.Update(data);
				return "Single data file inserted or updated";
			}
			catch (SQLiteException ex)
			{
				return ex.Message;
			}
		}
}
}