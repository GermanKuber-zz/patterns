using Implementations.ChainOfResponsibility.Decorator;

namespace Entities.Interfaces
{
    public abstract class Decorator<TUpdating, TParameters>   : IDecorator<TUpdating, TParameters>, IUpdateStrategy<TUpdating, TParameters> where TParameters : IParameters
    {
        protected IStrategy<TUpdating, TParameters> StrategyToDecorate;
        public bool HasSteps
        {
            get
            {
                if (FirstStep != null)
                    return true;
                return false;
            }
        }

        public IDecoratorStepAuctionChainOfResponsibility<TUpdating, TParameters> FirstStep { get; private set; }

        public void SetStrategy(IStrategy<TUpdating, TParameters> strategyToDecorate)
        {
            StrategyToDecorate = strategyToDecorate;
        }

        public void SetStrategy<TEntityToProcess, TParameter>(DecoratorStepAuctionChainOfResponsibility<TEntityToProcess, TParameter> chainOfSteps)
        {
        }


        public virtual void Execute(TUpdating updatingEntity, TParameters parameter)
        {
            if (StrategyToDecorate != null)
                StrategyToDecorate.Execute(updatingEntity, parameter);
            if (HasSteps)
                FirstStep.Process(updatingEntity, parameter);
        }

        public void SetStepsToProcess(IDecoratorStepAuctionChainOfResponsibility<TUpdating, TParameters> firstStep)
        {
            FirstStep = firstStep;
        }
    }
}
