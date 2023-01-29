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

namespace Lesson_10
{
    /// <summary>
    /// Логика взаимодействия для RhombusControl.xaml
    /// </summary>
    public partial class RhombusControl : UserControl
    {
        public string Header { get; set; }
        public string Description { get; set; }
        public ImageSource ColoredSourse { get; set; }
        public ImageSource BlackWhiteSourse =>
            (ColoredSourse == null) ? null : new FormatConvertedBitmap((BitmapSource)ColoredSourse, PixelFormats.Gray8, null, 0);

        public RhombusControl()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void BtnAction_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Description, Header, MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
