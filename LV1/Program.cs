using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Note note1, note2, note3;
            note1 = new Note();
            note2= new Note("Danas pada snijeg.","Mario",1);
            note3 = new Note("Volim RPPOON");

            //Console.WriteLine(note1.AuthorName + " - " + note1.NoteText);
            //Console.WriteLine(note2.AuthorName + " - " + note2.NoteText);
            //Console.WriteLine(note3.AuthorName + " - " + note3.NoteText);
            
            Console.WriteLine(note1.ToString());
            Console.WriteLine(note2.ToString());
            Console.WriteLine(note3.ToString());

            TimeNote noteT;
            noteT = new TimeNote("Brigita programira", "Biri", 3, DateTime.Now);
            Console.WriteLine(noteT.ToString());*/

            ToDo lista = new ToDo();
            while(true)
            {
                Console.Write("Unesi zadatak: ");
                string zabiljeska = Console.ReadLine();
                if (zabiljeska == "") break;

                Console.Write("Unesi autora: ");
                string autor = Console.ReadLine();
                if (autor == "") autor = "Anonymous";

                Console.Write("Unesi vaznost: ");
                int vaznost = Convert.ToInt32(Console.ReadLine());

                Console.Write("Pracenje vremena Y/N: ");
                string vrijeme = Console.ReadLine();
                if (vrijeme == "Y" || vrijeme == "y") lista.AddToList(new TimeNote(zabiljeska, autor, vaznost));
                else lista.AddToList(new Note(zabiljeska, autor, vaznost));
                Console.WriteLine();
            }
            Console.WriteLine();
            lista.PrintList();
            lista.SolveHighest();
            lista.PrintList();
        }
    }
}
