namespace Implementations.ChainOfResponsibility.Decorator
{
    public interface IDecoratorStepAuctionChainOfResponsibility<TEntityToProcess, TParameter>
    {
        void Process(TEntityToProcess entityToProcess, TParameter parameter);
        void SetSuccessor(IDecoratorStepAuctionChainOfResponsibility<TEntityToProcess, TParameter> successor);
    }
}