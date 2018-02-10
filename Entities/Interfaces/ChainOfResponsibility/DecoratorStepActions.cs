namespace Implementations.ChainOfResponsibility.Decorator
{
    public abstract class DecoratorStepAuctionChainOfResponsibility<TEntityToProcess, TParameter> : IDecoratorStepAuctionChainOfResponsibility<TEntityToProcess, TParameter>
    {
        protected IDecoratorStepAuctionChainOfResponsibility<TEntityToProcess, TParameter> successor;

        public void SetSuccessor(IDecoratorStepAuctionChainOfResponsibility<TEntityToProcess, TParameter> successor)
        {
            this.successor = successor;
        }

        public abstract void Process(TEntityToProcess entityToProcess, TParameter parameter);
    }
}
