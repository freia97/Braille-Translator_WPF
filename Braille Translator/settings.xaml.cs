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
using System.Windows.Shapes;

namespace Braille_Translator
{
    /// <summary>
    /// Логика взаимодействия для settings.xaml
    /// </summary>
    public partial class settings : Window
    {
        public settings()
        {
            InitializeComponent();
        }

        private void color1_Click(object sender, RoutedEventArgs e)
        {
            Window1 main = this.Owner as Window1;
            main.TextBox1.Background = Brushes.White;
            main.TextBox2.Background = Brushes.White;
            main.TextBox3.Background = Brushes.White;
            main.textbox4.Background = Brushes.White;
            main.textbox5.Background = Brushes.White;
            main.TextBox1.Foreground = Brushes.Black;
            main.TextBox2.Foreground = Brushes.Black;
            main.TextBox3.Foreground = Brushes.Black;
            main.textbox4.Foreground = Brushes.Black;
            main.textbox5.Foreground = Brushes.Black;
        }

        private void ok_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void color2_Click(object sender, RoutedEventArgs e)
        {
            Window1 main = this.Owner as Window1;
            main.TextBox1.Background = Brushes.Black;
            main.TextBox2.Background = Brushes.Black;
            main.TextBox3.Background = Brushes.Black;
            main.textbox4.Background = Brushes.Black;
            main.textbox5.Background = Brushes.Black;
            main.TextBox1.Foreground = Brushes.White;
            main.TextBox2.Foreground = Brushes.White;
            main.TextBox3.Foreground = Brushes.White;
            main.textbox4.Foreground = Brushes.White;
            main.textbox5.Foreground = Brushes.White;
        }

        private void color3_Click(object sender, RoutedEventArgs e)
        {
            Window1 main = this.Owner as Window1;
            main.TextBox1.Background = new SolidColorBrush(Color.FromRgb(20, 8, 102));
            main.TextBox2.Background = new SolidColorBrush(Color.FromRgb(20, 8, 102));
            main.TextBox3.Background = new SolidColorBrush(Color.FromRgb(20, 8, 102));
            main.textbox4.Background = new SolidColorBrush(Color.FromRgb(20, 8, 102));
            main.textbox5.Background = new SolidColorBrush(Color.FromRgb(20, 8, 102));
            main.TextBox1.Foreground = Brushes.White;
            main.TextBox2.Foreground = Brushes.White;
            main.TextBox3.Foreground = Brushes.White;
            main.textbox4.Foreground = Brushes.White;
            main.textbox5.Foreground = Brushes.White;
        }

        private void color4_Click(object sender, RoutedEventArgs e)
        {
            Window1 main = this.Owner as Window1;
            main.TextBox1.Background = new SolidColorBrush(Color.FromRgb(13, 35, 9));
            main.TextBox2.Background = new SolidColorBrush(Color.FromRgb(13, 35, 9));
            main.TextBox3.Background = new SolidColorBrush(Color.FromRgb(13, 35, 9));
            main.textbox4.Background = new SolidColorBrush(Color.FromRgb(13, 35, 9));
            main.textbox5.Background = new SolidColorBrush(Color.FromRgb(13, 35, 9));
            main.TextBox1.Foreground = Brushes.Yellow;
            main.TextBox2.Foreground = Brushes.Yellow;
            main.TextBox3.Foreground = Brushes.Yellow;
            main.textbox4.Foreground = Brushes.Yellow;
            main.textbox5.Foreground = Brushes.Yellow;
        }

        private void color5_Click(object sender, RoutedEventArgs e)
        {
            Window1 main = this.Owner as Window1;
            main.TextBox1.Background = Brushes.Bisque;
            main.TextBox2.Background = Brushes.Bisque;
            main.TextBox3.Background = Brushes.Bisque;
            main.textbox4.Background = Brushes.Bisque;
            main.textbox5.Background = Brushes.Bisque;
            main.TextBox1.Foreground = Brushes.Purple;
            main.TextBox2.Foreground = Brushes.Purple;
            main.TextBox3.Foreground = Brushes.Purple;
            main.textbox4.Foreground = Brushes.Purple;
            main.textbox5.Foreground = Brushes.Purple;
        }

