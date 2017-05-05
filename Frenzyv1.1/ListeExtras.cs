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
	[Activity (Label = "ListeExtras")]			
	public class ListeExtras : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView(Resource.Layout.extras);

			CheckBox Feu = FindViewById<CheckBox> (Resource.Id.checkBox1);
			CheckBox Charbon = FindViewById<CheckBox> (Resource.Id.checkBox2);
			CheckBox Assiettes = FindViewById<CheckBox> (Resource.Id.checkBox3);
			CheckBox Dents = FindViewById<CheckBox> (Resource.Id.checkBox4);
			CheckBox Verres = FindViewById<CheckBox> (Resource.Id.checkBox5);
			CheckBox Fourchettes = FindViewById<CheckBox> (Resource.Id.checkBox6);
			CheckBox Couteaux = FindViewById<CheckBox> (Resource.Id.checkBox7);

			var docsFolder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments); //on spécifie le chemin d'accès
			var pathToDatabase = System.IO.Path.Combine(docsFolder, "db_sqlnet.db");  //on donne un nom à la base de données
			var db = new SQLiteConnection(pathToDatabase);

			string myChoice="";
			string numero = Intent.GetStringExtra ("choix");
			long prixActuel= db.ExecuteScalar<long>("SELECT prix FROM DBCourses WHERE CodeSoiree =? ORDER BY prix DESC",CreerSoiree.codeSoiree);
			long prixSelect;

			Feu.Click += (sender, e) => {
				myChoice=Feu.Text;
				prixSelect= db.ExecuteScalar<long> ("SELECT Prix FROM DBMateriel WHERE Type=?",myChoice);

				switch(numero){
				case "1":

					var result = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Extras1=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "2":

					var resultat = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Extras2=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "3":

					var resut = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Extras3=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "4":

					var esult = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Extras4=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "5":

					var resul = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Extras5=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				}

				var intent = new Intent (this, typeof(Extras));
				StartActivity (intent);
			};

			Charbon.Click += (sender, e) => {
				myChoice=Charbon.Text;
				prixSelect= db.ExecuteScalar<long> ("SELECT Prix FROM DBMateriel WHERE Type=?",myChoice);

				switch(numero){
				case "1":

					var result = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Extras1=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "2":

					var resultat = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Extras2=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "3":

					var resut = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Extras3=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "4":

					var esult = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Extras4=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "5":

					var resul = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Extras5=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				}

				var intent = new Intent (this, typeof(Extras));
				StartActivity (intent);
			};

			Assiettes.Click += (sender, e) => {
				myChoice=Assiettes.Text;
				prixSelect= db.ExecuteScalar<long> ("SELECT Prix FROM DBMateriel WHERE Type=?",myChoice);

				switch(numero){
				case "1":

					var result = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Extras1=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "2":

					var resultat = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Extras2=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "3":

					var resut = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Extras3=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "4":

					var esult = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Extras4=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "5":

					var resul = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Extras5=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				}

				var intent = new Intent (this, typeof(Extras));
				StartActivity (intent);
			};


			Dents.Click += (sender, e) => {
				myChoice=Dents.Text;
				prixSelect= db.ExecuteScalar<long> ("SELECT Prix FROM DBMateriel WHERE Type=?",myChoice);

				switch(numero){
				case "1":

					var result = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Extras1=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "2":

					var resultat = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Extras2=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "3":

					var resut = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Extras3=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "4":

					var esult = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Extras4=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "5":

					var resul = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Extras5=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				}

				var intent = new Intent (this, typeof(Extras));
				StartActivity (intent);
			};

			Verres.Click += (sender, e) => {
				myChoice=Verres.Text;
				prixSelect= db.ExecuteScalar<long> ("SELECT Prix FROM DBMateriel WHERE Type=?",myChoice);

				switch(numero){
				case "1":

					var result = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Extras1=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "2":

					var resultat = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Extras2=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "3":

					var resut = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Extras3=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "4":

					var esult = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Extras4=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "5":

					var resul = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Extras5=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				}

				var intent = new Intent (this, typeof(Extras));
				StartActivity (intent);
			};

			Fourchettes.Click += (sender, e) => {
				myChoice=Fourchettes.Text;
				prixSelect= db.ExecuteScalar<long> ("SELECT Prix FROM DBMateriel WHERE Type=?",myChoice);

				switch(numero){
				case "1":

					var result = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Extras1=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "2":

					var resultat = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Extras2=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "3":

					var resut = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Extras3=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "4":

					var esult = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Extras4=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "5":

					var resul = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Extras5=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				}

				var intent = new Intent (this, typeof(Extras));
				StartActivity (intent);
			};

			Couteaux.Click += (sender, e) => {
				myChoice=Couteaux.Text;
				prixSelect= db.ExecuteScalar<long> ("SELECT Prix FROM DBMateriel WHERE Type=?",myChoice);

				switch(numero){
				case "1":

					var result = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Extras1=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "2":

					var resultat = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Extras2=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "3":

					var resut = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Extras3=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "4":

					var esult = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Extras4=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "5":

					var resul = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Extras5=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				}

				var intent = new Intent (this, typeof(Extras));
				StartActivity (intent);
			};






			// Create your application here
		}
	}
}

