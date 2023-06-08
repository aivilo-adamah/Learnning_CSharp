using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;

namespace App { 

    enum Alertlevel 
    {
        Warning = 0,
        Error = 1,
        FatalError = 2
    }

//*******************************************************


   /* interface Itradable
    {
        void SellTomarchant();
        void SellToAutohouse();
        void SellToplayer();
    }*/
 //***************************************************************



  /*  abstract class Consumable
    {
        public abstract void Print();
    }*/

//*********************************************************************





    /*class magicalBook : Consumable, Itradable
    {
        public override void Print()
        {
            void SellTomarchant()
            {

            }
            void SellToAutohouse()
            {

            }
            void SellToplayer()
            {

            }
        }
    }*/












   /* class Waepon : Itradable
    {
        void SellTomarchant()
        {

        }
        void SellToAutohouse()
        {

        }
        void SellToplayer()
        {

        }


    }*/
    class Program
{
    static void Main(string[] args)
    {
        /*Console.WriteLine("hello world");
        //Console.Beep();
        Console.Title = "MyFirstProgramm";
        //Console.Read();*/

        /*bool isLaunched = true;
        isLaunched = false;

        if (!isLaunched) 
        {
            Console.WriteLine("jeu on mon cher !");
        }
        else
        {
            Console.WriteLine("jeu off ");
        }*/

        //int number = 30;
        /*if (number > 0)
            if (number > 10)
                if (number == 14)
                    Console.WriteLine("Bingo cher ami");
                else
                    Console.WriteLine("perdu");*/
        /* switch(number)
         {
             case 30:
                 Console.WriteLine("c'est 30 ouhoooooooo!");
                 break;
             default: Console.WriteLine("erreur veuiez reprendre !");
                 break;
         }*/





        //*****************************************************
        // ternaire 

        /* bool result;
         int age = 20;

         result = (age >= 20) ? true : false; 
         Console.WriteLine(result);*/



        //*******************************************************


        //String word = "oki";

        // for 
        /*int i;
        for(i = 0; i < 10; i++) { 
            Console.WriteLine(word);
        
        }*/

        // foreach

        /* foreach (char c in word)
         {
             Console.WriteLine(c);
         }*/


        //*****************************************************

        // récupérer une saisie 

        /* Console.WriteLine("salut mes bébés ");
         int c = Console.Read();
         Console.WriteLine(c);*/



        //******************************************************

        /*  int nbre = 4;
          int nbre2 = 5;
          sum(nbre, nbre2);*/


        /* Ordinateur monOrdi = new Ordinateur("hp omen", 998833, 2000, "Intel i7;NVIDIA GTX 1080;16GB");
         Ordinateur tonOrdi = new Ordinateur("hp omen", 998833, 2000, "Intel i5;NVIDIA GTX 1080;12GB");
         Console.WriteLine(monOrdi.caracteristiques);
         Console.WriteLine(tonOrdi.caracteristiques);*/


        //*************************************************************

        Console.WriteLine("oliviiiiiiiiaaaa");

            /* int[] arr = new int[] {1,2,3};
             int[] arr2 = {1,2,3};
                 int[,] arr3 = 
                 {

                     {1,2,3},
                     {2,3,4},
                 };
                 Console.WriteLine(arr3[0,0]);   

                 for (int i = 0; i <= arr3.GetUpperBound(0);i++) 
                     for (int j = 0;j <= arr3.GetUpperBound(1);j++)
                         Console.WriteLine(arr3[i,j]);

                 foreach (var el   in arr2)
                     Console.WriteLine(el);


                 int[][] tab = new int[2][];
                 tab[0] = new int[] {1,2, 3};
                 tab[1] = new int[] { 4, 5, 6, 7 };
                 Console.WriteLine(tab[0][0]); */


            /*****************************************************************


            //Alertlevel a = Alertlevel.Warning;
            //Alertlevel b = 2;


                       /* Console.WriteLine(Alertlevel.Warning);
                        foreach(String name in Enum.GetNames(typeof(Alertlevel)))
                        {
                            Console.WriteLine($"{name}");
                            Console.WriteLine(name);
                        }*/
            //********************************************************************


            //pour lire un fichier 

            String filepath = "data/olivia.txt";

            //String allText = File.ReadAllText(filepath);

            //Console.WriteLine(allText);

            /* String [] allLines = File.ReadAllLines(filepath);

             foreach (String line in allLines)
             {
                 Console.WriteLine("> "+line);
             }*/
            

        }
}

    /* static void sum( int x,int y)
     {
         Console.WriteLine(x + y);
     }*/






    // ordianteur 

    /* class Ordinateur 
     {
         public String nom { get; set; }
         public int reference { get; set; }
         public int prix { get; set; }
         public String caracteristiques { get; set; }

         static int nbreOrdis = 0;

         //constructeur 

         public Ordinateur(String nom, int reference, int prix, String caracteristiques)
         {
             this.nom = nom;
             this.reference = reference;
             this.prix = prix;
             this.caracteristiques = caracteristiques;
             nbreOrdis++;

         }
     }*/
}