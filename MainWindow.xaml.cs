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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace WPF23._1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double sizeF = 12;
        public MainWindow()
        {
            InitializeComponent();
            tb.FontSize = sizeF;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Кнопка ToolBar была нажата!");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            prostoFunc(tb.Selection, TextElement.FontStyleProperty, FontStyles.Italic);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            prostoFunc(tb.Selection, Inline.TextDecorationsProperty, TextDecorations.Underline);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            sizeF += 2;
            prostoFunc(tb.Selection, FontSizeProperty, (double)sizeF);
            
        }

            private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            sizeF -= 2;
            prostoFunc(tb.Selection, FontSizeProperty, (double)sizeF);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            prostoFunc(tb.Selection, TextElement.FontWeightProperty, FontWeights.Bold);
        }

        private void prostoFunc(TextRange select, DependencyProperty formatingproperty, object value)
        {
           

            if (select != null)
            {
                try
                {
                    select.ApplyPropertyValue(formatingproperty, value);

                }
                catch { }
            }
            
        }

       
    }
}
