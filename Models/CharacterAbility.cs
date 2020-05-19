using System.Collections.Generic;

namespace char_creation.Models
{
    public class CharacterAbility : BaseModel
    {
        // name:string
        // cost:int
        // type:string
        public int characterId { get; set; }
        public Character character { get; set; }
        public int abilityId { get; set; }
        public Ability ability { get; set; }
    
    }
}