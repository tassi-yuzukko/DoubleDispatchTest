using System;
using System.Collections.Generic;
using System.Text;

namespace DoubleDispatch3.Domain
{
    class RiyoushaCard<T> : INinshouZumiCard<T> where T : ICardNinshouResult
    {
        private Func<int, T> func;
        int x;

        public RiyoushaCard(Func<int, T> func, int x)
        {
            this.func = func;
            this.x = x;
        }

        public T Result()
        {
            return func(x);
        }
    }
}