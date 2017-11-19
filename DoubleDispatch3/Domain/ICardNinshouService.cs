using System;
using System.Collections.Generic;
using System.Text;

namespace DoubleDispatch3.Domain
{
    interface ICardNinshouService<T> where T : ICardNinshouResult
    {
        T MasterCard();
        T RiyoushaCard(int x);
    }
}
