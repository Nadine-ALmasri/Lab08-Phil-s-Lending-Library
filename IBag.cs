﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_Phil_s_Lending_Library
{
    public interface IBag<T> : IEnumerable<T>
    {
        void Pack(T item);
        T Unpack(int index);
    }

}
