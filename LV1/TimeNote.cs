using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV1
{
    class TimeNote : Note
    {
        public override string ToString()
        {
            return base.ToString() + " - " + Time;
        }

        private DateTime time;
        public DateTime Time
        {
            get { return time; }
            set { time = value; }
        }

        public TimeNote() : base()
        {
            time = DateTime.Now;
        }
        public TimeNote(string noteText, string authorName, int levelOfImportance, DateTime time = new DateTime()): base(noteText, authorName, levelOfImportance)
        {
            if(time == new DateTime())
            {
                this.time = DateTime.Now;
            }
            else
            {
                this.time = time;
            }
        }
        public TimeNote(string noteText, DateTime time): base(noteText)
        {
            this.time = time;
        }
    }
}
