﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender.Models
{
    class Server
    {
        public string Address { get; set; }

        private int _Port = 25;
        public int Port
        {
            get => _Port;
            set
            {
                if (value < 0 || value >= 65535)
                    throw new ArgumentOutOfRangeException(nameof(value), value, "Номер порта должен быть в диапозоне от 0 др 65534");
                _Port = value;
            }
        }
        public bool UseSSL { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Description { get; set; }

        //public override string ToString() => $"{Address}:{Port}";
        
    }
}
