using System;
using System.Diagnostics;

namespace prjConCsArrays
{
    public static class ExoArrays
    {
        public static void grades()
        {
            Int16 students;
            Single avg, best = -1, worst = 101, sum = 0;
            Single[] tabGrades = new Single[26];

            Console.WriteLine("\tLASALLE COLLEGE");
            Console.WriteLine("\t- - - - - - - -");
            Console.Write("Enter the number of students: ");
            students = Convert.ToInt16(Console.ReadLine());
            for (Int16 i = 1; i < students; i++)
            {
                do
                {
                    Console.Write("\tEnter grade " + i + ": ");
                    tabGrades[i] = Convert.ToSingle(Console.ReadLine());
                } while (tabGrades[i] < 0 || tabGrades[i] > 100);
                sum = sum + tabGrades[i];
                if (tabGrades[i] > best)
                {
                    best = tabGrades[i];
                }
                if (tabGrades[i] < worst)
                {
                    worst = tabGrades[i];
                }
            }


            Console.WriteLine("Here are the grades");
            Console.WriteLine("#\tGrades");
            for (Int16 i = 1; i <= students; i++)
            {
                Console.WriteLine(i + "\t" + tabGrades[i]);
            }
            avg = sum / students;
            Console.WriteLine("The class average is " + avg);
            Console.WriteLine("The best grade is " + best);
            Console.WriteLine("The worst grade is " + worst);
        }

        public static void gradereader()
        {
            Int16 etud;
            Single moyenne, meilleure = -1, pire = 101, sum = 0;
            Single[] tabNotes = new Single[25];

            Console.WriteLine("\tINSTITUT COLLEGE");
            Console.WriteLine("\t- - - - - - - - -");
            Console.Write("Entrez le nombre etudiants: ");
            etud = Convert.ToInt16(Console.ReadLine());
            while (!(etud >= 2 && etud <= 25))
            {
                Console.Write("Entrez le nombre etudiants (2 a 25): ");
                etud = Convert.ToInt16(Console.ReadLine());
            }

            meilleure = tabNotes[0];
            pire = tabNotes[0];
            for (Int16 i = 0; i < etud; i++)
            {
                do
                {
                    Console.Write("Entrez note " + (i + 1) + ": ");
                    tabNotes[i] = Convert.ToSingle(Console.ReadLine());
                } while (tabNotes[i] < 0 || tabNotes[i] > 100);
                sum = sum + tabNotes[i];
                //if (tabNotes[i] > meilleure)
                //{
                //    meilleure = tabNotes[i];
                //}
                //if (tabNotes[i] < pire)
                //{
                //    pire = tabNotes[i];
                //}

                meilleure = (tabNotes[i] > meilleure) ? tabNotes[i] : meilleure;
                pire = (tabNotes[i] < pire) ? tabNotes[i] : pire;
            }
            Console.WriteLine("");
            Console.WriteLine("Merci, Voila les informations de la class");
            Console.WriteLine("#\tNotes");
            for (Int16 i = 1; i < etud; i++)
            {
                Console.WriteLine((i + 1) + "\t" + tabNotes[i]);
            }
            moyenne = sum / etud;
            Console.WriteLine("");
            Console.WriteLine("La Moyenne de la class est " + moyenne);
            Console.WriteLine("La meilleure note est " + meilleure);
            Console.WriteLine("La pire note est " + pire);

        }

