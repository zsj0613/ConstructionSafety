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
    /// Page_Construction_Safety.xaml 的交互逻辑
    /// </summary>
    public partial class Page_Construction_Safety : Page
    {
        public Page_Construction_Safety()
        {
            InitializeComponent();
        }

        private void button_Construction_Safety_BackHome_Click(object sender, RoutedEventArgs e)
        {
            Frame pageFrame = null;
            DependencyObject currentParent = VisualTreeHelper.GetParent(this);

            while(currentParent != null && pageFrame == null)
            {
                pageFrame = currentParent as Frame;
                currentParent = VisualTreeHelper.GetParent(currentParent);
            }

            if(pageFrame != null)
            {
                pageFrame.Source = new Uri("Page_Main.xaml",UriKind.RelativeOrAbsolute);
            }
        }
    }
}
