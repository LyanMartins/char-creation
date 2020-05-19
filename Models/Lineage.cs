namespace char_creation.Models
{
    public class Lineage : BaseModel
    {
        public string name { get; set; }   
        public LineageAtributtes lineageAtributtes { get; set; }
    }
}