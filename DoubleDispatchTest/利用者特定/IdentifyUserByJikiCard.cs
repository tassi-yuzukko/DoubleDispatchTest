using System;
using System.Collections.Generic;
using System.Text;
using DoubleDispatchTest.ユーザ情報;

namespace DoubleDispatchTest.利用者特定
{
    class IdentifyUserByJikiCard : IIdentifyUser
    {
        public string IdentifyUser(UserInfo userInfo)
        {
            if (userInfo is JikiCardInfo == false)
            {
                throw new Exception("not JikiCardInfo");
            }

            JikiCardInfo jikiCardInfo = userInfo as JikiCardInfo;

            Console.WriteLine($"磁気カード情報:{jikiCardInfo.CardName}");

            return "Bob";
        }
    }
}