        public static void StudentGrades()
        {
            Int16 stud;
            Single avg, best = -1, worst = 101, sum = 0;
            string nbest = "", nworst = "", firstbest = "", secondbest = "", firstworst = "", secondworst = "";
            Single[] tabGrades = new Single[26];
            string[] tabNames = new string[26];

            Console.WriteLine("\tINSTITUT COLLEGE");
            Console.WriteLine("\t- - - - - - - - -");
            Console.Write("Enter the number of students: ");
            stud = Convert.ToInt16(Console.ReadLine());

            while (stud < 2 || stud > 25)
            {
                Console.Write("Enter the number of students (2-25): ");
                stud = Convert.ToInt16(Console.ReadLine());
            }
            Console.WriteLine("");
            for (Int16 i = 1; i <= stud; i++)
            {
                Console.WriteLine("Student " + i);

                Console.Write("\tName: ");
                tabNames[i] = Console.ReadLine();
                do
                {
                    Console.Write("\tNote: ");
                    tabGrades[i] = Convert.ToSingle(Console.ReadLine());
                } while (!(tabGrades[i] >= 0 && tabGrades[i] <= 100));
                sum += tabGrades[i];
                //overall = tabGrades[i] + tabNames[i];
                if (tabGrades[i] > best)
                {
                    best = tabGrades[i];
                    nbest = tabNames[i];
                }
                if (tabGrades[i] == best)
                {
                    firstbest = tabNames[i] + "\t" + tabGrades[i];
                    secondbest = Convert.ToString(nbest) + "\t" + Convert.ToString(best) + "\n";
                }
                if (tabGrades[i] < worst)
                {
                    worst = tabGrades[i];
                    nworst = tabNames[i];
                }
                if (tabGrades[i] == worst)
                {
                    firstworst = tabNames[i] + "\t" + tabGrades[i];
                    secondworst = Convert.ToString(nworst) + "\t" + Convert.ToString(worst) + "\n";
                }
                else
                {
                    secondworst = "";
                }

            }
            Console.WriteLine("");
            Console.WriteLine("Thanks, The class information");
            Console.WriteLine("");
            Console.WriteLine("Students\tGrades");
            for (Int16 i = 1; i <= stud; i++)
            {
                Console.WriteLine(tabNames[i] + "\t\t" + tabGrades[i]);
            }
            avg = sum / stud;
            Console.WriteLine("");
            Console.WriteLine("The class average is " + avg);
            Console.WriteLine("");
            Console.WriteLine("The best students");

            //foreach (var name in nbest)
            //{
            //    Console.WriteLine(nbest);
            //}
            Console.Write(firstbest + "\n" + secondbest);
            Console.WriteLine("");
            Console.WriteLine("The worst students");
            Console.WriteLine(firstworst + "\n" + secondworst);
        }

        //public static void GradesAge()
        //{
        //    Int16 stud, yob, age;
        //    Single avg, sum=0, best=-1, worst=101;
        //    Single[] tabGrades = new Single[26];
        //    string[] tabNames = new string[26];

        //    Console.WriteLine("\tLASALLE COLLEGE");
        //    Console.WriteLine("\t- - - - - - - -");
        //    Console.Write("Enter the number of students: ");
        //    stud = Convert.ToInt16(Console.ReadLine());

        //    while (stud < 2 || stud > 25)
        //    {
        //        Console.Write("Enter the number of students (2-25): ");
        //        stud = Convert.ToInt16(Console.ReadLine());
        //    }
        //    Console.WriteLine("");
        //    for (Int16 i = 1; i <= stud; i++)
        //    {
        //        Console.WriteLine("Student " + i);

        //        Console.Write("\tName: ");
        //        tabNames[i] = Console.ReadLine();

        //        Console.Write("\tYear of birth: ");
        //        yob = Convert.ToInt16(Console.ReadLine());
          


        //        do
        //        {
        //            Console.Write("\tScore: ");
        //            tabGrades[i] = Convert.ToSingle(Console.ReadLine());
        //            sum = sum + tabGrades[i];
        //            if (tabGrades[i] > best)
        //            {
        //                best = tabGrades[i];
        //            }
        //            if (tabGrades[i] < worst)
        //            {
        //                worst = tabGrades[i];
        //            }
        //        } while (!(tabGrades[i] >= 0 && tabGrades[i] <= 100));
        //    }
        //    avg = sum / stud;
        //    Console.WriteLine("Thanks, Here's the class information\n");
        //    Console.WriteLine("Students\tGrades\tYear B.\tAges");
        //    for (Int16 i = 1; i <= stud; i++)
        //    {
        //        Console.WriteLine(tabNames[i] + "\t\t" + tabGrades[i]);
        //    }
            
