﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПЗ6
{
     class Monster
    {
        public Monster(string name)
        {
            _name = name;
        }
        private string _name;
        public string Name
        {
            get => _name;
        }
    }
}
