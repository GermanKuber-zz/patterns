using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var UpdateFactoStrategy = new AuctionStrategyFactory();

            var updateProviderStrategy = UpdateFactoStrategy.Make< UpdateProviderParameter>(StrategyTypeEnum.UpdateProvider);

            var updateParameter = new UpdateProviderParameter(new List<Provider> { new Provider { Name="Juan"} });


            var auctionStatusFactory = new AuctionStatusFactory();
            var auction = new Auction(auctionStatusFactory);

            auction.ChangeStatus(auctionStatusFactory.Make(AuctionStatusTypeEnum.Draft, auction));
            auction.Update(updateProviderStrategy, updateParameter);
        }
    }
}
