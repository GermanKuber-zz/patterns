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
}
