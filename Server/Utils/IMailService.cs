﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public interface IMailService
    {
        Task SendEmailAsync(MailRequest mailRequest);
    }
}
