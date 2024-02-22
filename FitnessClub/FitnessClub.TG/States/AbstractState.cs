﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types;

namespace FitnessClub.TG.States
{
    public abstract class AbstractState
    {
        public abstract void SendMessage(long ChatId);
        public abstract AbstractState ReceiveMessage(Update update);
        
    }
}