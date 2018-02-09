using System.Collections.Generic;
using Entities.Interfaces;

namespace Entities
{
    public abstract class AuctionBase<EntityToExecuteStrategy> {
        public string Title { get; set; }
        public List<Provider> Providers { get; set; }
        public StatusAuction<EntityToExecuteStrategy> Status { get; set; }
        public void ChangeStatus(StatusAuction<EntityToExecuteStrategy> newStatus)
        {
            this.Status = newStatus;
        }
        protected void Add<TParameters>(EntityToExecuteStrategy entityToExecuteStrategy, IAddStrategy<EntityToExecuteStrategy, TParameters> updateStrategy, TParameters parameters) where TParameters : IParameters
        {
            updateStrategy.Execute(entityToExecuteStrategy, parameters);
        }
        public void Update<TParameters>(EntityToExecuteStrategy entityToExecuteStrategy, IUpdateStrategy<EntityToExecuteStrategy, TParameters> updateStrategy, TParameters parameters) where TParameters : IParameters
        {
            updateStrategy.Execute(entityToExecuteStrategy, parameters);

        }
    }
}
