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
	[Activity (Label = "Alcool")]			
	public class Alcool : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			//Ecran "choix"
			SetContentView(Resource.Layout.Choix);

			//Declaration de nos variable
			Button Sel1 = FindViewById<Button> (Resource.Id.Sel1); //Bouton "selectionner votre choix"
			Button Sel2 = FindViewById<Button> (Resource.Id.Sel2); //Bouton "selectionner votre choix"
			Button Sel3 = FindViewById<Button> (Resource.Id.Sel3); //Bouton "selectionner votre choix"
			Button Sel4 = FindViewById<Button> (Resource.Id.Sel4); //Bouton "selectionner votre choix"
			Button Sel5 = FindViewById<Button> (Resource.Id.Sel5); //Bouton "selectionner votre choix"
			Button valider = FindViewById<Button> (Resource.Id.MonChoix); //Bouton "valider mon choix"
			TextView FirstChoice = FindViewById<TextView> (Resource.Id.textView1); //TextView correspondant et affichant à l'alcool choisit
			TextView SecondChoice = FindViewById<TextView> (Resource.Id.textView2); //TextView correspondant et affichant à l'alcool choisit
			TextView ThirdChoice = FindViewById<TextView> (Resource.Id.textView3); //TextView correspondant et affichant à l'alcool choisit
			TextView FourthChoice = FindViewById<TextView> (Resource.Id.textView4); //TextView correspondant et affichant à l'alcool choisit
			TextView FifthChoice = FindViewById<TextView> (Resource.Id.textView5); //TextView correspondant et affichant à l'alcool choisit




			var docsFolder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments); //on spécifie le chemin d'accès
			var pathToDatabase = System.IO.Path.Combine(docsFolder, "db_sqlnet.db");  //on donne un nom à la base de données
			var db = new SQLiteConnection(pathToDatabase);

		//Selection dans notre base de donnée l'alcool choisit, trié par ordre decroissant.
		//5 choix de selection possible, si plus géré en fonction du nombre de personne
			string choix1=db.ExecuteScalar<string> ("SELECT Alcool1 FROM DBCourses WHERE CodeSoiree = ? ORDER BY Alcool1 DESC", CreerSoiree.codeSoiree);
			string choix2=db.ExecuteScalar<string> ("SELECT Alcool2 FROM DBCourses WHERE CodeSoiree = ? ORDER BY Alcool2 DESC", CreerSoiree.codeSoiree);
			string choix3=db.ExecuteScalar<string> ("SELECT Alcool3 FROM DBCourses WHERE CodeSoiree = ? ORDER BY Alcool3 DESC", CreerSoiree.codeSoiree);
			string choix4=db.ExecuteScalar<string> ("SELECT Alcool4 FROM DBCourses WHERE CodeSoiree = ? ORDER BY Alcool4 DESC", CreerSoiree.codeSoiree);
			string choix5=db.ExecuteScalar<string> ("SELECT Alcool5 FROM DBCourses WHERE CodeSoiree = ? ORDER BY Alcool5 DESC", CreerSoiree.codeSoiree);
			//Affichage dans le TextView de l'alcool choisit (on recupere le nom de l'element choisit au préalable)
			if (choix1 != null)
				FirstChoice.Text = choix1;
			
			if (choix2 != null)
				SecondChoice.Text = choix2;

			if (choix3 != null)
				ThirdChoice.Text = choix3;

			if (choix4 != null)
				FourthChoice.Text = choix4;

			if (choix5 != null)
				FifthChoice.Text = choix5;

						
			//Si bouton Sel1 ("veuillez selectionner votre choix"), redirection vers listeAlcool
			Sel1.Click += (sender, e) => {
				var intent = new Intent (this, typeof(ListeAlcool));
				intent.PutExtra("choix","1");
				StartActivity (intent);
			} ;
			//Si bouton Sel2 ("veuillez selectionner votre choix"), redirection vers listeAlcool
			Sel2.Click += (sender, e) => {
				var intent = new Intent (this, typeof(ListeAlcool));
				intent.PutExtra("choix","2");
				StartActivity (intent);	

			} ;
			//Si bouton Sel3 ("veuillez selectionner votre choix"), redirection vers listeAlcool
			Sel3.Click += (sender, e) => {
				var intent = new Intent (this, typeof(ListeAlcool));
				intent.PutExtra("choix","3");
				StartActivity (intent);
			} ;
			//Si bouton Sel ("veuillez selectionner votre choix"), redirection vers listeAlcool
			Sel4.Click += (sender, e) => {
				var intent = new Intent (this, typeof(ListeAlcool));
				intent.PutExtra("choix","4");
				StartActivity (intent);
			} ;
			//Si bouton Sel5 ("veuillez selectionner votre choix"), redirection vers listeAlcool
			Sel5.Click += (sender, e) => {
				var intent = new Intent (this, typeof(ListeAlcool));
				intent.PutExtra("choix","5");
				StartActivity (intent);
			};
			//On clic sur valider pour valider notre choix, et revenir sur l'écran ConfigSoirée
			valider.Click += (sender, e) => {
				var intent = new Intent (this, typeof(ConfigSoiree));
				StartActivity (intent);
			} ;

		}
	}
}

