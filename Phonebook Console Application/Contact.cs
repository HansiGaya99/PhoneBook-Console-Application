﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Phonebook_Console_Application
{
    class Contact
    {
        public Contact(string name, string number)
        {
            Name = name;
            Number = number;
        }
        public string Name { get; set; }
        public string Number { get; set; }
    }
}
