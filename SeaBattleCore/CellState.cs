using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattleCore
{
    public class CellState : INotifyPropertyChanged
    {
        private bool isKnown = false;

        public bool HasShipPart { get; set; } = false;
        public bool IsKnown { get { return isKnown; } set { isKnown = value; Notify(); } }
        public bool IsReasonable { get; set; } = true;
        public Ship Ship { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private void Notify([CallerMemberName]string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
