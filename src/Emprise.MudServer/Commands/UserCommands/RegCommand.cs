﻿using Emprise.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Emprise.MudServer.Commands
{

    public class RegCommand : Command
    {

        public string Email { get; set; }

        public string Password { get; set; }

        public string Code { get; set; }
        public RegCommand(string email, string password, string code)
        {
            Email = email;
            Password = password;
            Code = code;
        }
    }
}
