using System;
using System.Collections.Generic;

namespace NoteTakingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> notes = new List<string>();

            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Note-taking App");
                Console.WriteLine("1. View Notes");
                Console.WriteLine("2. Add Note");
                Console.WriteLine("3. Remove Note");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice (1-4): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("View Notes");
                        if (notes.Count == 0)
                        {
                            Console.WriteLine("No notes found.");
                        }
                        else
                        {
                            Console.WriteLine("Notes:");
                            for (int i = 0; i < notes.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {notes[i]}");
                            }
                        }
                        Console.WriteLine();
                        break;

                    case "2":
                        Console.WriteLine("Add Note");
                        Console.Write("Enter your note: ");
                        string note = Console.ReadLine();
                        notes.Add(note);
                        Console.WriteLine("Note added successfully.");
                        Console.WriteLine();
                        break;

                    case "3":
                        Console.WriteLine("Remove Note");
                        if (notes.Count == 0)
                        {
                            Console.WriteLine("No notes found.");
                        }
                        else
                        {
                            Console.Write("Enter the index of the note to remove: ");
                            if (int.TryParse(Console.ReadLine(), out int index) && index >= 1 && index <= notes.Count)
                            {
                                notes.RemoveAt(index - 1);
                                Console.WriteLine("Note removed successfully.");
                            }
                            else
                            {
                                Console.WriteLine("Invalid index.");
                            }
                        }
                        Console.WriteLine();
                        break;

                    case "4":
                        isRunning = false;
                        Console.WriteLine("Exiting...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}
