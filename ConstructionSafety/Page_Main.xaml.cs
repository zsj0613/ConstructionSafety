using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ConstructionSafety
{
    /// <summary>
    /// Page_Main.xaml 的交互逻辑
    /// </summary>
    public partial class Page_Main : Page
    {
        public Page_Main()
        {
            InitializeComponent();
        }

        private void text_construct_safety_MouseEnter(object sender, MouseEventArgs e)
        {
            MainWindow.setTextColorBlue(sender);
        }

        private void text_construct_safety_MouseLeave(object sender, MouseEventArgs e)
        {
            MainWindow.setTextColorBlack(sender);
        }
    }
}
