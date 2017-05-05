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
	[Activity (Label = "TypeSoiree", Icon = "@drawable/Frenzy")]			
	public class TypeSoiree : Activity
	{
		public static string MyType="";

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.Type_de_soiree);
			ImageButton Barbecue = FindViewById<ImageButton> (Resource.Id.Barbecue);
			ImageButton BigParty = FindViewById<ImageButton> (Resource.Id.BigParty);
			ImageButton Brunch = FindViewById<ImageButton> (Resource.Id.Brunch);
			ImageButton Posee = FindViewById<ImageButton> (Resource.Id.SoireePosee);

		Barbecue.Click += (sender, e) => {

				MyType="Barbecue";
				var intent = new Intent (this, typeof(CreerSoiree)); 
				StartActivity(intent); 
			};

		BigParty.Click += (sender, e) => {

				MyType="BigParty";
				var intent = new Intent (this, typeof(CreerSoiree)); 
				StartActivity(intent); 
			};

		Posee.Click += (sender, e) => {

				MyType="Posee";
				var intent = new Intent (this, typeof(CreerSoiree)); 
				StartActivity(intent); 
			};

		Brunch.Click += (sender, e) => {

				MyType="Brunch";
				var intent = new Intent (this, typeof(CreerSoiree)); 
				StartActivity(intent); 
			};

			// Create your application here
		}
	}
}

