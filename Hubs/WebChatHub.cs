using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace web_chat.Hubs
{
    public class WebChatHub : Hub
    {

        /// <summary>
        /// Отправить сообщение
        /// </summary>
        /// <param name="from"></param>
        /// <param name="message"></param>
        public void send(string from, string message)
        {
            //TODO: Можно обработать сообщение
            Clients.All.send(from, message);
        }
    }
}