        private void color6_Click(object sender, RoutedEventArgs e)
        {
            Window1 main = this.Owner as Window1;
            main.TextBox1.Background = new SolidColorBrush(Color.FromRgb(32, 32, 32));
            main.TextBox2.Background = new SolidColorBrush(Color.FromRgb(32, 32, 32));
            main.TextBox3.Background = new SolidColorBrush(Color.FromRgb(32, 32, 32));
            main.textbox4.Background = new SolidColorBrush(Color.FromRgb(32, 32, 32));
            main.textbox5.Background = new SolidColorBrush(Color.FromRgb(32, 32, 32));
            main.TextBox1.Foreground = Brushes.Orange;
            main.TextBox2.Foreground = Brushes.Orange;
            main.TextBox3.Foreground = Brushes.Orange;
            main.textbox4.Foreground = Brushes.Orange;
            main.textbox5.Foreground = Brushes.Orange;
        }

        private void tcolor1_Click(object sender, RoutedEventArgs e)
        {
            Window1 main = this.Owner as Window1;
            main.TextBox1.Foreground = Brushes.White;
            main.TextBox2.Foreground = Brushes.White;
            main.TextBox3.Foreground = Brushes.White;
            main.textbox4.Foreground = Brushes.White;
            main.textbox5.Foreground = Brushes.White;

        }

        private void tcolor2_Click(object sender, RoutedEventArgs e)
        {
            Window1 main = this.Owner as Window1;
            main.TextBox1.Foreground = Brushes.Black;
            main.TextBox2.Foreground = Brushes.Black;
            main.TextBox3.Foreground = Brushes.Black;
            main.textbox4.Foreground = Brushes.Black;
            main.textbox5.Foreground = Brushes.Black;
        }

        private void tcolor3_Click(object sender, RoutedEventArgs e)
        {
            Window1 main = this.Owner as Window1;
            main.TextBox1.Foreground = Brushes.Blue;
            main.TextBox2.Foreground = Brushes.Blue;
            main.TextBox3.Foreground = Brushes.Blue;
            main.textbox4.Foreground = Brushes.Blue;
            main.textbox5.Foreground = Brushes.Blue;
        }

        private void tcolor4_Click(object sender, RoutedEventArgs e)
        {
            Window1 main = this.Owner as Window1;
            main.TextBox1.Foreground = Brushes.DarkOrange;
            main.TextBox2.Foreground = Brushes.DarkOrange;
            main.TextBox3.Foreground = Brushes.DarkOrange;
            main.textbox4.Foreground = Brushes.DarkOrange;
            main.textbox5.Foreground = Brushes.DarkOrange;
        }

        private void tcolor5_Click(object sender, RoutedEventArgs e)
        {
            Window1 main = this.Owner as Window1;
            main.TextBox1.Foreground = Brushes.Red;
            main.TextBox2.Foreground = Brushes.Red;
            main.TextBox3.Foreground = Brushes.Red;
            main.textbox4.Foreground = Brushes.Red;
            main.textbox5.Foreground = Brushes.Red;
        }

        private void tcolor6_Click(object sender, RoutedEventArgs e)
        {
            Window1 main = this.Owner as Window1;
            main.TextBox1.Foreground = Brushes.Yellow;
            main.TextBox2.Foreground = Brushes.Yellow;
            main.TextBox3.Foreground = Brushes.Yellow;
            main.textbox4.Foreground = Brushes.Yellow;
            main.textbox5.Foreground = Brushes.Yellow;
        }

        private void tcolor7_Click(object sender, RoutedEventArgs e)
        {
            Window1 main = this.Owner as Window1;
            main.TextBox1.Foreground = Brushes.SpringGreen;
            main.TextBox2.Foreground = Brushes.SpringGreen;
            main.TextBox3.Foreground = Brushes.SpringGreen;
            main.textbox4.Foreground = Brushes.SpringGreen;
            main.textbox5.Foreground = Brushes.SpringGreen;
        }

