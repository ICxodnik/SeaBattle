using SeaBattleCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SeaBattle
{
    /// <summary>
    /// Логика взаимодействия для BattleField.xaml
    /// </summary>
    public partial class BattleFieldControl : UserControl
    {
        public static readonly DependencyProperty BattleFieldProperty = DependencyProperty.Register(
            nameof(BattleField), typeof(BattleField), typeof(BattleFieldControl));

        public BattleField BattleField
        {
            get { return (BattleField)GetValue(BattleFieldProperty); }
            set { SetValue(BattleFieldProperty, value); }
        }


        public BattleFieldControl()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var cellState = (e.OriginalSource as Button).DataContext as CellState;
            if (cellState != null)
            {
                cellState.IsKnown = true;
            }
        }
    }
}
