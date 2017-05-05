
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Frenzyv1
{
	[Activity (Label = "menu_principal")]			
	public class menu_principal : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			// Create your application here
			var phoneNumbers = Intent.Extras.GetStringArrayList("phone_numbers") ?? new string[0];
			this.ListAdapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, phoneNumbers);

			Button callHistoryButton = FindViewById<Button> (Resource.Id.CallHistoryButton);
			callHistoryButton.Click += (sender, e) =>
			{
				var intent = new Intent(this, typeof(CallHistoryActivity));
				intent.PutStringArrayListExtra("phone_numbers", phoneNumbers);
				StartActivity(intent);
			};

			callDialog.SetNeutralButton("Call", delegate
				{
					// add dialed number to list of called numbers.
					phoneNumbers.Add(translatedNumber);
					// enable the Call History button
					callHistoryButton.Enabled = true;
					// Create intent to dial phone
					var callIntent = new Intent(Intent.ActionCall);
					callIntent.SetData(Android.Net.Uri.Parse("tel:" + translatedNumber));
					StartActivity(callIntent);
				});
		}
	}
}