        private void tcolor8_Click(object sender, RoutedEventArgs e)
        {
            Window1 main = this.Owner as Window1;
            main.TextBox1.Foreground = Brushes.Orange;
            main.TextBox2.Foreground = Brushes.Orange;
            main.TextBox3.Foreground = Brushes.Orange;
            main.textbox4.Foreground = Brushes.Orange;
            main.textbox5.Foreground = Brushes.Orange;
        }

        private void tcolor9_Click(object sender, RoutedEventArgs e)
        {
            Window1 main = this.Owner as Window1;
            main.TextBox1.Foreground = Brushes.DeepSkyBlue;
            main.TextBox2.Foreground = Brushes.DeepSkyBlue;
            main.TextBox3.Foreground = Brushes.DeepSkyBlue;
            main.textbox4.Foreground = Brushes.DeepSkyBlue;
            main.textbox5.Foreground = Brushes.DeepSkyBlue;
        }

        private void tcolor10_Click(object sender, RoutedEventArgs e)
        {
            Window1 main = this.Owner as Window1;
            main.TextBox1.Foreground = Brushes.Purple;
            main.TextBox2.Foreground = Brushes.Purple;
            main.TextBox3.Foreground = Brushes.Purple;
            main.textbox4.Foreground = Brushes.Purple;
            main.textbox5.Foreground = Brushes.Purple;
        }

        private void selectFontSize_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Window1 main = this.Owner as Window1;
            string fontSize = selectFontSize.SelectedItem.ToString();
            fontSize = fontSize.Substring(fontSize.Length - 2);

            switch (fontSize)
            {
                
                case "14":
                    main.TextBox1.FontSize = 14;
                    main.TextBox2.FontSize = 14;
                    main.TextBox3.FontSize = 14;
                    main.textbox4.FontSize = 14;
                    main.textbox5.FontSize = 14;
                    break;
                case "16":
                    main.TextBox1.FontSize = 16;
                    main.TextBox2.FontSize = 16;
                    main.TextBox3.FontSize = 16;
                    main.textbox4.FontSize = 16;
                    main.textbox5.FontSize = 16;
                    break;
                case "18":
                    main.TextBox1.FontSize = 18;
                    main.TextBox2.FontSize = 18;
                    main.TextBox3.FontSize = 18;
                    main.textbox4.FontSize = 18;
                    main.textbox5.FontSize = 18;
                    break;
                case "20":
                    main.TextBox1.FontSize = 20;
                    main.TextBox2.FontSize = 20;
                    main.TextBox3.FontSize = 20;
                    main.textbox4.FontSize = 20;
                    main.textbox5.FontSize = 20;
                    break;
                case "22":
                    main.TextBox1.FontSize = 22;
                    main.TextBox2.FontSize = 22;
                    main.TextBox3.FontSize = 22;
                    main.textbox4.FontSize = 22;
                    main.textbox5.FontSize = 22;
                    break;
                case "24":
                    main.TextBox1.FontSize = 24;
                    main.TextBox2.FontSize = 24;
                    main.TextBox3.FontSize = 24;
                    main.textbox4.FontSize = 24;
                    main.textbox5.FontSize = 24;
                    break;
                case "28":
                    main.TextBox1.FontSize = 28;
                    main.TextBox2.FontSize = 28;
                    main.TextBox3.FontSize = 28;
                    main.textbox4.FontSize = 28;
                    main.textbox5.FontSize = 28;
                    break;
                case "32":
                    main.TextBox1.FontSize = 32;
                    main.TextBox2.FontSize = 32;
                    main.TextBox3.FontSize = 32;
                    main.textbox4.FontSize = 32;
                    main.textbox5.FontSize = 32;
                    break;
                case "36":
                    main.TextBox1.FontSize = 36;
                    main.TextBox2.FontSize = 36;
                    main.TextBox3.FontSize = 36;
                    main.textbox4.FontSize = 36;
                    main.textbox5.FontSize = 36;
                    break;
            }
        }
    }
}