        //    Console.WriteLine("Class Average is " + avg);

        //    Console.WriteLine("Oldest students");

        //}

        public static void Exo3Correction()
        {
            //variables and arrays declaration
            Int16 nbstuds;
            string[] tabNames;
            Single[] tabGrades;
            Int16[] tabYearsB;
            Single avg, sum = 0, oldB, yngB, best;

            Console.WriteLine("\tLASALLE COLLEGE");
            Console.WriteLine("\t---------------\n");

            Console.Write("Enter the number of students: ");
            nbstuds = Convert.ToInt16(Console.ReadLine());

            while (nbstuds < 2 || nbstuds > 100)
            {
                Console.Write("Enter the number of students (2 - 100): ");
                nbstuds = Convert.ToInt16(Console.ReadLine());
            }

            //create dynamically our 3 arrays using nbstuds as their size
            tabNames = new string[nbstuds];
            tabGrades = new Single[nbstuds];
            tabYearsB = new Int16[nbstuds];

            //read all information (3) about students into arrays
            for(Int16 i=0; i < nbstuds; i++)
            {
                Console.WriteLine("Student " + (i + 1) + ":");

                do
                {
                    Console.Write("\tName: ");
                    tabNames[i] = Console.ReadLine();
                } while (tabNames[i] == "");

                do
                {
                    Console.Write("\tYear of birth: ");
                    tabYearsB[i] = Convert.ToInt16(Console.ReadLine());
                } while (tabYearsB[i] > 2008 || tabYearsB[i] < 1973);


                do
                {
                    Console.Write("\tScore: ");
                    tabGrades[i] = Convert.ToSingle(Console.ReadLine());
                } while (tabGrades[i] < 0 || tabGrades[i] > 100);                               
            }

            //displaying all information (+age) from the array
            Console.WriteLine("Thanks, Here's the class information");
            Console.WriteLine("Students\tGrades\tYear B.\tAges");

            //store the first year of birth in oldB and yngB/same for best grade
            oldB = yngB = tabYearsB[0];
            best = tabGrades[0];

            for (Int16 i = 0; i < nbstuds; i++)
            {
                Int16 age = Convert.ToInt16(2023 - tabYearsB[i]);
                Console.WriteLine(tabNames[i] + "\t\t" + tabGrades[i] + "\t" + tabYearsB[i] + "\t" + age);

                //accumulate the sum of grades for average
                sum += tabGrades[i];

                //find the oldest Year Birth (lowest yearB)
                if (tabYearsB[i] < oldB)
                {
                    oldB = tabYearsB[i];
                }
                //find the youngest year birth (biggest yB)
                if (tabYearsB[i] > yngB)
                {
                    yngB = tabYearsB[i];
                }
                //find the best (max) grade
                best = (tabGrades[i] > best) ? tabGrades[i] : best;
            }

            avg = sum / nbstuds;
            Console.WriteLine("Class Average is " + avg);

            //display oldest students with the yearB == oldB
            Console.WriteLine("\nOldest Students");

            for(Int16 i = 0; i < nbstuds; i++)
            {
                if (tabYearsB[i] == oldB)
                {
                    Int16 age = Convert.ToInt16(2023 - tabYearsB[i]);
                    Console.WriteLine(tabNames[i] + "\t" + age);
                }
            }

            //display youngest and best students
            Console.WriteLine("Youngest AND Best Students");

            for(Int16 i = 0; i < nbstuds; i++)
            {
                if (tabYearsB[i] == yngB && tabGrades[i] == best)
                {
                    Int16 age = Convert.ToInt16(2023 - tabYearsB[i]);
                    Console.WriteLine(tabNames[i] + "\t" + tabGrades[i] + "\t" + age);
                }
            }
        }
    }
}

