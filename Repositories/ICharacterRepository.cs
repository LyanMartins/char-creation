using char_creation.Models;

namespace char_creation.Repositories
{
    public interface ICharacterRepository
    {
        Character create(Character character);
    }
}