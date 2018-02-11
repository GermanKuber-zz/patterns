namespace Implementations.ChainOfResponsibility.Decorator
{
    public abstract class DecoratorStepAuctionChainOfResponsibility<TEntityToProcess, TParameter>
    {
        protected DecoratorStepAuctionChainOfResponsibility<TEntityToProcess, TParameter> successor;

        public void SetSuccessor(DecoratorStepAuctionChainOfResponsibility<TEntityToProcess, TParameter> successor)
        {
            this.successor = successor;
        }

        public abstract void Process(TEntityToProcess entityToProcess, TParameter parameter);
    }
}
