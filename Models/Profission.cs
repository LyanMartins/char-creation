namespace char_creation.Models
{
    public class Profission : BaseModel
    {
        //   name:string
        // acquisitionPoints:int
        // penalizedGroups:string
        // specializedSkills:string
        // combatPoints:int
        public string name { get; set; }   
        public int acquisitionPoints { get; set; }  
        public string penalizedGroups { get; set; }
        public string specializedSkills { get; set; }  
        public int combatPoints { get; set; }    
        public CharacterLineage characterLineage { get; set; }    
    }
}