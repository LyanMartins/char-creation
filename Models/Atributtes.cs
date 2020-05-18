namespace char_creation.Models
{
    public class Atributtes : BaseModel
    {
        // force:int
        // agility:int
        // physicist:int
        // aura:int
        // intellect:int
        // perception:int
        // charisma:int
        public int force { get; set; }
        public int agility { get; set; }
        public int physicist { get; set; }
        public int aura { get; set; }
        public int intellect { get; set; }
        public int perception { get; set; }
        public int charisma { get; set; }
        
    }
}