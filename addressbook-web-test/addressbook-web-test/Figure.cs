﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addressbook_web_test
{
    internal class Figure
    {
        private bool colored = false;

        public bool Colored
        {
            get
            {
                return this.colored;
            }
            set
            {
                this.colored = value;
            }
        }

    }
}
