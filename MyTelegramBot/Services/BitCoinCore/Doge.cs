﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTelegramBot.Services.BitCoinCore
{
    class Doge: BitCoinCore.BitCoin
    {
        public Doge(string UserName, string Password, string Host = "127.0.0.1", string Port = "8332") 
            :base(UserName,Password,Host,Port)
        {

        }
    }
}
