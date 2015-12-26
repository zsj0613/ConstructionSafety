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
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            frame_main.Source = new Uri("Page_Main.xaml",UriKind.RelativeOrAbsolute);
        }


        public static void setTextColorBlack(Object sender)
        {
            TextBlock textBlock = (TextBlock)sender;
            textBlock.Foreground = Brushes.Black;
            return;
        }

        public static void setTextColorBlue(Object sender)
        {
            TextBlock textBlock = (TextBlock)sender;
            textBlock.Foreground = Brushes.Blue;
            return;
        }
    }
}
