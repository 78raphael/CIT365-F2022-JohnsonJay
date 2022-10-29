using System.ComponentModel.DataAnnotations;

namespace MyScriptureJournal.Models
{
    public class ScriptureClass
    {
        public int ID { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateAdded { get; set; }
        public string? Book { get; set; }
        public int Chapter { get; set; }
        public int Verse { get; set; }
        public string? Note { get; set; }
        
    }
}
