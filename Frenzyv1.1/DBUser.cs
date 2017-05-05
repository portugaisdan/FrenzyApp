using System;
using System.Collections.Generic;
using Android.App;
using Android.Widget;
using Android.OS;
using SQLite;

namespace Frenzyv1
{
    public class User
    {
        [PrimaryKey, AutoIncrement]

		public int UserID { get; set; }   // Clé primaire qui n'est pas utilisée (bluff pour gérer l'auto incrément)

		public string Mail { get; set; }   //Clé primaire, toujours vérifier qu'il n'y en a pas 2 pareils, sinon: update

        public string Prenom { get; set; }

        public string Nom { get; set; }

        public string Majeur { get; set; }

        public string Ville { get; set; }

        public string Password { get; set; }
    }

}

