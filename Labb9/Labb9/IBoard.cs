﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb9
{
    interface IBoard
    {
        Node Grid { get; set; }

        void PlaceMarker(int choice, char[] arr, int player);
    }
}
