using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniExcel
{
    class Table
    {
        public int RowCount { get; private set; }
        public int ColumnCount { get; private set; }
        private Cell[,] _cells;

        public Table(int rowCount, int columnCount)
        {
            RowCount = rowCount;
            ColumnCount = columnCount;
            _cells = new Cell[rowCount, columnCount];
        }

        public void SetRow(string rowData, int rowIndex)
        {
            string[] cellData = rowData.Split(new char[] { '\t' }, StringSplitOptions.None);
            for (int i = 0; i < ColumnCount; i++)
            {
                if (i < cellData.Length)
                {
                    _cells[rowIndex, i] = new Cell(cellData[i]);
                }
                else
                {
                    _cells[rowIndex, i] = new Cell(String.Empty);
                    _cells[rowIndex, i].Error = "#NoData";
                }
            }
        }
    }
}
