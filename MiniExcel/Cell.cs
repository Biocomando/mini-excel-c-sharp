﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniExcel
{
    enum CellType { Expression, Number, Empty, Text }
    enum Status { OK, ERROR, UNDEFINED}

    class Cell
    {
        private string _rawData;

        public CellType Type { get; set; }
        public Status Status { get; set; }
        public string Error { get; set; }
        public int Result { get; set; }
        public string StringResult { get; set; }

        public Cell(string rawData)
        {
            _rawData = rawData;
            Status = Status.UNDEFINED;
        }
    }
}
