﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot.Types.InlineKeyboardButtons;
using Telegram.Bot.Types.ReplyMarkups;
using Microsoft.EntityFrameworkCore;


namespace MyTelegramBot.Messages.Admin
{
    /// <summary>
    /// Мини сообщение с деталями последнего действия по заявке и кнопкой Подробнее
    /// </summary>
    public class HelpDeskMiniViewMessage : Bot.BotMessage
    {
        private int HelpDeskId { get; set; }

        private InlineKeyboardCallbackButton OpenBtn { get; set; }

        public HelpDeskMiniViewMessage(string TextMessage, int HelpDeskId)
        {
            this.HelpDeskId = HelpDeskId;
            base.TextMessage = TextMessage;
        }

        public HelpDeskMiniViewMessage BuildMessage()
        {
            OpenBtn = new InlineKeyboardCallbackButton("Открыть", BuildCallData(Bot.AdminModule.HelpDeskProccessingBot.GetHelpDeskCmd, Bot.AdminModule.HelpDeskProccessingBot.ModuleName, HelpDeskId));

            base.MessageReplyMarkup = new InlineKeyboardMarkup(new[] { new[] { OpenBtn } });

            return this;
        }

    }
}
