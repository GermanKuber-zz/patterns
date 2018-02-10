using System;
using System.Collections.Generic;
using Entities;
using Entities.Interfaces;
using Implementations.Collections;
using Implementations.Factories;
using Implementations.Strategies.Update.Auction;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var auctionStrategyFactory = new AuctionStrategyFactory();

            var updateProviderStrategy =
                auctionStrategyFactory.Make<UpdateProviderParameter>(StrategyTypeEnum.UpdateProvider);

            var updateParameter =
                new UpdateProviderParameter(new Providers(new List<Provider> {new Provider {Name = "Juan"}}));


            var auctionStatusFactory = new AuctionStatusFactory();
            var roundAuctionStatusFactory = new RoundAuctionStatusFactory();
            var auction = new Auction(auctionStatusFactory, roundAuctionStatusFactory, AuctionStatusTypeEnum.New);

            auction.ChangeStatus(auctionStatusFactory.Make(AuctionStatusTypeEnum.Draft, auction));

            auction.Update(updateProviderStrategy, updateParameter);

            var newRound1 = new RoundAuction(auction);
            var newRound2 = new RoundAuction(auction);
            var newRound3 = new RoundAuction(auction);


            //Round Auction

            var addRoundAuctionStrategy =
                auctionStrategyFactory.Make<AddRoundAuctionParameter>(StrategyTypeEnum.AddRound);

            var addRoundAuctionParameters = new AddRoundAuctionParameter(newRound1);
            auction.Update(addRoundAuctionStrategy, addRoundAuctionParameters);


            var addRoundAuctionParameters2 = new AddRoundAuctionParameter(newRound2);
            auction.Update(addRoundAuctionStrategy, addRoundAuctionParameters2);


            var deleteRoundAuctionStrategy =
                auctionStrategyFactory.Make<DeleteRoundAuctionParameter>(StrategyTypeEnum.DeleteRound);
            var deleteRoundAuctionParameters = new DeleteRoundAuctionParameter(newRound1);
            auction.Update(deleteRoundAuctionStrategy, deleteRoundAuctionParameters);

            var deleteRoundAuctionParameters3 = new DeleteRoundAuctionParameter(newRound1);
            auction.Update(deleteRoundAuctionStrategy, deleteRoundAuctionParameters3);


            var deleteRoundAuctionParameters2 = new DeleteRoundAuctionParameter(newRound2);
            auction.Update(deleteRoundAuctionStrategy, deleteRoundAuctionParameters2);
        }
    }
}