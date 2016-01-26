using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattleCore
{
    public class BattleField
    {
        protected const int Size = 10;
        public CellState[] Cells { get; set; }



        protected CellState this[int row, int col] {
            get
            {
                return Cells[row * Size + col];
            }
            set
            {
                Cells[row * Size + col] = value;
            }
        }


        public BattleField()
        {
            //for (var i = 0; i < 100; i++)
            //{
            //    Cells[i] = new CellState();
            //}

            Cells = Enumerable.Range(0, Size * Size).Select(x => new CellState()).ToArray();
        }
    }
}
