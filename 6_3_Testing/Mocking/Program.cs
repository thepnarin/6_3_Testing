﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_3_Testing.Mocking
{
    public class Program
    {
        public static void Main()
        {
            var service = new VideoService();
            var title = service.ReadVideoTitle();
        }
    }
}
