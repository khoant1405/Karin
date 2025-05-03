namespace Karin.Domain.Entities
{
    public class Comic : IEntity
    {
        public string Name { get; set; } = default!;
        public string Id { get; set; } = Guid.NewGuid().ToString();
    }
}