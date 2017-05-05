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
	[Activity (Label = "invites", Icon = "@drawable/Frenzy")]			
	public class invites : Activity
	{
		public static int nombreInvites=0;
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.Invites);

			CheckBox Invites3 = FindViewById<CheckBox> (Resource.Id.Invites3);
			CheckBox Invites7 = FindViewById<CheckBox> (Resource.Id.Invites7);
			CheckBox Invites13 = FindViewById<CheckBox> (Resource.Id.Invites13);
			CheckBox Invites18 = FindViewById<CheckBox> (Resource.Id.Invites18);
			CheckBox Invites23 = FindViewById<CheckBox> (Resource.Id.Invites23);
			CheckBox Invites28 = FindViewById<CheckBox> (Resource.Id.Invites28);
			CheckBox Invites35 = FindViewById<CheckBox> (Resource.Id.Invites35);
			CheckBox Invites45 = FindViewById<CheckBox> (Resource.Id.Invites45);
			// Create your application here

			Invites3.Click += (object sender, EventArgs e) => {
				nombreInvites= 3;
				var intent = new Intent (this, typeof(CreerSoiree)); 
				StartActivity(intent); 
			} ;

			Invites7.Click += (object sender, EventArgs e) => {
				nombreInvites= 7;
				var intent = new Intent (this, typeof(CreerSoiree)); 
				StartActivity(intent); 
			} ;

			Invites13.Click += (object sender, EventArgs e) => {
				nombreInvites= 13;
				var intent = new Intent (this, typeof(CreerSoiree)); 
				StartActivity(intent); 
			} ;

			Invites18.Click += (object sender, EventArgs e) => {
				nombreInvites= 18;
				var intent = new Intent (this, typeof(CreerSoiree)); 
				StartActivity(intent); 
			} ;

			Invites23.Click += (object sender, EventArgs e) => {
				nombreInvites= 23;
				var intent = new Intent (this, typeof(CreerSoiree)); 
				StartActivity(intent); 
			} ;

			Invites28.Click += (object sender, EventArgs e) => {
				nombreInvites= 28;
				var intent = new Intent (this, typeof(CreerSoiree)); 
				StartActivity(intent); 
			} ;

			Invites35.Click += (object sender, EventArgs e) => {
				nombreInvites= 35;
				var intent = new Intent (this, typeof(CreerSoiree)); 
				StartActivity(intent); 
			} ;

			Invites45.Click += (object sender, EventArgs e) => {
				nombreInvites= 45;
				var intent = new Intent (this, typeof(CreerSoiree)); 
				StartActivity(intent); 
			} ;
		}
	}
}

