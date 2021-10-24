using System;
using System.IO;
using System.Diagnostics;

namespace SavingToTXT
{
    public class PersonDetails1
    {     
        static void Main(string[] args)
        {
            string menuChoice = "";
            bool menuLoop = true;

            while (menuLoop == true)
            {
                while (menuChoice != "1" && menuChoice != "2" && menuChoice != "3")
                {
                    Console.Clear();
                    Console.Write("1. Add persons to file\n2. View file\n3. Exit\nEnter choice: ");
                    menuChoice = Console.ReadLine();
                }

                if (menuChoice == "1")
                {
                    PersonDetails2 PD = new PersonDetails2();
                    PD.Secondary();
                }

                if (menuChoice == "2")
                {
                    Process.Start("notepad.exe", @Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "NameData.DAT"));
                }

                if (menuChoice == "3")
                {
                    menuLoop = false;
                }
                menuChoice = "";
            }
        }
    }
    public class PersonDetails2
    {
        string halt;
        public void Secondary()
        {
            while (halt != "y" && halt != "Y")
            {
                Console.Clear();
                Console.Write("Name: ");
                string pNameFirst = Console.ReadLine();
                Console.Write("\nSurname: ");
                string pNameLast = Console.ReadLine();
                Console.Write("\nAge: ");
                string pAge = Console.ReadLine();
                Console.WriteLine("\nIs everything Correct? y / n");
                halt = Console.ReadLine();
                Console.Clear();
                string docPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                using StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "NameData.DAT"), true);
                outputFile.WriteLine(pNameFirst + "\n" + pNameLast + "\n" + pAge + "\n________________________________________\n\n");
            }
        }
    }
}
