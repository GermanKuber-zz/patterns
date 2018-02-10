namespace Entities
{
    public interface IMilestoneManager<TMilestoneable>
    {
        void PropertyChange<TVMilestoneable, TValue>(TVMilestoneable milestone, TValue newValue, TValue oldValue);
    }
}