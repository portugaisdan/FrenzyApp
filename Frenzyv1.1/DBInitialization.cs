using System;
using System.Collections.Generic;
using Android.App;
using Android.Widget;
using Android.OS;
using SQLite;
using Frenzyv1;

namespace Materiel
{
    public class Initialization 
    {
		public static void initialisation()
		{
			initializationAlcool ();
			initializationFoodBrunch ();
			initializationExtras ();
			initializationFoodApero ();
			initializationFoodBarbecue ();
			initializationSoft ();

		}

		public static void initializationAlcool()
        {
			var docsFolder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments); //on spécifie le chemin d'accès
			var pathToDatabase = System.IO.Path.Combine(docsFolder, "db_sqlnet.db");  //on donne un nom à la base de données
			var db = new SQLiteConnection(pathToDatabase);

			var Alcool1=MainActivity.insertUpdateDataMATERIEL(new DBMateriel { Type = "Bières (8x 25cL)", Categorie = "Alcool", Prix = 7 },pathToDatabase);
			var Alcool2=MainActivity.insertUpdateDataMATERIEL(new DBMateriel { Type = "Champagne (75cL)", Categorie = "Alcool", Prix = 30 },pathToDatabase);
			var Alcool3=MainActivity.insertUpdateDataMATERIEL(new DBMateriel { Type = "Get 27 (70cL)", Categorie = "Alcool", Prix = 14 },pathToDatabase);
			var Alcool4=MainActivity.insertUpdateDataMATERIEL(new DBMateriel { Type = "Gin (70cL)", Categorie = "Alcool", Prix = 13 },pathToDatabase);
			var Alcool5=MainActivity.insertUpdateDataMATERIEL(new DBMateriel { Type = "Jägermeister (70cL)", Categorie = "Alcool", Prix = 19 },pathToDatabase);
			var Alcool6=MainActivity.insertUpdateDataMATERIEL(new DBMateriel { Type = "Malibu (70 cL)", Categorie = "Alcool", Prix = 12 },pathToDatabase);
			var Alcool7=MainActivity.insertUpdateDataMATERIEL(new DBMateriel { Type = "Martini (1 L)", Categorie = "Alcool", Prix = 11 },pathToDatabase);
			var Alcool8=MainActivity.insertUpdateDataMATERIEL(new DBMateriel { Type = "Passoa (70 cL)", Categorie = "Alcool", Prix = 9 },pathToDatabase);
			var Alcool9=MainActivity.insertUpdateDataMATERIEL(new DBMateriel { Type = "Pastis (70 cL)", Categorie = "Alcool", Prix = 16 },pathToDatabase);
			var Alcool10=MainActivity.insertUpdateDataMATERIEL(new DBMateriel { Type = "Porto (75 cL)", Categorie = "Alcool", Prix = 9 },pathToDatabase);
			var Alcool11=MainActivity.insertUpdateDataMATERIEL(new DBMateriel { Type = "Rhum (70 cL)", Categorie = "Alcool", Prix = 14 },pathToDatabase);
			var Alcool12= MainActivity.insertUpdateDataMATERIEL(new DBMateriel { Type = "Tequila (70 cL)", Categorie = "Alcool", Prix = 17 },pathToDatabase);
			var Alcool13=MainActivity.insertUpdateDataMATERIEL(new DBMateriel { Type = "Vin blanc (75 cL)", Categorie = "Alcool", Prix = 6 },pathToDatabase);
			var Alcool14=MainActivity.insertUpdateDataMATERIEL(new DBMateriel { Type = "Vin rouge (75 cL)", Categorie = "Alcool", Prix = 10 },pathToDatabase);
			var Alcool15=MainActivity.insertUpdateDataMATERIEL(new DBMateriel { Type = "Vodka (70 cL)", Categorie = "Alcool", Prix = 14 },pathToDatabase);
			var	Alcool16=MainActivity.insertUpdateDataMATERIEL(new DBMateriel { Type = "Whisky (1 L)", Categorie = "Alcool", Prix = 19 },pathToDatabase);
            
        }

