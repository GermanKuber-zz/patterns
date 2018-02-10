using Implementations.ChainOfResponsibility.Decorator;

namespace Entities.Interfaces
{
    public abstract class Decorator<TUpdating,  TParameters> :  IDecorator<TUpdating, TParameters>, IUpdateStrategy<TUpdating, TParameters> where TParameters:IParameters
    {
        protected IStrategy<TUpdating, TParameters> StrategyToDecorate;
   
        public void SetStrategy(IStrategy<TUpdating, TParameters> strategyToDecorate)
        {
            StrategyToDecorate = strategyToDecorate;
        }

        public void SetStrategy<TEntityToProcess, TParameter>(DecoratorStepAuction<TEntityToProcess, TParameter> chainOfSteps)
        {
        }

        
        public virtual void Execute(TUpdating updatingEntity, TParameters parameter)
        {
            if (StrategyToDecorate != null)
                StrategyToDecorate.Execute(updatingEntity, parameter);
        }
    }
}
