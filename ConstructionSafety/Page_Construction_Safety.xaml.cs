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

            SetLinearGradientUnderline();
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


        private void textBlock_openDoc_MouseEnter(object sender, MouseEventArgs e)
        {
            MainWindow.setTextColorBlue(sender);
        }

        private void textBlock_openDoc_MouseLeave(object sender, MouseEventArgs e)
        {
            MainWindow.setTextColorBlack(sender);
        }

        private void textBlock_openDoc_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            System.Diagnostics.Process.Start(@"ResFiles\灌河大桥工程项目安全生产管理用表（2012年8月8日）.doc");
        }

        private void SetLinearGradientUnderline()
        {
            TextDecoration myUnderline = new TextDecoration();

            Pen myPen = new Pen();
            myPen.Brush = new LinearGradientBrush(Colors.Yellow, Colors.Red, new Point(0, 0.5), new Point(1, 0.5));
            myPen.Brush.Opacity = 0.8;
            myPen.Thickness = 5;
            myPen.DashStyle = DashStyles.Dash;
            myUnderline.Pen = myPen;
            myUnderline.PenThicknessUnit = TextDecorationUnit.FontRecommended;
            myUnderline.PenOffset = 10; //设置下划线距离文字的偏移

            TextDecorationCollection myCollection = new TextDecorationCollection();
            myCollection.Add(myUnderline);
            textBlock_openDoc.TextDecorations = myCollection;
        }
    }
}
