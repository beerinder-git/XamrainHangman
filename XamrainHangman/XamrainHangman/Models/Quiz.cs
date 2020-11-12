using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace XamrainHangman.Models
{
    public class Quiz
    {
        [PrimaryKey]
        public int Id { get; set; }
        public string Word { get; set; }

        public override string ToString()
        {
            return Word;
        }
    }
}
