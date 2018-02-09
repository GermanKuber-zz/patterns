using System;

namespace ConsoleApp3
{
    public class UpdateTitleStrategy : IStrategy<Auction,UpdateTitleParameter>
    {
        public void Execute(Auction updatingEntity, UpdateTitleParameter parameter)
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
