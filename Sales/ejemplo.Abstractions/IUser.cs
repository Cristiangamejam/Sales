﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo.Abstractions
{
    public interface IUser
    {
        int Id { get; set; }
        string Name { get; set; }
    }
}
