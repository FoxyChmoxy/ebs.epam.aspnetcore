﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserInterface.ViewModels
{
    public class DialogViewModel
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string UserSenderEmail { get; set; }
        public string UserReceiverEmail { get; set; }
    }
}
