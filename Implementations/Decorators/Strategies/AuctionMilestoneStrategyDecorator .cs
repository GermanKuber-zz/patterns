using Entities;
using Entities.Interfaces;
using Implementations.Strategies.Update.Auction;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Implementations.Decorators.Strategies
{
    public class AuctionMilestoneStrategyDecorator : AuctionDecorator<UpdateOpeningParameter>
    {
        public override void Execute(Auction updatingEntity, UpdateOpeningParameter parameter)
        {
            Auction previousState = (Auction)updatingEntity.Clone();
            base.Execute(updatingEntity, parameter);


            //Type objtypeUpdating = updatingEntity.GetType();


            //Type objtypePreviousState = previousState.GetType();

            //// Loop through all properties
            //foreach (PropertyInfo propertyInfo in objtypeUpdating.GetProperties())
            //{
            //    var a = propertyInfo.GetValue(updatingEntity);
            //    // for every property loop through all attributes
            //    foreach (Attribute customAtribute in propertyInfo.GetCustomAttributes(false))
            //    {
            //        MilestoneableAttribute milestoneable = (MilestoneableAttribute)customAtribute;

            //        var newValue = propertyInfo.GetValue(updatingEntity);

            //        var oldValue = objtypePreviousState.GetProperty(propertyInfo.Name).GetValue(previousState);

            //        var areDifferents = !(oldValue == newValue);

            //        if (areDifferents)
            //        {
            //            Console.WriteLine($"Propiedad : {propertyInfo.Name}");
            //            Console.WriteLine($"Valor Previo : {newValue}");
            //            Console.WriteLine($"Valor Actual : {oldValue}");
            //        }
            //    }
            //}
        }
    }

}
