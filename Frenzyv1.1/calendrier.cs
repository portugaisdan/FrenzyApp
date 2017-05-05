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
	[Activity (Label = "calendrier", Icon = "@drawable/Frenzy")]			
	public class calendrier : Activity
	{
		public static DateTime DateDeMaSoiree;
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.Calendrier);
			Button Valider = FindViewById<Button> (Resource.Id.CalendrierValider);
			DatePicker Calendrier = FindViewById<DatePicker> (Resource.Id.SoireeCalendrier);

			Valider.Click += (sender, e) => {
				DateDeMaSoiree = Calendrier.DateTime;
				var intent = new Intent (this, typeof(CreerSoiree)); 
				StartActivity(intent); 

			};


			// Create your application here
		}
	}
}

