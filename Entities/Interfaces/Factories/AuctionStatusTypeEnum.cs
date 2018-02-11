namespace Entities.Interfaces
{
    public enum AuctionStatusTypeEnum
    {
        New,
        Draft,
        Close
    }

    public enum AuctionTypeEnum
    {
        Complete
    }
    public enum DecoratorsEnum
    {
        AuctionMilestoneUpdateOpeningDate,
        AuctionMilestoneUpdateProviders

    }
    public enum AuctionsChainOfResponsibilityEnum
    {
        MilestoneOpeningDateStepAction,
        MilestoneProvidersStepAction
    }

}

