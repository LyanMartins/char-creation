using System.Collections.Generic;

namespace char_creation.Models
{
    public class Character : BaseModel
    {
        // name:string
        // appearance:string
        // nivel: int = 1
        // experence:int = 0
        // bio:string
        public string name { get; set; }   
        public string appearence { get; set; }  
        public int nivel { get; set; }
        public int experence { get; set; }  
        public string bio { get; set; }    
        public CharacterLineage characterLineage { get; set; }    
        public Profission profission { get; set;}
        public virtual List<CharacterAbility> characterAbility { get; set; }
    }
}