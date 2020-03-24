using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV1
{
    class ToDo
    {
        private List<Note> lista;

        public ToDo()
        {
            lista = new List<Note>();
        }

        public ToDo(List<Note> list)
        {
            lista = list;
        }

        public void AddToList(Note n)
        {
            lista.Add(n);
        }

        public void RemoveFromList(int n)
        {
            lista.RemoveAt(n);
        }

        public Note FetchNote(int n)
        {
            return lista[n];
        }

        public void PrintList()
        {
            for(int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i].ToString());
            }

            Console.WriteLine();
        }

        public int GetHighest()
        {
            int najveci = lista[0].LevelOfImportance;
            for(int i=1; i< lista.Count; i++)
            {
                if (lista[i].LevelOfImportance > najveci)
                    najveci = lista[i].LevelOfImportance;
            }
            return najveci;
        }

        public void SolveHighest()
        {
            int najveci = GetHighest();
            for(int i=0; i < lista.Count; i++)
            {
                if (lista[i].LevelOfImportance == najveci)
                {
                    RemoveFromList(i);
                    i--;
                }
            }
        }
    }
}
