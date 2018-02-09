using Entities.Interfaces;

namespace Implementations.Strategies.Update.Auction
{
    public class UpdateTitleStrategy : IStrategy<Entities.Auction,UpdateTitleParameter>
    {
        public void Execute(Entities.Auction updatingEntity, UpdateTitleParameter parameter)
        {
            if (parameter.Name == "Mariano") {
                updatingEntity.Title = parameter.Name;
            }
        }
        
    }
    public class UpdateTitleParameter : IParameters
    {
        public string Name { get; set; }
        public UpdateTitleParameter(string name)
        {
            Name = name;
        }
    }
}
