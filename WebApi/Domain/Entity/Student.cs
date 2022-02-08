using Domain.Base;

namespace Domain.Entity
{
    public class Student : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
