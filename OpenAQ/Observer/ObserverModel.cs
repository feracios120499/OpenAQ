﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenAQ.Observer
{
    public class ObserverModel
    {
        public string Country { get; set; }
        public List<string> Cities { get; set; } = new List<string>();
    }
}
