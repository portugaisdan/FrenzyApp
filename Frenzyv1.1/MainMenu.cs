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
	[Activity (Label = "MainMenu", Icon = "@drawable/Frenzy")]			
	public class MainMenu : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.Menu_Principal);

			Button Create = FindViewById<Button> (Resource.Id.Create);
			Button Soirees = FindViewById<Button> (Resource.Id.Soirees);
			Button Profil = FindViewById<Button> (Resource.Id.Profil);

			Profil.Click += (object sender, EventArgs e) => {
				var intent = new Intent (this, typeof(createUser));
				StartActivity (intent);
			};

			Create.Click += (object sender, EventArgs e) => {
				var intent = new Intent (this, typeof(CreerSoiree));
				StartActivity (intent);
			};

			Soirees.Click += (object sender, EventArgs e) => {
				var intent = new Intent (this, typeof(MaSoiree));
				StartActivity (intent);
			};


				


			// Create your application here
		}
	}
}

