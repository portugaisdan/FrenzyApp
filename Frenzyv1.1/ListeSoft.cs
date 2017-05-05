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
	[Activity (Label = "ListeSoft")]			
	public class ListeSoft : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView(Resource.Layout.Soft);

			Button coca = FindViewById<Button> (Resource.Id.btnCoca);
			Button eau = FindViewById<Button> (Resource.Id.btnEau);
			Button eauGazeuse = FindViewById<Button> (Resource.Id.btnEauGazeuse);
			Button fanta = FindViewById<Button> (Resource.Id.btnFanta);
			Button jusFruit = FindViewById<Button> (Resource.Id.btnJusDeFruits);
			Button jusOrange = FindViewById<Button> (Resource.Id.btnJusDorange);
			Button jusPomme = FindViewById<Button> (Resource.Id.btnJusDePomme);
			Button jusPamplemousse = FindViewById<Button> (Resource.Id.btnJusDePamp);
			Button oasis = FindViewById<Button> (Resource.Id.btnOasis);
			Button orangina = FindViewById<Button> (Resource.Id.btnOrangina);
			Button redBull = FindViewById<Button> (Resource.Id.btnRedBull);
			Button agrumes = FindViewById<Button> (Resource.Id.btnSchwAgrum);
			Button tonic = FindViewById<Button> (Resource.Id.btnSchwTonic);
			Button sirop = FindViewById<Button> (Resource.Id.btnSirop);
			Button sprite = FindViewById<Button> (Resource.Id.btnSprite);

			var docsFolder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments); //on spécifie le chemin d'accès
			var pathToDatabase = System.IO.Path.Combine(docsFolder, "db_sqlnet.db");  //on donne un nom à la base de données
			var db = new SQLiteConnection(pathToDatabase);

			string myChoice="";
			string numero = Intent.GetStringExtra ("choix");
			long prixActuel= db.ExecuteScalar<long>("SELECT prix FROM DBCourses WHERE CodeSoiree =? ORDER BY prix DESC",CreerSoiree.codeSoiree);
			long prixSelect;


			coca.Click += (sender, e) => {
				myChoice=coca.Text;
				prixSelect= db.ExecuteScalar<long> ("SELECT Prix FROM DBMateriel WHERE Type=?",myChoice);

				switch(numero){
				case "1":

					var result = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Soft1=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "2":

					var resultat = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Soft2=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "3":

					var resut = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Soft3=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "4":

					var esult = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Soft4=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "5":

					var resul = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Soft5=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				}

				var intent = new Intent (this, typeof(Soft));
				StartActivity (intent);
			};


			eau.Click += (sender, e) => {
				myChoice=eau.Text;
				prixSelect= db.ExecuteScalar<long> ("SELECT Prix FROM DBMateriel WHERE Type=?",myChoice);

				switch(numero){
				case "1":

					var result = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Soft1=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "2":

					var resultat = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Soft2=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "3":

					var resut = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Soft3=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "4":

					var esult = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Soft4=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "5":

					var resul = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Soft5=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				}

				var intent = new Intent (this, typeof(Soft));
				StartActivity (intent);
			};


			eauGazeuse.Click += (sender, e) => {
				myChoice=eauGazeuse.Text;
				prixSelect= db.ExecuteScalar<long> ("SELECT Prix FROM DBMateriel WHERE Type=?",myChoice);

				switch(numero){
				case "1":

					var result = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Soft1=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "2":

					var resultat = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Soft2=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "3":

					var resut = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Soft3=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "4":

					var esult = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Soft4=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "5":

					var resul = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Soft5=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				}

				var intent = new Intent (this, typeof(Soft));
				StartActivity (intent);
			};

			fanta.Click += (sender, e) => {
				myChoice=fanta.Text;
				prixSelect= db.ExecuteScalar<long> ("SELECT Prix FROM DBMateriel WHERE Type=?",myChoice);

				switch(numero){
				case "1":

					var result = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Soft1=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "2":

					var resultat = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Soft2=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "3":

					var resut = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Soft3=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "4":

					var esult = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Soft4=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "5":

					var resul = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Soft5=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				}

				var intent = new Intent (this, typeof(Soft));
				StartActivity (intent);
			};


			jusFruit.Click += (sender, e) => {
				myChoice=jusFruit.Text;
				prixSelect= db.ExecuteScalar<long> ("SELECT Prix FROM DBMateriel WHERE Type=?",myChoice);

				switch(numero){
				case "1":

					var result = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Soft1=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "2":

					var resultat = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Soft2=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "3":

					var resut = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Soft3=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "4":

					var esult = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Soft4=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "5":

					var resul = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Soft5=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				}

				var intent = new Intent (this, typeof(Soft));
				StartActivity (intent);
			};


			jusOrange.Click += (sender, e) => {
				myChoice=jusOrange.Text;
				prixSelect= db.ExecuteScalar<long> ("SELECT Prix FROM DBMateriel WHERE Type=?",myChoice);

				switch(numero){
				case "1":

					var result = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Soft1=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "2":

					var resultat = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Soft2=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "3":

					var resut = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Soft3=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "4":

					var esult = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Soft4=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "5":

					var resul = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Soft5=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				}

				var intent = new Intent (this, typeof(Soft));
				StartActivity (intent);
			};


			jusPamplemousse.Click += (sender, e) => {
				myChoice=jusPamplemousse.Text;
				prixSelect= db.ExecuteScalar<long> ("SELECT Prix FROM DBMateriel WHERE Type=?",myChoice);

				switch(numero){
				case "1":

					var result = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Soft1=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "2":

					var resultat = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Soft2=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "3":

					var resut = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Soft3=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "4":

					var esult = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Soft4=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "5":

					var resul = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Soft5=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				}

				var intent = new Intent (this, typeof(Soft));
				StartActivity (intent);
			};


			jusPomme.Click += (sender, e) => {
				myChoice=jusPomme.Text;
				prixSelect= db.ExecuteScalar<long> ("SELECT Prix FROM DBMateriel WHERE Type=?",myChoice);

				switch(numero){
				case "1":

					var result = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Soft1=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "2":

					var resultat = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Soft2=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "3":

					var resut = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Soft3=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "4":

					var esult = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Soft4=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "5":

					var resul = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Soft5=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				}

				var intent = new Intent (this, typeof(Soft));
				StartActivity (intent);
			};

			oasis.Click += (sender, e) => {
				myChoice=oasis.Text;
				prixSelect= db.ExecuteScalar<long> ("SELECT Prix FROM DBMateriel WHERE Type=?",myChoice);

				switch(numero){
				case "1":

					var result = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Soft1=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "2":

					var resultat = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Soft2=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "3":

					var resut = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Soft3=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "4":

					var esult = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Soft4=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "5":

					var resul = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Soft5=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				}

				var intent = new Intent (this, typeof(Soft));
				StartActivity (intent);
			};

			orangina.Click += (sender, e) => {
				myChoice=orangina.Text;
				prixSelect= db.ExecuteScalar<long> ("SELECT Prix FROM DBMateriel WHERE Type=?",myChoice);

				switch(numero){
				case "1":

					var result = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Soft1=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "2":

					var resultat = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Soft2=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "3":

					var resut = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Soft3=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "4":

					var esult = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Soft4=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "5":

					var resul = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Soft5=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				}

				var intent = new Intent (this, typeof(Soft));
				StartActivity (intent);
			};

			redBull.Click += (sender, e) => {
				myChoice=redBull.Text;
				prixSelect= db.ExecuteScalar<long> ("SELECT Prix FROM DBMateriel WHERE Type=?",myChoice);

				switch(numero){
				case "1":

					var result = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Soft1=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "2":

					var resultat = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Soft2=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "3":

					var resut = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Soft3=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "4":

					var esult = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Soft4=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "5":

					var resul = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Soft5=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				}

				var intent = new Intent (this, typeof(Soft));
				StartActivity (intent);
			};


			agrumes.Click += (sender, e) => {
				myChoice=agrumes.Text;
				prixSelect= db.ExecuteScalar<long> ("SELECT Prix FROM DBMateriel WHERE Type=?",myChoice);

				switch(numero){
				case "1":

					var result = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Soft1=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "2":

					var resultat = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Soft2=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "3":

					var resut = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Soft3=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "4":

					var esult = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Soft4=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "5":

					var resul = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Soft5=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				}

				var intent = new Intent (this, typeof(Soft));
				StartActivity (intent);
			};


			tonic.Click += (sender, e) => {
				myChoice=tonic.Text;
				prixSelect= db.ExecuteScalar<long> ("SELECT Prix FROM DBMateriel WHERE Type=?",myChoice);

				switch(numero){
				case "1":

					var result = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Soft1=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "2":

					var resultat = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Soft2=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "3":

					var resut = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Soft3=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "4":

					var esult = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Soft4=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "5":

					var resul = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Soft5=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				}

				var intent = new Intent (this, typeof(Soft));
				StartActivity (intent);
			};


			sirop.Click += (sender, e) => {
				myChoice=sirop.Text;
				prixSelect= db.ExecuteScalar<long> ("SELECT Prix FROM DBMateriel WHERE Type=?",myChoice);

				switch(numero){
				case "1":

					var result = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Soft1=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "2":

					var resultat = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Soft2=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "3":

					var resut = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Soft3=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "4":

					var esult = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Soft4=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "5":

					var resul = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Soft5=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				}

				var intent = new Intent (this, typeof(Soft));
				StartActivity (intent);
			};

			sprite.Click += (sender, e) => {
				myChoice=sprite.Text;
				prixSelect= db.ExecuteScalar<long> ("SELECT Prix FROM DBMateriel WHERE Type=?",myChoice);

				switch(numero){
				case "1":

					var result = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Soft1=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "2":

					var resultat = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Soft2=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "3":

					var resut = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Soft3=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "4":

					var esult = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Soft4=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				case "5":

					var resul = MainActivity.insertUpdateDataCOURSES (new DBCourses {
						CodeSoiree=CreerSoiree.codeSoiree,
						Soft5=myChoice,
						prix= prixActuel+prixSelect,
					},pathToDatabase );
					break;

				}

				var intent = new Intent (this, typeof(Soft));
				StartActivity (intent);
			};

			// Create your application here
		}
	}
}

