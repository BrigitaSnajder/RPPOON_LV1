using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV1
{
    class Note
    {
        public override string ToString()
        {
            return NoteText + " - " + AuthorName + " - " + LevelOfImportance;
        }

        private string noteText;
        public string NoteText
        {
            get { return noteText; }
            set { noteText = value; }
        }
        public string AuthorName
        {
            get { return authorName; }
            set { authorName = value; }
        }
        public int LevelOfImportance
        {
            get { return levelOfImportance; }
            set { levelOfImportance = value; }
        }
        private string authorName;
        private int levelOfImportance;

        /*public string getNoteText() { return this.noteText;}
        public string getAuthorName() { return this.authorName;}
        public int getLevelOfImportance() {  return this.levelOfImportance; }
        
        public void setNoteText(string noteText) { this.noteText = noteText; }
        public void setLevelOfImportance(int levelOfImportance) { this.levelOfImportance = levelOfImportance; }*/

        public Note()
        {
            this.noteText = "None";
            this.authorName = "Anonymous";
            this.levelOfImportance = 0;
        }
        public Note(string noteText, string authorName, int levelOfImportance)
        {
            this.noteText = noteText;
            this.authorName = authorName;
            this.levelOfImportance = levelOfImportance;
        }
        public Note(string noteText)
        {
            this.noteText = noteText;
            this.authorName = "Anonymous";
            this.levelOfImportance = 0;
        }
    }
    
}
