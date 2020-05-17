using char_creation.Models;

namespace char_creation.Repositories
{
    class CharacterRepository : BaseRepository<Character>, ICharacterRepository
    {
        public CharacterRepository(DatabaseContext context) : base(context){}

        public Character create(Character character)
        {

            var model = new Character{
                name = character.name,
                appearence = character.appearence,
                bio = character.bio,
                experence = character.experence,
                nivel = character.nivel
            };

            databaseContext.AddAsync(model);
            databaseContext.SaveChangesAsync();

            return model;
        }
        
    }
}