using System;

namespace Entities
{
    [AttributeUsage(AttributeTargets.Property, Inherited = false)]
    public class MilestoneableAttribute : Attribute
    {
        public MilestoneableAttribute()
        {
        }
        public override bool Match(object obj)
        {
            return base.Match(obj);
        }

    }
}
