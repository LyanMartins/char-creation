namespace char_creation.Models
{
    public class CharacterLineage : BaseModel
    {
        public string name { get; set; }   
        public Lineage lineage { get; set; }    
    }
}