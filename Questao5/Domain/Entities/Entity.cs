namespace Questao5.Domain.Entities
{
    public abstract class Entity
    {
        public Entity(int id)
        {
            Id = id;
        }
        public int Id { get; private set; }

        public void SetId(int id)
        {
            Id = id;
        }
    }
}
