namespace Implementations.ChainOfResponsibility.Decorator
{
    public abstract class DecoratorStepAuction<TEntityToProcess, TParameter>
    {
        protected DecoratorStepAuction<TEntityToProcess, TParameter> successor;

        public void SetSuccessor(DecoratorStepAuction<TEntityToProcess, TParameter> successor)
        {
            this.successor = successor;
        }

        public abstract void Process(TEntityToProcess entityToProcess, TParameter parameter);
    }
}
