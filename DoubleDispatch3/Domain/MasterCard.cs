using System;
using System.Collections.Generic;
using System.Text;

namespace DoubleDispatch3.Domain
{
    class MasterCard<T> : INinshouZumiCard<T> where T : ICardNinshouResult
    {
        private Func<T> func;

        public MasterCard(Func<T> func)
        {
            this.func = func;
        }

        public T Result()
        {
            return func();
        }
    }
}
