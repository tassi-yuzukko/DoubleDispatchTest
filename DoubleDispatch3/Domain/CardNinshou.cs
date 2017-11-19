using System;
using System.Collections.Generic;
using System.Text;

namespace DoubleDispatch3.Domain
{
    class CardNinshou<T> where T : ICardNinshouResult
    {
        public INinshouZumiCard<T> DoCardNinshou(ICardNinshouService<T> cardNinshouService)
        {
            int rand = new Random().Next();

            if (rand % 2 == 0) return new MasterCard<T>(cardNinshouService.MasterCard);
            else return new RiyoushaCard<T>(cardNinshouService.RiyoushaCard, rand);
        }
    }
}
