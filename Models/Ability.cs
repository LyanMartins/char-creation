using System.Collections.Generic;

namespace char_creation.Models
{
    public class Ability : BaseModel
    {
        // name:string
        // cost:int
        // type:string
        public string name { get; set; }   
        public int cost { get; set; }  
        public string type { get; set; }
        public virtual ICollection<CharacterAbility> characterAbility { get; set; }
    
    }
}