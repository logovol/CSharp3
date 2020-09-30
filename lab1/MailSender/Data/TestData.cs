﻿using MailSender.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender.Data
{
    static class TestData
    {
        public static List<Sender> Senders { get; } = Enumerable.Range(1, 10)
            .Select(i => new Sender
            {
                Name = $"Получатель {i}",
                Address = $"sender_{i}@server.ru"
            }).ToList();

        public static List<Recipient> Recipients { get; } = Enumerable.Range(1, 10)
            .Select(i => new Recipient
            {
                Name = $"Отправитель {i}",
                Address = $"recipient_{i}@server.ru"
            }).ToList();

        public static List<Server> Servers { get; } = Enumerable.Range(1, 10)
           .Select(i => new Server
           {
               Address = $"smtp.server{i}.com",
               Login = $"Login-{i}",
               Password = $"Password-{i}",
               UseSSL = i % 2 == 0
           }).ToList();

        public static List<Message> Messages { get; } = Enumerable.Range(1, 20)
            .Select(i => new Message
            {
                Subject = $"Сообщение {i}",
                Body = $"Текст сообщения {i}"
            }).ToList();

    }
}