		public static void initializationFoodBrunch()
        {
			var docsFolder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments); //on spécifie le chemin d'accès
			var pathToDatabase = System.IO.Path.Combine(docsFolder, "db_sqlnet.db");  //on donne un nom à la base de données
			var db = new SQLiteConnection(pathToDatabase);

			var Brunch1= MainActivity.insertUpdateDataMATERIEL(new DBMateriel { Type = "Bacon (120g)", Categorie = "Brunch", Prix = 2 },pathToDatabase);
			var Brunch2= MainActivity.insertUpdateDataMATERIEL(new DBMateriel { Type = "Beurre (100g)", Categorie = "Brunch", Prix = 1 },pathToDatabase);
			var Brunch3= MainActivity.insertUpdateDataMATERIEL(new DBMateriel { Type = "Brioches (500g)", Categorie = "Brunch", Prix = 2 },pathToDatabase);
			var Brunch4=MainActivity.insertUpdateDataMATERIEL(new DBMateriel { Type = "Café en poudre (250g)", Categorie = "Brunch", Prix = 3 },pathToDatabase);
			var Brunch5=MainActivity.insertUpdateDataMATERIEL(new DBMateriel { Type = "Chocolat en poudre (250g)", Categorie = "Brunch", Prix = 3 },pathToDatabase);
			var Brunch6=MainActivity.insertUpdateDataMATERIEL(new DBMateriel { Type = "Confiture (320g)", Categorie = "Brunch", Prix = 2 },pathToDatabase);
			var Brunch7=MainActivity.insertUpdateDataMATERIEL(new DBMateriel { Type = "Croissants (x16)", Categorie = "Brunch", Prix = 5 },pathToDatabase);
			var Brunch8=MainActivity.insertUpdateDataMATERIEL(new DBMateriel { Type = "Fromage (200g)", Categorie = "Brunch", Prix = 2 },pathToDatabase);
			var Brunch9=MainActivity.insertUpdateDataMATERIEL(new DBMateriel { Type = "Jambon (180g)", Categorie = "Brunch", Prix = 2 },pathToDatabase);
			var Brunch10=MainActivity.insertUpdateDataMATERIEL(new DBMateriel { Type = "Oeufs (x6)", Categorie = "Brunch", Prix = 2 },pathToDatabase);
			var Brunch11=MainActivity.insertUpdateDataMATERIEL(new DBMateriel { Type = "Pains au chocolat (x16)", Categorie = "Brunch", Prix = 4 },pathToDatabase);
			var Brunch12=MainActivity.insertUpdateDataMATERIEL(new DBMateriel { Type = "Pancakes (x10)", Categorie = "Brunch", Prix = 2 },pathToDatabase);
			var Brunch13=MainActivity.insertUpdateDataMATERIEL(new DBMateriel { Type = "Saumon (100g)", Categorie = "Brunch", Prix = 4 },pathToDatabase);
			var Brunch14=MainActivity.insertUpdateDataMATERIEL (new DBMateriel { Type = "Lait (1L)", Categorie = "Brunch", Prix = 1 }, pathToDatabase);
          
        }


		public static void initializationFoodBarbecue()
		{
			var docsFolder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments); //on spécifie le chemin d'accès
			var pathToDatabase = System.IO.Path.Combine(docsFolder, "db_sqlnet.db");  //on donne un nom à la base de données
			var db = new SQLiteConnection(pathToDatabase);

			var Barbecue1= MainActivity.insertUpdateDataMATERIEL(new DBMateriel { Type = "Baguette (x1)", Categorie = "Barbecue", Prix = 1 },pathToDatabase);
			var Barbecue2=MainActivity.insertUpdateDataMATERIEL(new DBMateriel { Type = "Chamallows (300g)", Categorie = "Barbecue", Prix = 2 },pathToDatabase);
			var Barbecue3= MainActivity.insertUpdateDataMATERIEL(new DBMateriel { Type = "Chipolatas (x6)", Categorie = "Barbecue", Prix = 4 },pathToDatabase);
			var Barbecue4=MainActivity.insertUpdateDataMATERIEL(new DBMateriel { Type = "Côtelettes d'agneau (x6)", Categorie = "Barbecue", Prix = 10 },pathToDatabase);
			var Barbecue5=MainActivity.insertUpdateDataMATERIEL(new DBMateriel { Type = "Courgettes (1kg)", Categorie = "Barbecue", Prix = 5 },pathToDatabase);
			var Barecue6=MainActivity.insertUpdateDataMATERIEL(new DBMateriel { Type = "Merguez (x6)", Categorie = "Barbecue", Prix = 4 },pathToDatabase);
			var Barbecue7=MainActivity.insertUpdateDataMATERIEL(new DBMateriel { Type = "Pièces de brochette (300g)", Categorie = "Barbecue", Prix = 5 },pathToDatabase);
			var Barbecue8=MainActivity.insertUpdateDataMATERIEL(new DBMateriel { Type = "Poivron (x1)", Categorie = "Barbecue", Prix = 1 },pathToDatabase);
			var Barbecue9=MainActivity.insertUpdateDataMATERIEL(new DBMateriel { Type = "Pommes de terre (1kg)", Categorie = "Barbecue", Prix = 1 },pathToDatabase);

		}

		public static void initializationFoodApero()
		{
			var docsFolder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments); //on spécifie le chemin d'accès
			var pathToDatabase = System.IO.Path.Combine(docsFolder, "db_sqlnet.db");  //on donne un nom à la base de données
			var db = new SQLiteConnection(pathToDatabase);

			var Apero1= MainActivity.insertUpdateDataMATERIEL(new DBMateriel { Type = "Biscuits apéro (200g)", Categorie = "Apero", Prix = 2 },pathToDatabase);
			var Apero2=MainActivity.insertUpdateDataMATERIEL(new DBMateriel { Type = "Bonbons (200g)", Categorie = "Apero", Prix = 2 },pathToDatabase);
			var Apero3=MainActivity.insertUpdateDataMATERIEL(new DBMateriel { Type = "Cacahuètes (250g)", Categorie = "Apero", Prix = 1 },pathToDatabase);
			var Apero4=MainActivity.insertUpdateDataMATERIEL(new DBMateriel { Type = "Chips (200g)", Categorie = "Apero", Prix = 2 },pathToDatabase);
			var Apero5=MainActivity.insertUpdateDataMATERIEL(new DBMateriel { Type = "Citrons (1kg)", Categorie = "Apero", Prix = 3 },pathToDatabase);
			var Apero6=MainActivity.insertUpdateDataMATERIEL(new DBMateriel { Type = "Glaçons (2kg)", Categorie = "Apero", Prix = 3 },pathToDatabase);
			var Apero7=MainActivity.insertUpdateDataMATERIEL(new DBMateriel { Type = "Olives (200g)", Categorie = "Apero", Prix = 2 },pathToDatabase);
			var Apero8=MainActivity.insertUpdateDataMATERIEL(new DBMateriel { Type = "Saucisson (250g)", Categorie = "Apero", Prix = 5 },pathToDatabase);
			var Apero9=MainActivity.insertUpdateDataMATERIEL(new DBMateriel { Type = "Sucre roux (1kg)", Categorie = "Apero", Prix = 2 },pathToDatabase);

		}

		public static void initializationExtras()
		{
			var docsFolder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments); //on spécifie le chemin d'accès
			var pathToDatabase = System.IO.Path.Combine(docsFolder, "db_sqlnet.db");  //on donne un nom à la base de données
			var db = new SQLiteConnection(pathToDatabase);

			var Extras1= MainActivity.insertUpdateDataMATERIEL(new DBMateriel { Type = "Allume-feu", Categorie = "Extras", Prix = 1 },pathToDatabase);
			var Extras2= MainActivity.insertUpdateDataMATERIEL(new DBMateriel { Type = "Charbon barbecue", Categorie = "Extras", Prix = 20 },pathToDatabase);
			var Extras3=MainActivity.insertUpdateDataMATERIEL(new DBMateriel { Type = "Assiettes platiques (x50)", Categorie = "Extras", Prix = 3 },pathToDatabase);
			var Extras4= MainActivity.insertUpdateDataMATERIEL(new DBMateriel { Type = "Cure-dents (x100)", Categorie = "Extras", Prix = 3 },pathToDatabase);
			var Extras5=MainActivity.insertUpdateDataMATERIEL(new DBMateriel { Type = "Verres plastiques (x50)", Categorie = "Extras", Prix = 2 },pathToDatabase);
			var Extras6=MainActivity.insertUpdateDataMATERIEL(new DBMateriel { Type = "Fourchettes plastiques (x20)", Categorie = "Extras", Prix = 1 },pathToDatabase);
			var Extras7=MainActivity.insertUpdateDataMATERIEL(new DBMateriel { Type = "Couteaux plastiques (x20)", Categorie = "Extras", Prix = 1 },pathToDatabase);

		}

		public static void initializationSoft()
		{
			var docsFolder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments); //on spécifie le chemin d'accès
			var pathToDatabase = System.IO.Path.Combine(docsFolder, "db_sqlnet.db");  //on donne un nom à la base de données
			var db = new SQLiteConnection(pathToDatabase);

			var Soft1=MainActivity.insertUpdateDataMATERIEL(new DBMateriel { Type = "Coca (2L)", Categorie = "Soft", Prix = 2 },pathToDatabase);
			var Soft2=MainActivity.insertUpdateDataMATERIEL(new DBMateriel { Type = "Eau (1L)", Categorie = "Soft", Prix = 0 },pathToDatabase);
			var Soft3=MainActivity.insertUpdateDataMATERIEL(new DBMateriel { Type = "Eau gazeuse (1L)", Categorie = "Soft", Prix = 1 },pathToDatabase);
			var Soft4=MainActivity.insertUpdateDataMATERIEL(new DBMateriel { Type = "Fanta (1,5L)", Categorie = "Soft", Prix = 2 },pathToDatabase);
			var Soft5=MainActivity.insertUpdateDataMATERIEL(new DBMateriel { Type = "Jus de fruits (1L)", Categorie = "Soft", Prix = 2 },pathToDatabase);
			var Soft6=MainActivity.insertUpdateDataMATERIEL(new DBMateriel { Type = "Jus d'orange (1L)", Categorie = "Soft", Prix = 2 },pathToDatabase);
			var Soft7=MainActivity.insertUpdateDataMATERIEL(new DBMateriel { Type = "Jus de pamplemousse (1L)", Categorie = "Soft", Prix = 2 },pathToDatabase);
			var Soft8=MainActivity.insertUpdateDataMATERIEL(new DBMateriel { Type = "Jus de pomme (1L)", Categorie = "Soft", Prix = 2 },pathToDatabase);
			var Soft9=MainActivity.insertUpdateDataMATERIEL(new DBMateriel { Type = "Oasis (2L)", Categorie = "Soft", Prix = 2 },pathToDatabase);
			var Soft10=MainActivity.insertUpdateDataMATERIEL(new DBMateriel { Type = "Orangina (1,5L)", Categorie = "Soft", Prix = 2 },pathToDatabase);
			var Soft11=MainActivity.insertUpdateDataMATERIEL(new DBMateriel { Type = "RedBull (4x 25cL)", Categorie = "Soft", Prix = 5 },pathToDatabase);
			var Soft12=MainActivity.insertUpdateDataMATERIEL(new DBMateriel { Type = "Schweppes agrum (1,5L)", Categorie = "Soft", Prix = 2 },pathToDatabase);
			var Soft13=MainActivity.insertUpdateDataMATERIEL(new DBMateriel { Type = "Schweppes tonic (1,5L)", Categorie = "Soft", Prix = 2 },pathToDatabase);
			var Soft14=MainActivity.insertUpdateDataMATERIEL(new DBMateriel { Type = "Sirop", Categorie = "Soft", Prix = 3 },pathToDatabase);
			var Soft15=MainActivity.insertUpdateDataMATERIEL(new DBMateriel { Type = "Sprite (1,5L)", Categorie = "Soft", Prix = 1 },pathToDatabase);
			}
		}
}