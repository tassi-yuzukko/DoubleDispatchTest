using DoubleDispatch3.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoubleDispatch3.Service
{
    class CardNinshouService : ICardNinshouService<CardNinshouService.Response>
    {
        public Response MasterCard()
        {
            return new Response { X = -1 };
        }

        public Response RiyoushaCard(int x)
        {
            return new Response { X = x };
        }

        public Response Execute()
        {
            var cardNinshou = new CardNinshou<Response>();

            var ninshouZumi = cardNinshou.DoCardNinshou(this);

            return ninshouZumi.Result();
        }

        public class Response : ICardNinshouResult
        {
            public int X = 0;
        }
    }
}
