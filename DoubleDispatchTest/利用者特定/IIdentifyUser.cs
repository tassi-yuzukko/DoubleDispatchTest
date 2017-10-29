using DoubleDispatchTest.ユーザ情報;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoubleDispatchTest.利用者特定
{
    interface IIdentifyUser
    {
        string IdentifyUser(UserInfo userInfo);
    }
}
