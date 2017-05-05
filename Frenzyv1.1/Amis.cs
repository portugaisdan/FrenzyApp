
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Frenzyv1
{
	[Activity (Label = "Amis")]			
	public class Amis : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.Amis);

			Button email = FindViewById<Button> (Resource.Id.mail);
			Button sms = FindViewById<Button> (Resource.Id.sms);

			email.Click += (sender, e) => {
				var mail = new Intent (Android.Content.Intent.ActionSend);


				mail.PutExtra (Android.Content.Intent.ExtraSubject, string.Format("{0}",CreerSoiree.MaSoiree));
				mail.PutExtra (Android.Content.Intent.ExtraText, string.Format("Je t'invite à ma soiree {0}, qui aura lieu le {1}. Réponds moi vite, et toi aussi découvre Frenzy.",CreerSoiree.MaSoiree,calendrier.DateDeMaSoiree));
				mail.SetType ("message/rfc822");
				StartActivity (mail);
			} ;

			sms.Click += (sender, e) => {
				var smsUri = Android.Net.Uri.Parse("smsto:");
				var smsIntent = new Intent (Intent.ActionSendto, smsUri);
				smsIntent.PutExtra ("sms_body", string.Format("Je t'invite à ma soiree {0}, qui aura lieu le {1}. Réponds moi vite, et toi aussi découvre Frenzy.",CreerSoiree.MaSoiree,calendrier.DateDeMaSoiree));  
				StartActivity (smsIntent);

			};

			// Create your application here
		}
	}
}

