﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mango.Web
{
    public class SD
    {
        public static string ProductAPIBase { get; set; }
        public enum ApuType
        {
            GET,
            PUT,
            POST,
            Delete
        }
    }
}
