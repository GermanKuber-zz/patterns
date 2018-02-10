using System;
using System.Collections.Generic;
using Entities.Interfaces;
using Entities.Interfaces.Collections;

namespace Entities
{
    public abstract class AuctionBase<EntityToExecuteStrategy>: IComparable
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public IProviders Providers { get; set; }
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

        public int CompareTo(object obj)
        {
            return 1;
        }
    }
}
