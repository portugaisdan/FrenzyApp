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
	[Activity (Label = "ListeBBQ")]			
	public class ListeBBQ : Activity
	{


		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView(Resource.Layout.foodBarbecue);

			Button btnMerguez = FindViewById<Button>  (Resource.Id.btnMerguez);
			Button btnChipolatas = FindViewById<Button>  (Resource.Id.btnChipolatas);
			Button btnPoivron = FindViewById<Button>  (Resource.Id.btnPoivron);
			Button btnPommesDeTerre = FindViewById<Button>  (Resource.Id.btnPommesDeTerre);
			Button btnPiecesBrochette = FindViewById<Button>  (Resource.Id.btnPiecesBrochette);
			Button btnBaguette = FindViewById<Button>  (Resource.Id.btnBaguette);
			Button btnCotelettes = FindViewById<Button>  (Resource.Id.btnCotelettes);
			Button btnChamallows = FindViewById<Button>  (Resource.Id.btnChamallows);
			Button btnCourgettes = FindViewById<Button>  (Resource.Id.btnCourgettes);


			var docsFolder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments); //on spécifie le chemin d'accès
			var pathToDatabase = System.IO.Path.Combine(docsFolder, "db_sqlnet.db");  //on donne un nom à la base de données
			var db = new SQLiteConnection(pathToDatabase);

			string myChoice="";
			string numero = Intent.GetStringExtra ("choix");
			long prixActuel= db.ExecuteScalar<long>("SELECT prix FROM DBCourses WHERE CodeSoiree =? ORDER BY prix DESC",CreerSoiree.codeSoiree);
			long prixSelect;


			btnMerguez.Click += (sender, e) => {
				myChoice=btnMerguez.Text;
				prixSelect= db.ExecuteScalar<long> ("SELECT Prix FROM DBMateriel WHERE Type=?",myChoice);
				switch(numero){
				case "1":

					var result = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Food1=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "2":

					var resultat = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Food2=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "3":

					var resut = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Food3=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "4":

					var esult = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Food4=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "5":

					var resul = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Food5=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				}

				var intent = new Intent (this, typeof(Barbecue));
				StartActivity (intent);
			};

			btnChipolatas.Click += (sender, e) => {
				myChoice=btnChipolatas.Text;
				prixSelect= db.ExecuteScalar<long> ("SELECT Prix FROM DBMateriel WHERE Type=?",myChoice);

				switch(numero){
				case "1":

					var result = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Food1=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "2":

					var resultat = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Food2=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "3":

					var resut = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Food3=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "4":

					var esult = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Food4=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "5":

					var resul = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Food5=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				}

				var intent = new Intent (this, typeof(Barbecue));
				StartActivity (intent);
			};

			btnPoivron.Click += (sender, e) => {
				myChoice=btnPoivron.Text;
				prixSelect= db.ExecuteScalar<long> ("SELECT Prix FROM DBMateriel WHERE Type=?",myChoice);

				switch(numero){
				case "1":

					var result = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Food1=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "2":

					var resultat = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Food2=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "3":

					var resut = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Food3=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "4":

					var esult = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Food4=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "5":

					var resul = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Food5=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				}


				var intent = new Intent (this, typeof(Barbecue));
				StartActivity (intent);
			};

			btnPommesDeTerre.Click += (sender, e) => {
				myChoice=btnPommesDeTerre.Text;
				prixSelect= db.ExecuteScalar<long> ("SELECT Prix FROM DBMateriel WHERE Type=?",myChoice);

				switch(numero){
				case "1":

					var result = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Food1=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "2":

					var resultat = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Food2=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "3":

					var resut = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Food3=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "4":

					var esult = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Food4=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "5":

					var resul = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Food5=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				}


				var intent = new Intent (this, typeof(Barbecue));
				StartActivity (intent);
			};

			btnPiecesBrochette.Click += (sender, e) => {
				myChoice=btnPiecesBrochette.Text;
				prixSelect= db.ExecuteScalar<long> ("SELECT Prix FROM DBMateriel WHERE Type=?",myChoice);

				switch(numero){
				case "1":

					var result = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Food1=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "2":

					var resultat = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Food2=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "3":

					var resut = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Food3=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "4":

					var esult = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Food4=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "5":

					var resul = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Food5=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				}


				var intent = new Intent (this, typeof(Barbecue));
				StartActivity (intent);
			};

			btnBaguette.Click += (sender, e) => {
				myChoice=btnBaguette.Text;
				prixSelect= db.ExecuteScalar<long> ("SELECT Prix FROM DBMateriel WHERE Type=?",myChoice);

				switch(numero){
				case "1":

					var result = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Food1=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "2":

					var resultat = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Food2=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "3":

					var resut = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Food3=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "4":

					var esult = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Food4=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "5":

					var resul = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Food5=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				}


				var intent = new Intent (this, typeof(Barbecue));
				StartActivity (intent);
			};

			btnCotelettes.Click += (sender, e) => {
				myChoice=btnCotelettes.Text;
				prixSelect= db.ExecuteScalar<long> ("SELECT Prix FROM DBMateriel WHERE Type=?",myChoice);

				switch(numero){
				case "1":

					var result = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Food1=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "2":

					var resultat = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Food2=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "3":

					var resut = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Food3=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "4":

					var esult = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Food4=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "5":

					var resul = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Food5=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				}


				var intent = new Intent (this, typeof(Barbecue));
				StartActivity (intent);
			};

			btnChamallows.Click += (sender, e) => {
				myChoice=btnChamallows.Text;
				prixSelect= db.ExecuteScalar<long> ("SELECT Prix FROM DBMateriel WHERE Type=?",myChoice);

				switch(numero){
				case "1":

					var result = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Food1=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "2":

					var resultat = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Food2=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "3":

					var resut = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Food3=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "4":

					var esult = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Food4=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "5":

					var resul = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Food5=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				}


				var intent = new Intent (this, typeof(Barbecue));
				StartActivity (intent);
			};

			btnCourgettes.Click += (sender, e) => {
				myChoice=btnCourgettes.Text;
				prixSelect= db.ExecuteScalar<long> ("SELECT Prix FROM DBMateriel WHERE Type=?",myChoice);

				switch(numero){
				case "1":

					var result = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Food1=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "2":

					var resultat = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Food2=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "3":

					var resut = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Food3=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "4":

					var esult = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Food4=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "5":

					var resul = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Food5=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				}
					
				var intent = new Intent (this, typeof(Barbecue));
				StartActivity (intent);
			};
				
		}
	}
}

