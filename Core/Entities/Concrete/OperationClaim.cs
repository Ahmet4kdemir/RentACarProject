using Core.Entities.Abstract;

namespace Core.Concrete
{
    public class OperationClaim:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }    
    }
}
