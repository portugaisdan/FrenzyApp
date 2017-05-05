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
	[Activity (Label = "ListeAlcool")]			
	public class ListeAlcool : Activity
	{


		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView(Resource.Layout.ListeAlcool);

			Button btnBiere = FindViewById<Button>  (Resource.Id.btnBiere);
			Button btnChampagne = FindViewById<Button>  (Resource.Id.btnChamp);
			Button btnGet = FindViewById<Button>  (Resource.Id.btnGet);
			Button btnGin = FindViewById<Button>  (Resource.Id.btnGin);
			Button btnJager = FindViewById<Button>  (Resource.Id.btnJager);
			Button btnMalibu = FindViewById<Button>  (Resource.Id.btnMalibu);
			Button btnMartini = FindViewById<Button>  (Resource.Id.btnMartini);
			Button btnPassoa = FindViewById<Button>  (Resource.Id.btnPassoa);
			Button btnPastis = FindViewById<Button>  (Resource.Id.btnPastis);
			Button btnPorto = FindViewById<Button>  (Resource.Id.btnPorto);
			Button btnRhum = FindViewById<Button>  (Resource.Id.btnRhum);
			Button btnTequila = FindViewById<Button>  (Resource.Id.btnTequila);
			Button btnVinBlanc = FindViewById<Button>  (Resource.Id.btnVB);
			Button btnVinRouge = FindViewById<Button>  (Resource.Id.btnVR);
			Button btnVodka = FindViewById<Button>  (Resource.Id.btnVodka);
			Button btnWhisky = FindViewById<Button>  (Resource.Id.btnWhisky);


			var docsFolder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments); //on spécifie le chemin d'accès
			var pathToDatabase = System.IO.Path.Combine(docsFolder, "db_sqlnet.db");  //on donne un nom à la base de données
			var db = new SQLiteConnection(pathToDatabase);

			string myChoice="";
			string numero = Intent.GetStringExtra ("choix");
			long prixActuel= db.ExecuteScalar<long>("SELECT prix FROM DBCourses WHERE CodeSoiree =? ORDER BY prix DESC",CreerSoiree.codeSoiree);
			long prixSelect;

			btnBiere.Click += (sender, e) => {
				myChoice=btnBiere.Text;
				prixSelect= db.ExecuteScalar<long>("SELECT Prix FROM DBMateriel WHERE Type=?",myChoice);


				switch(numero){
				case "1":
				
					var result = MainActivity.insertUpdateDataCOURSES (new DBCourses {
					CodeSoiree=CreerSoiree.codeSoiree,
					Alcool1=myChoice,
					prix= prixActuel+prixSelect,
					},pathToDatabase );
				break;

				case "2":

					var resultat = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Alcool2=myChoice,
						prix= prixActuel+prixSelect
					},pathToDatabase );
					break;

				case "3":

					var resut = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Alcool3=myChoice,
						prix= prixActuel+prixSelect
					},pathToDatabase );
					break;

				case "4":

					var esult = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Alcool4=myChoice,
						prix= prixActuel+prixSelect
					},pathToDatabase );
					break;

				case "5":

					var resul = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Alcool5=myChoice,
						prix= prixActuel+prixSelect
					},pathToDatabase );
					break;

				}

				var intent = new Intent (this, typeof(Alcool));
				StartActivity (intent);
			};

			btnChampagne.Click += (sender, e) => {
				myChoice=btnChampagne.Text;
				prixSelect= db.ExecuteScalar<long> ("SELECT Prix FROM DBMateriel WHERE Type=?",myChoice);

				switch(numero){
				case "1":

					var result = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Alcool1=myChoice,
						prix= prixActuel+prixSelect
					},pathToDatabase );
					break;

				case "2":

					var resultat = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Alcool2=myChoice,
						prix= prixActuel+prixSelect
					},pathToDatabase );
					break;

				case "3":

					var resut = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Alcool3=myChoice,
						prix= prixActuel+prixSelect
					},pathToDatabase );
					break;

				case "4":

					var esult = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Alcool4=myChoice,
						prix= prixActuel+prixSelect
					},pathToDatabase );
					break;

				case "5":

					var resul = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Alcool5=myChoice,
						prix= prixActuel+prixSelect
					},pathToDatabase );
					break;

				}

				var intent = new Intent (this, typeof(Alcool));
				StartActivity (intent);
			};

			btnGet.Click += (sender, e) => {
				myChoice=btnGet.Text;
				prixSelect= db.ExecuteScalar<long> ("SELECT Prix FROM DBMateriel WHERE Type=?",myChoice);
				switch(numero){
				case "1":

					var result = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Alcool1=myChoice,
						prix= prixActuel+prixSelect
					},pathToDatabase );
					break;

				case "2":

					var resultat = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Alcool2=myChoice,
						prix= prixActuel+prixSelect
					},pathToDatabase );
					break;

				case "3":

					var resut = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Alcool3=myChoice,
						prix= prixActuel+prixSelect
					},pathToDatabase );
					break;

				case "4":

					var esult = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Alcool4=myChoice,
						prix= prixActuel+prixSelect
					},pathToDatabase );
					break;

				case "5":

					var resul = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Alcool5=myChoice,
						prix= prixActuel+prixSelect
					},pathToDatabase );
					break;

				}


				var intent = new Intent (this, typeof(Alcool));
				StartActivity (intent);
			};

			btnGin.Click += (sender, e) => {
				myChoice=btnGin.Text;
				prixSelect= db.ExecuteScalar<long> ("SELECT Prix FROM DBMateriel WHERE Type=?",myChoice);

				switch(numero){
				case "1":

					var result = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Alcool1=myChoice,
						prix= prixActuel+prixSelect
					},pathToDatabase );
					break;

				case "2":

					var resultat = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Alcool2=myChoice,
						prix= prixActuel+prixSelect
					},pathToDatabase );
					break;

				case "3":

					var resut = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Alcool3=myChoice,
						prix= prixActuel+prixSelect
					},pathToDatabase );
					break;

				case "4":

					var esult = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Alcool4=myChoice,
						prix= prixActuel+prixSelect
					},pathToDatabase );
					break;

				case "5":

					var resul = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Alcool5=myChoice,
						prix= prixActuel+prixSelect
					},pathToDatabase );
					break;

				}


				var intent = new Intent (this, typeof(Alcool));
				StartActivity (intent);
			};

			btnJager.Click += (sender, e) => {
				myChoice=btnJager.Text;
				prixSelect= db.ExecuteScalar<long> ("SELECT Prix FROM DBMateriel WHERE Type=?",myChoice);

				switch(numero){
				case "1":

					var result = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Alcool1=myChoice,
						prix= prixActuel+prixSelect
					},pathToDatabase );
					break;

				case "2":

					var resultat = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Alcool2=myChoice,
						prix= prixActuel+prixSelect
					},pathToDatabase );
					break;

				case "3":

					var resut = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Alcool3=myChoice,
						prix= prixActuel+prixSelect
					},pathToDatabase );
					break;

				case "4":

					var esult = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Alcool4=myChoice,
						prix= prixActuel+prixSelect
					},pathToDatabase );
					break;

				case "5":

					var resul = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Alcool5=myChoice,
						prix= prixActuel+prixSelect
					},pathToDatabase );
					break;

				}


				var intent = new Intent (this, typeof(Alcool));
				StartActivity (intent);
			};

			btnMalibu.Click += (sender, e) => {
				myChoice=btnMalibu.Text;
				prixSelect= db.ExecuteScalar<long> ("SELECT Prix FROM DBMateriel WHERE Type=?",myChoice);

				switch(numero){
				case "1":

					var result = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Alcool1=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "2":

					var resultat = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Alcool2=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "3":

					var resut = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Alcool3=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "4":

					var esult = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Alcool4=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "5":

					var resul = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Alcool5=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				}


				var intent = new Intent (this, typeof(Alcool));
				StartActivity (intent);
			};

			btnMartini.Click += (sender, e) => {
				myChoice=btnMartini.Text;
				prixSelect= db.ExecuteScalar<long> ("SELECT Prix FROM DBMateriel WHERE Type=?",myChoice);

				switch(numero){
				case "1":

					var result = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Alcool1=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "2":

					var resultat = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Alcool2=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "3":

					var resut = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Alcool3=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "4":

					var esult = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Alcool4=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "5":

					var resul = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Alcool5=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				}


				var intent = new Intent (this, typeof(Alcool));
				StartActivity (intent);
			};

			btnPassoa.Click += (sender, e) => {
				myChoice=btnPassoa.Text;
				prixSelect= db.ExecuteScalar<long> ("SELECT Prix FROM DBMateriel WHERE Type=?",myChoice);

				switch(numero){
				case "1":

					var result = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Alcool1=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "2":

					var resultat = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Alcool2=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "3":

					var resut = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Alcool3=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "4":

					var esult = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Alcool4=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "5":

					var resul = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Alcool5=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				}


				var intent = new Intent (this, typeof(Alcool));
				StartActivity (intent);
			};

			btnPastis.Click += (sender, e) => {
				myChoice=btnPastis.Text;
				prixSelect= db.ExecuteScalar<long> ("SELECT Prix FROM DBMateriel WHERE Type=?",myChoice);

				switch(numero){
				case "1":

					var result = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Alcool1=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "2":

					var resultat = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Alcool2=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "3":

					var resut = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Alcool3=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "4":

					var esult = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Alcool4=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "5":

					var resul = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Alcool5=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				}


				var intent = new Intent (this, typeof(Alcool));
				StartActivity (intent);
			};

			btnPorto.Click += (sender, e) => {
				myChoice=btnPorto.Text;
				prixSelect= db.ExecuteScalar<long> ("SELECT Prix FROM DBMateriel WHERE Type=?",myChoice);

				switch(numero){
				case "1":

					var result = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Alcool1=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "2":

					var resultat = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Alcool2=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "3":

					var resut = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Alcool3=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "4":

					var esult = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Alcool4=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "5":

					var resul = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Alcool5=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				}


				var intent = new Intent (this, typeof(Alcool));
				StartActivity (intent);
			};

			btnRhum.Click += (sender, e) => {
				myChoice=btnRhum.Text;
				prixSelect= db.ExecuteScalar<long> ("SELECT Prix FROM DBMateriel WHERE Type=?",myChoice);

				switch(numero){
				case "1":

					var result = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Alcool1=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "2":

					var resultat = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Alcool2=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "3":

					var resut = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Alcool3=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "4":

					var esult = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Alcool4=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "5":

					var resul = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Alcool5=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				}


				var intent = new Intent (this, typeof(Alcool));
				StartActivity (intent);
			};

			btnTequila.Click += (sender, e) => {
				myChoice=btnTequila.Text;
				prixSelect= db.ExecuteScalar<long> ("SELECT Prix FROM DBMateriel WHERE Type=?",myChoice);

				switch(numero){
				case "1":

					var result = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Alcool1=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "2":

					var resultat = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Alcool2=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "3":

					var resut = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Alcool3=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "4":

					var esult = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Alcool4=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "5":

					var resul = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Alcool5=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				}


				var intent = new Intent (this, typeof(Alcool));
				StartActivity (intent);
			};

			btnVinBlanc.Click += (sender, e) => {
				myChoice=btnVinBlanc.Text;
				prixSelect= db.ExecuteScalar<long> ("SELECT Prix FROM DBMateriel WHERE Type=?",myChoice);

				switch(numero){
				case "1":

					var result = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Alcool1=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "2":

					var resultat = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Alcool2=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "3":

					var resut = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Alcool3=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "4":

					var esult = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Alcool4=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "5":

					var resul = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Alcool5=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				}


				var intent = new Intent (this, typeof(Alcool));
				StartActivity (intent);
			};

			btnVinRouge.Click += (sender, e) => {
				myChoice=btnVinRouge.Text;
				prixSelect= db.ExecuteScalar<long> ("SELECT Prix FROM DBMateriel WHERE Type=?",myChoice);

				switch(numero){
				case "1":

					var result = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Alcool1=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "2":

					var resultat = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Alcool2=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "3":

					var resut = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Alcool3=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "4":

					var esult = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Alcool4=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "5":

					var resul = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Alcool5=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				}


				var intent = new Intent (this, typeof(Alcool));
				StartActivity (intent);
			};

			btnVodka.Click += (sender, e) => {
				myChoice=btnVodka.Text;
				prixSelect= db.ExecuteScalar<long> ("SELECT Prix FROM DBMateriel WHERE Type=?",myChoice);

				switch(numero){
				case "1":

					var result = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Alcool1=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "2":

					var resultat = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Alcool2=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "3":

					var resut = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Alcool3=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "4":

					var esult = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Alcool4=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "5":

					var resul = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Alcool5=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				}


				var intent = new Intent (this, typeof(Alcool));
				StartActivity (intent);
			};

			btnWhisky.Click += (sender, e) => {
				myChoice=btnWhisky.Text;
				prixSelect= db.ExecuteScalar<long> ("SELECT Prix FROM DBMateriel WHERE Type=?",myChoice);

				switch(numero){
				case "1":

					var result = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Alcool1=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "2":

					var resultat = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Alcool2=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "3":

					var resut = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Alcool3=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "4":

					var esult = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Alcool4=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "5":

					var resul = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Alcool5=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				}


				var intent = new Intent (this, typeof(Alcool));
				StartActivity (intent);
			};

			// Create your application here
		}
	}
}

