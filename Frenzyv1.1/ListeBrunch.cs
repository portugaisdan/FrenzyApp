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
	[Activity (Label = "ListeBrunch")]			
	public class ListeBrunch : Activity
	{


		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView(Resource.Layout.foodBrunch);

			Button btnBacon = FindViewById<Button>  (Resource.Id.btnBacon);
			Button btnBeurre = FindViewById<Button>  (Resource.Id.btnBeurre);
			Button btnBrioches = FindViewById<Button>  (Resource.Id.btnBrioches);
			Button btnCafe = FindViewById<Button>  (Resource.Id.btnCafe);
			Button btnChocolat = FindViewById<Button>  (Resource.Id.btnChocolat);
			Button btnConfiture = FindViewById<Button>  (Resource.Id.btnConfiture);
			Button btnCroissants = FindViewById<Button>  (Resource.Id.btnCroissants);
			Button btnFromage = FindViewById<Button>  (Resource.Id.btnFromage);
			Button btnJambon = FindViewById<Button>  (Resource.Id.btnJambon);
			Button btnLait = FindViewById<Button>  (Resource.Id.btnLait);
			Button btnOeufs = FindViewById<Button>  (Resource.Id.btnOeufs);
			Button btnPainsChoco = FindViewById<Button>  (Resource.Id.btnPainsChoco);
			Button btnPancakes = FindViewById<Button>  (Resource.Id.btnPancakes);
			Button btnSaumon = FindViewById<Button>  (Resource.Id.btnSaumon);


			var docsFolder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments); //on spécifie le chemin d'accès
			var pathToDatabase = System.IO.Path.Combine(docsFolder, "db_sqlnet.db");  //on donne un nom à la base de données
			var db = new SQLiteConnection(pathToDatabase);

			string myChoice="";
			string numero = Intent.GetStringExtra ("choix");
			long prixActuel= db.ExecuteScalar<long>("SELECT prix FROM DBCourses WHERE CodeSoiree =? ORDER BY prix DESC",CreerSoiree.codeSoiree);
			long prixSelect;


			btnBacon.Click += (sender, e) => {
				myChoice=btnBacon.Text;
				prixSelect= db.ExecuteScalar<long> ("SELECT Prix FROM DBMateriel WHERE Type=?",myChoice);

				switch(numero){
				case "1":

					var result = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Brunch1=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "2":

					var resultat = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Brunch2=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "3":

					var resut = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Brunch3=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "4":

					var esult = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Brunch4=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "5":

					var resul = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Brunch5=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				}

				var intent = new Intent (this, typeof(Brunch));
				StartActivity (intent);
			};

			btnBeurre.Click += (sender, e) => {
				myChoice=btnBeurre.Text;
				prixSelect= db.ExecuteScalar<long> ("SELECT Prix FROM DBMateriel WHERE Type=?",myChoice);

				switch(numero){
				case "1":

					var result = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Brunch1=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "2":

					var resultat = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Brunch2=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "3":

					var resut = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Brunch3=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "4":

					var esult = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Brunch4=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "5":

					var resul = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Brunch5=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				}

				var intent = new Intent (this, typeof(Brunch));
				StartActivity (intent);
			};

			btnBrioches.Click += (sender, e) => {
				myChoice=btnBrioches.Text;
				prixSelect= db.ExecuteScalar<long> ("SELECT Prix FROM DBMateriel WHERE Type=?",myChoice);

				switch(numero){
				case "1":

					var result = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Brunch1=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "2":

					var resultat = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Brunch2=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "3":

					var resut = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Brunch3=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "4":

					var esult = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Brunch4=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "5":

					var resul = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Brunch5=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				}


				var intent = new Intent (this, typeof(Brunch));
				StartActivity (intent);
			};

			btnCafe.Click += (sender, e) => {
				myChoice=btnCafe.Text;
				prixSelect= db.ExecuteScalar<long> ("SELECT Prix FROM DBMateriel WHERE Type=?",myChoice);

				switch(numero){
				case "1":

					var result = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Brunch1=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "2":

					var resultat = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Brunch2=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "3":

					var resut = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Brunch3=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "4":

					var esult = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Brunch4=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "5":

					var resul = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Brunch5=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				}


				var intent = new Intent (this, typeof(Brunch));
				StartActivity (intent);
			};

			btnChocolat.Click += (sender, e) => {
				myChoice=btnChocolat.Text;
				prixSelect= db.ExecuteScalar<long> ("SELECT Prix FROM DBMateriel WHERE Type=?",myChoice);

				switch(numero){
				case "1":

					var result = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Brunch1=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "2":

					var resultat = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Brunch2=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "3":

					var resut = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Brunch3=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "4":

					var esult = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Brunch4=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "5":

					var resul = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Brunch5=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				}


				var intent = new Intent (this, typeof(Brunch));
				StartActivity (intent);
			};

			btnConfiture.Click += (sender, e) => {
				myChoice=btnConfiture.Text;
				prixSelect= db.ExecuteScalar<long> ("SELECT Prix FROM DBMateriel WHERE Type=?",myChoice);

				switch(numero){
				case "1":

					var result = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Brunch1=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "2":

					var resultat = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Brunch2=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "3":

					var resut = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Brunch3=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "4":

					var esult = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Brunch4=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "5":

					var resul = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Brunch5=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				}


				var intent = new Intent (this, typeof(Brunch));
				StartActivity (intent);
			};

			btnCroissants.Click += (sender, e) => {
				myChoice=btnCroissants.Text;
				prixSelect= db.ExecuteScalar<long> ("SELECT Prix FROM DBMateriel WHERE Type=?",myChoice);

				switch(numero){
				case "1":

					var result = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Brunch1=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "2":

					var resultat = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Brunch2=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "3":

					var resut = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Brunch3=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "4":

					var esult = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Brunch4=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "5":

					var resul = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Brunch5=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				}


				var intent = new Intent (this, typeof(Brunch));
				StartActivity (intent);
			};

			btnFromage.Click += (sender, e) => {
				myChoice=btnFromage.Text;
				prixSelect= db.ExecuteScalar<long> ("SELECT Prix FROM DBMateriel WHERE Type=?",myChoice);

				switch(numero){
				case "1":

					var result = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Brunch1=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "2":

					var resultat = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Brunch2=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "3":

					var resut = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Brunch3=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "4":

					var esult = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Brunch4=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "5":

					var resul = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Brunch5=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				}


				var intent = new Intent (this, typeof(Brunch));
				StartActivity (intent);
			};

			btnJambon.Click += (sender, e) => {
				myChoice=btnJambon.Text;
				prixSelect= db.ExecuteScalar<long> ("SELECT Prix FROM DBMateriel WHERE Type=?",myChoice);

				switch(numero){
				case "1":

					var result = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Brunch1=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "2":

					var resultat = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Brunch2=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "3":

					var resut = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Brunch3=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "4":

					var esult = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Brunch4=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "5":

					var resul = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Brunch5=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				}


				var intent = new Intent (this, typeof(Brunch));
				StartActivity (intent);
			};

			btnLait.Click += (sender, e) => {
				myChoice=btnLait.Text;
				prixSelect= db.ExecuteScalar<long> ("SELECT Prix FROM DBMateriel WHERE Type=?",myChoice);

				switch(numero){
				case "1":

					var result = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Brunch1=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "2":

					var resultat = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Brunch2=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "3":

					var resut = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Brunch3=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "4":

					var esult = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Brunch4=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "5":

					var resul = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Brunch5=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				}


				var intent = new Intent (this, typeof(Brunch));
				StartActivity (intent);
			};

			btnOeufs.Click += (sender, e) => {
				myChoice=btnOeufs.Text;
				prixSelect= db.ExecuteScalar<long> ("SELECT Prix FROM DBMateriel WHERE Type=?",myChoice);

				switch(numero){
				case "1":

					var result = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Brunch1=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "2":

					var resultat = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Brunch2=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "3":

					var resut = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Brunch3=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "4":

					var esult = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Brunch4=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "5":

					var resul = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Brunch5=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				}


				var intent = new Intent (this, typeof(Brunch));
				StartActivity (intent);
			};

			btnPainsChoco.Click += (sender, e) => {
				myChoice=btnPainsChoco.Text;
				prixSelect= db.ExecuteScalar<long> ("SELECT Prix FROM DBMateriel WHERE Type=?",myChoice);

				switch(numero){
				case "1":

					var result = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Brunch1=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "2":

					var resultat = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Brunch2=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "3":

					var resut = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Brunch3=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "4":

					var esult = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Brunch4=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "5":

					var resul = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Brunch5=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				}


				var intent = new Intent (this, typeof(Brunch));
				StartActivity (intent);
			};

			btnPancakes.Click += (sender, e) => {
				myChoice=btnPancakes.Text;
				prixSelect= db.ExecuteScalar<long> ("SELECT Prix FROM DBMateriel WHERE Type=?",myChoice);

				switch(numero){
				case "1":

					var result = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Brunch1=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "2":

					var resultat = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Brunch2=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "3":

					var resut = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Brunch3=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "4":

					var esult = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Brunch4=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "5":

					var resul = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Brunch5=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				}


				var intent = new Intent (this, typeof(Brunch));
				StartActivity (intent);
			};

			btnSaumon.Click += (sender, e) => {
				myChoice=btnSaumon.Text;
				prixSelect= db.ExecuteScalar<long> ("SELECT Prix FROM DBMateriel WHERE Type=?",myChoice);

				switch(numero){
				case "1":

					var result = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Brunch1=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "2":

					var resultat = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Brunch2=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "3":

					var resut = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Brunch3=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "4":

					var esult = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Brunch4=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "5":

					var resul = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Brunch5=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				}


				var intent = new Intent (this, typeof(Brunch));
				StartActivity (intent);
			};

		}
	}
}


