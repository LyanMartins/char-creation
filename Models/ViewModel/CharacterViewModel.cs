using char_creation.Models;

namespace char_creation.Models.ViewModel
{
    public class CharacterViewModel
    {
        public Character character;
        public string error = null;
        public CharacterViewModel(Character character)
        {
            this.character = character;
        }
        public CharacterViewModel(string error)
        {
            this.error = error;
        }
    }
}