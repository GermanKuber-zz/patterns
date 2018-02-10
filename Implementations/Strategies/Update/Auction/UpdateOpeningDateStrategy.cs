using System;
using Entities.Interfaces;

namespace Implementations.Strategies.Update.Auction
{
    public class UpdateOpeningDateStrategy : IUpdateStrategy<Entities.Auction, UpdateOpeningParameter>
    {
        public void Execute(Entities.Auction updatingEntity, UpdateOpeningParameter parameter)
        {
            updatingEntity.OpeningDate = parameter.OpeningDate;
        }

    }

    public class UpdateOpeningParameter : IParameters
    {
        public DateTime OpeningDate { get; }
        public UpdateOpeningParameter(DateTime openingDate)
        {
            OpeningDate = openingDate;
        }

   
    }
}
