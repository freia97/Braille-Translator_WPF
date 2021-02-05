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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
        List<char> simvols = new List<char>();
        StringBuilder rez = new StringBuilder();

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            rez.Clear();
        }

        private void TextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            string s = TextBox1.Text;
            simvols = s.ToList();
            foreach (char item in simvols)
            {
                switch (item)
                {
                    case 'a':
                        rez.Append("\u2801");
                        break;
                    case 'b':
                        rez.Append("\u2803");
                        break;
                    case 'c':
                        rez.Append("\u2809");
                        break;
                    case 'd':
                        rez.Append("\u2819");
                        break;
                    case 'e':
                        rez.Append("\u2811");
                        break;
                    case 'f':
                        rez.Append("\u280B");
                        break;
                    case 'g':
                        rez.Append("\u281B");
                        break;
                    case 'h':
                        rez.Append("\u2813");
                        break;
                    case 'i':
                        rez.Append("\u280A");
                        break;
                    case 'j':
                        rez.Append("\u281A");
                        break;
                    case 'k':
                        rez.Append("\u2805");
                        break;
                    case 'l':
                        rez.Append("\u2807");
                        break;
                    case 'm':
                        rez.Append("\u280D");
                        break;
                    case 'n':
                        rez.Append("\u281D");
                        break;
                    case 'o':
                        rez.Append("\u2815");
                        break;
                    case 'p':
                        rez.Append("\u280F");
                        break;
                    case 'q':
                        rez.Append("\u283B");
                        break;
                    case 'r':
                        rez.Append("\u2817");
                        break;
                    case 's':
                        rez.Append("\u280E");
                        break;
                    case 't':
                        rez.Append("\u281E");
                        break;
                    case 'u':
                        rez.Append("\u2825");
                        break;
                    case 'v':
                        rez.Append("\u2827");
                        break;
                    case 'w':
                        rez.Append("\u283A");
                        break;
                    case 'x':
                        rez.Append("\u282D");
                        break;
                    case 'y':
                        rez.Append("\u283D");
                        break;
                    case 'z':
                        rez.Append("\u2835");
                        break;
                    case 'A':
                        rez.Append("\u2828\u2801");
                        break;
                    case 'B':
                        rez.Append("\u2828\u2803");
                        break;
                    case 'C':
                        rez.Append("\u2828\u2809");
                        break;
                    case 'D':
                        rez.Append("\u2828\u2819");
                        break;
                    case 'E':
                        rez.Append("\u2828\u2811");
                        break;
                    case 'F':
                        rez.Append("\u2828\u280B");
                        break;
                    case 'G':
                        rez.Append("\u2828\u281B");
                        break;
                    case 'H':
                        rez.Append("\u2828\u2813");
                        break;
                    case 'I':
                        rez.Append("\u2828\u280A");
                        break;
                    case 'J':
                        rez.Append("\u2828\u281A");
                        break;
                    case 'K':
                        rez.Append("\u2828\u2805");
                        break;
                    case 'L':
                        rez.Append("\u2828\u2807");
                        break;
                    case 'M':
                        rez.Append("\u2828\u280D");
                        break;
                    case 'N':
                        rez.Append("\u2828\u281D");
                        break;
                    case 'O':
                        rez.Append("\u2828\u2815");
                        break;
                    case 'P':
                        rez.Append("\u2828\u280F");
                        break;
                    case 'Q':
                        rez.Append("\u2828\u283B");
                        break;
                    case 'R':
                        rez.Append("\u2828\u2817");
                        break;
                    case 'S':
                        rez.Append("\u2828\u280E");
                        break;
                    case 'T':
                        rez.Append("\u2828\u281E");
                        break;
                    case 'U':
                        rez.Append("\u2828\u2825");
                        break;
                    case 'V':
                        rez.Append("\u2828\u2827");
                        break;
                    case 'W':
                        rez.Append("\u2828\u283A");
                        break;
                    case 'X':
                        rez.Append("\u2828\u282D");
                        break;
                    case 'Y':
                        rez.Append("\u2828\u283D");
                        break;
                    case 'Z':
                        rez.Append("\u2828\u2835");
                        break;
                    case 'а':
                        rez.Append("\u2801");
                        break;
                    case 'б':
                        rez.Append("\u2803");
                        break;
                    case 'в':
                        rez.Append("\u283A");
                        break;
                    case 'г':
                        rez.Append("\u281B");
                        break;
                    case 'д':
                        rez.Append("\u2819");
                        break;
                    case 'е':
                        rez.Append("\u2811");
                        break;
                    case 'ё':
                        rez.Append("\u2821");
                        break;
                    case 'ж':
                        rez.Append("\u281A");
                        break;
                    case 'з':
                        rez.Append("\u2835");
                        break;
                    case 'и':
                        rez.Append("\u280A");
                        break;
                    case 'й':
                        rez.Append("\u282F");
                        break;
                    case 'к':
                        rez.Append("\u2805");
                        break;
                    case 'л':
                        rez.Append("\u2807");
                        break;
                    case 'м':
                        rez.Append("\u280D");
                        break;
                    case 'н':
                        rez.Append("\u281D");
                        break;
                    case 'о':
                        rez.Append("\u2815");
                        break;
                    case 'п':
                        rez.Append("\u280F");
                        break;
                    case 'р':
                        rez.Append("\u2817");
                        break;
                    case 'с':
                        rez.Append("\u280E");
                        break;
                    case 'т':
                        rez.Append("\u281E");
                        break;
                    case 'у':
                        rez.Append("\u2825");
                        break;
                    case 'ф':
                        rez.Append("\u280B");
                        break;
                    case 'х':
                        rez.Append("\u2813");
                        break;
                    case 'ц':
                        rez.Append("\u2809");
                        break;
                    case 'ч':
                        rez.Append("\u281F");
                        break;
                    case 'ш':
                        rez.Append("\u2831");
                        break;
                    case 'щ':
                        rez.Append("\u282D");
                        break;
                    case 'ъ':
                        rez.Append("\u2837");
                        break;
                    case 'ы':
                        rez.Append("\u282E");
                        break;
                    case 'ь':
                        rez.Append("\u283E");
                        break;
                    case 'э':
                        rez.Append("\u282A");
                        break;
                    case 'ю':
                        rez.Append("\u2833");
                        break;
                    case 'я':
                        rez.Append("\u282B");
                        break;
                    case 'А':
                        rez.Append("\u2818\u2801");
                        break;
                    case 'Б':
                        rez.Append("\u2818\u2803");
                        break;
                    case 'В':
                        rez.Append("\u2818\u283A");
                        break;
                    case 'Г':
                        rez.Append("\u2818\u281B");
                        break;
                    case 'Д':
                        rez.Append("\u2818\u2819");
                        break;
                    case 'Е':
                        rez.Append("\u2818\u2811");
                        break;
                    case 'Ё':
                        rez.Append("\u2818\u2821");
                        break;
                    case 'Ж':
                        rez.Append("\u2818\u281A");
                        break;
                    case 'З':
                        rez.Append("\u2818\u2835");
                        break;
                    case 'И':
                        rez.Append("\u2818\u280A");
                        break;
                    case 'Й':
                        rez.Append("\u2818\u282F");
                        break;
                    case 'К':
                        rez.Append("\u2818\u2805");
                        break;
                    case 'Л':
                        rez.Append("\u2818\u2807");
                        break;
                    case 'М':
                        rez.Append("\u2818\u280D");
                        break;
                    case 'Н':
                        rez.Append("\u2818\u281D");
                        break;
                    case 'О':
                        rez.Append("\u2818\u2815");
                        break;
                    case 'П':
                        rez.Append("\u2818\u280F");
                        break;
                    case 'Р':
                        rez.Append("\u2818\u2817");
                        break;
                    case 'С':
                        rez.Append("\u2818\u280E");
                        break;
                    case 'Т':
                        rez.Append("\u2818\u281E");
                        break;
                    case 'У':
                        rez.Append("\u2818\u2825");
                        break;
                    case 'Ф':
                        rez.Append("\u2818\u280B");
                        break;
                    case 'Х':
                        rez.Append("\u2818\u2813");
                        break;
                    case 'Ц':
                        rez.Append("\u2818\u2809");
                        break;
                    case 'Ч':
                        rez.Append("\u2818\u281F");
                        break;
                    case 'Ш':
                        rez.Append("\u2818\u2831");
                        break;
                    case 'Щ':
                        rez.Append("\u2818\u282D");
                        break;
                    case 'Ъ':
                        rez.Append("\u2818\u2837");
                        break;
                    case 'Ы':
                        rez.Append("\u2818\u282E");
                        break;
                    case 'Ь':
                        rez.Append("\u2818\u283E");
                        break;
                    case 'Э':
                        rez.Append("\u2818\u282A");
                        break;
                    case 'Ю':
                        rez.Append("\u2818\u2833");
                        break;
                    case 'Я':
                        rez.Append("\u2818\u282B");
                        break;
                    case ' ':
                        rez.Append("  ");
                        break;
                    case '.':
                        rez.Append("\u2832");
                        break;
                    case ',':
                        rez.Append("\u2802");
                        break;
                    case '!':
                        rez.Append("\u2816");
                        break;
                    case '(':
                        rez.Append("\u2823");
                        break;
                    case ')':
                        rez.Append("\u281C");
                        break;
                    case '{':
                        rez.Append("\u282A");
                        break;
                    case '}':
                        rez.Append("\u2815");
                        break;
                    case ';':
                        rez.Append("\u2806");
                        break;
                    case '?':
                        rez.Append("\u2822");
                        break;
                    case '-':
                        rez.Append("\u2824");
                        break;
                    case ':':
                        rez.Append("\u2812");
                        break;
                    default:
                        rez.Append("\u274C");
                        break;
                }
            }
            TextBox2.Text = rez.ToString();
            rez.Clear();
        }
        
        private void del_Click(object sender, RoutedEventArgs e)
        {
            rez.Remove(rez.Length - 1, 1);
            TextBox3.Text = rez.ToString();
        }

        private void delall_Click(object sender, RoutedEventArgs e)
        {
            rez.Clear();
            TextBox3.Text = rez.ToString();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow m1 = new MainWindow();
            m1.Show();
            this.Close();
        }

        private void settings_Click(object sender, RoutedEventArgs e)
        {
            settings s = new settings();
            s.Owner = this;
            s.ShowDialog();
        }

        private void ButtonA_Click(object sender, RoutedEventArgs e)
        {
            rez.Append("a");
            TextBox3.Text = rez.ToString();
        }

        private void ButtonB_Click(object sender, RoutedEventArgs e)
        {
            rez.Append("b");
            TextBox3.Text = rez.ToString();
        }

        private void ButtonC_Click(object sender, RoutedEventArgs e)
        {
            rez.Append("c");
            TextBox3.Text = rez.ToString();
        }

        private void ButtonD_Click(object sender, RoutedEventArgs e)
        {
            rez.Append("d");
            TextBox3.Text = rez.ToString();
        }

        private void ButtonE_Click(object sender, RoutedEventArgs e)
        {
            rez.Append("e");
            TextBox3.Text = rez.ToString();
        }

        private void ButtonF_Click(object sender, RoutedEventArgs e)
        {
            rez.Append("f");
            TextBox3.Text = rez.ToString();
        }

        private void ButtonG_Click(object sender, RoutedEventArgs e)
        {
            rez.Append("g");
            TextBox3.Text = rez.ToString();
        }

        private void ButtonH_Click(object sender, RoutedEventArgs e)
        {
            rez.Append("h");
            TextBox3.Text = rez.ToString();
        }

        private void ButtonI_Click(object sender, RoutedEventArgs e)
        {
            rez.Append("i");
            TextBox3.Text = rez.ToString();
        }

        private void ButtonJ_Click(object sender, RoutedEventArgs e)
        {
            rez.Append("j");
            TextBox3.Text = rez.ToString();
        }

        private void ButtonK_Click(object sender, RoutedEventArgs e)
        {
            rez.Append("k");
            TextBox3.Text = rez.ToString();
        }

        private void ButtonL_Click(object sender, RoutedEventArgs e)
        {
            rez.Append("l");
            TextBox3.Text = rez.ToString();
        }

        private void ButtonM_Click(object sender, RoutedEventArgs e)
        {
            rez.Append("m");
            TextBox3.Text = rez.ToString();
        }

        private void ButtonN_Click(object sender, RoutedEventArgs e)
        {
            rez.Append("n");
            TextBox3.Text = rez.ToString();
        }

        private void ButtonO_Click(object sender, RoutedEventArgs e)
        {
            rez.Append("o");
            TextBox3.Text = rez.ToString();
        }

        private void ButtonP_Click(object sender, RoutedEventArgs e)
        {
            rez.Append("p");
            TextBox3.Text = rez.ToString();
        }

        private void ButtonQ_Click(object sender, RoutedEventArgs e)
        {
            rez.Append("q");
            TextBox3.Text = rez.ToString();
        }

        private void ButtonR_Click(object sender, RoutedEventArgs e)
        {
            rez.Append("r");
            TextBox3.Text = rez.ToString();
        }

        private void ButtonS_Click(object sender, RoutedEventArgs e)
        {
            rez.Append("s");
            TextBox3.Text = rez.ToString();
        }

        private void ButtonT_Click(object sender, RoutedEventArgs e)
        {
            rez.Append("t");
            TextBox3.Text = rez.ToString();
        }

        private void ButtonU_Click(object sender, RoutedEventArgs e)
        {
            rez.Append("u");
            TextBox3.Text = rez.ToString();
        }

        private void ButtonV_Click(object sender, RoutedEventArgs e)
        {
            rez.Append("v");
            TextBox3.Text = rez.ToString();
        }

        private void ButtonW_Click(object sender, RoutedEventArgs e)
        {
            rez.Append("w");
            TextBox3.Text = rez.ToString();
        }

        private void ButtonX_Click(object sender, RoutedEventArgs e)
        {
            rez.Append("x");
            TextBox3.Text = rez.ToString();
        }

        private void ButtonY_Click(object sender, RoutedEventArgs e)
        {
            rez.Append("y");
            TextBox3.Text = rez.ToString();
        }

        private void ButtonZ_Click(object sender, RoutedEventArgs e)
        {
            rez.Append("z");
            TextBox3.Text = rez.ToString();
        }

        private void Buttonr1_Click(object sender, RoutedEventArgs e)
        {
            rez.Append("а");
            TextBox3.Text = rez.ToString();
        }

        private void Buttonr2_Click(object sender, RoutedEventArgs e)
        {
            rez.Append("б");
            TextBox3.Text = rez.ToString();
        }

        private void Buttonr3_Click(object sender, RoutedEventArgs e)
        {
            rez.Append("в");
            TextBox3.Text = rez.ToString();
        }

        private void Buttonr4_Click(object sender, RoutedEventArgs e)
        {
            rez.Append("г");
            TextBox3.Text = rez.ToString();
        }

        private void Buttonr5_Click(object sender, RoutedEventArgs e)
        {
            rez.Append("д");
            TextBox3.Text = rez.ToString();
        }

        private void Buttonr6_Click(object sender, RoutedEventArgs e)
        {
            rez.Append("е");
            TextBox3.Text = rez.ToString();
        }

        private void Buttonr7_Click(object sender, RoutedEventArgs e)
        {
            rez.Append("ё");
            TextBox3.Text = rez.ToString();
        }

        private void Buttonr8_Click(object sender, RoutedEventArgs e)
        {
            rez.Append("ж");
            TextBox3.Text = rez.ToString();
        }

        private void Buttonr9_Click(object sender, RoutedEventArgs e)
        {
            rez.Append("з");
            TextBox3.Text = rez.ToString();
        }

        private void Buttonr10_Click(object sender, RoutedEventArgs e)
        {
            rez.Append("и");
            TextBox3.Text = rez.ToString();
        }

        private void Buttonr11_Click(object sender, RoutedEventArgs e)
        {
            rez.Append("й");
            TextBox3.Text = rez.ToString();
        }

        private void Buttonr12_Click(object sender, RoutedEventArgs e)
        {
            rez.Append("к");
            TextBox3.Text = rez.ToString();
        }

        private void Buttonr13_Click(object sender, RoutedEventArgs e)
        {
            rez.Append("л");
            TextBox3.Text = rez.ToString();
        }

        private void Buttonr14_Click(object sender, RoutedEventArgs e)
        {
            rez.Append("м");
            TextBox3.Text = rez.ToString();
        }

        private void Buttonr15_Click(object sender, RoutedEventArgs e)
        {
            rez.Append("н");
            TextBox3.Text = rez.ToString();
        }

        private void Buttonr16_Click(object sender, RoutedEventArgs e)
        {
            rez.Append("о");
            TextBox3.Text = rez.ToString();
        }

        private void Buttonr17_Click(object sender, RoutedEventArgs e)
        {
            rez.Append("п");
            TextBox3.Text = rez.ToString();
        }

        private void Buttonr18_Click(object sender, RoutedEventArgs e)
        {
            rez.Append("р");
            TextBox3.Text = rez.ToString();
        }

        private void Buttonr19_Click(object sender, RoutedEventArgs e)
        {
            rez.Append("с");
            TextBox3.Text = rez.ToString();
        }

        private void Buttonr20_Click(object sender, RoutedEventArgs e)
        {
            rez.Append("т");
            TextBox3.Text = rez.ToString();
        }

        private void Buttonr21_Click(object sender, RoutedEventArgs e)
        {
            rez.Append("у");
            TextBox3.Text = rez.ToString();
        }

        private void Buttonr22_Click(object sender, RoutedEventArgs e)
        {
            rez.Append("ф");
            TextBox3.Text = rez.ToString();
        }

        private void Buttonr23_Click(object sender, RoutedEventArgs e)
        {
            rez.Append("х");
            TextBox3.Text = rez.ToString();
        }

        private void Buttonr24_Click(object sender, RoutedEventArgs e)
        {
            rez.Append("ц");
            TextBox3.Text = rez.ToString();
        }

        private void Buttonr25_Click(object sender, RoutedEventArgs e)
        {
            rez.Append("ч");
            TextBox3.Text = rez.ToString();
        }

        private void Buttonr26_Click(object sender, RoutedEventArgs e)
        {
            rez.Append("ш");
            TextBox3.Text = rez.ToString();
        }

        private void Buttonr27_Click(object sender, RoutedEventArgs e)
        {
            rez.Append("щ");
            TextBox3.Text = rez.ToString();
        }

        private void Buttonr28_Click(object sender, RoutedEventArgs e)
        {
            rez.Append("ъ");
            TextBox3.Text = rez.ToString();
        }

        private void Buttonr29_Click(object sender, RoutedEventArgs e)
        {
            rez.Append("ы");
            TextBox3.Text = rez.ToString();
        }

        private void Buttonr30_Click(object sender, RoutedEventArgs e)
        {
            rez.Append("ь");
            TextBox3.Text = rez.ToString();
        }

        private void Buttonr31_Click(object sender, RoutedEventArgs e)
        {
            rez.Append("э");
            TextBox3.Text = rez.ToString();
        }

        private void Buttonr32_Click(object sender, RoutedEventArgs e)
        {
            rez.Append("ю");
            TextBox3.Text = rez.ToString();
        }

        private void Buttonr33_Click(object sender, RoutedEventArgs e)
        {
            rez.Append("я");
            TextBox3.Text = rez.ToString();
        }

        private void textbox4_TextChanged(object sender, TextChangedEventArgs e)
        {
            string s = textbox4.Text;
            simvols = s.ToList();
            foreach (char item in simvols)
            {
                switch (item)
                {
                    case 'a':
                        rez.Append("'4'");
                        break;
                    case 'b':
                        rez.Append("'45'");
                        break;
                    case 'c':
                        rez.Append("'41'");
                        break;
                    case 'd':
                        rez.Append("'412'");
                        break;
                    case 'e':
                        rez.Append("'24'");
                        break;
                    case 'f':
                        rez.Append("'541'");
                        break;
                    case 'g':
                        rez.Append("'1245'");
                        break;
                    case 'h':
                        rez.Append("'452'");
                        break;
                    case 'i':
                        rez.Append("'51'");
                        break;
                    case 'j':
                        rez.Append("'125'");
                        break;
                    case 'k':
                        rez.Append("'46'");
                        break;
                    case 'l':
                        rez.Append("'456'");
                        break;
                    case 'm':
                        rez.Append("'146'");
                        break;
                    case 'n':
                        rez.Append("'1246'");
                        break;
                    case 'o':
                        rez.Append("'426'");
                        break;
                    case 'p':
                        rez.Append("'1456'");
                        break;
                    case 'q':
                        rez.Append("'12345'");
                        break;
                    case 'r':
                        rez.Append("'2456'");
                        break;
                    case 's':
                        rez.Append("'156'");
                        break;
                    case 't':
                        rez.Append("'1256'");
                        break;
                    case 'u':
                        rez.Append("'463'");
                        break;
                    case 'v':
                        rez.Append("'3456'");
                        break;
                    case 'w':
                        rez.Append("'1235'");
                        break;
                    case 'x':
                        rez.Append("'4163'");
                        break;
                    case 'y':
                        rez.Append("'12346'");
                        break;
                    case 'z':
                        rez.Append("'2346'");
                        break;
                    case 'а':
                        rez.Append("'4'");
                        break;
                    case 'б':
                        rez.Append("'45'");
                        break;
                    case 'в':
                        rez.Append("'1235'");
                        break;
                    case 'г':
                        rez.Append("'1245'");
                        break;
                    case 'д':
                        rez.Append("'124'");
                        break;
                    case 'е':
                        rez.Append("'24'");
                        break;
                    case 'ё':
                        rez.Append("'34'");
                        break;
                    case 'ж':
                        rez.Append("'125'");
                        break;
                    case 'з':
                        rez.Append("'1356'");
                        break;
                    case 'и':
                        rez.Append("'15'");
                        break;
                    case 'й':
                        rez.Append("'13456'");
                        break;
                    case 'к':
                        rez.Append("'46'");
                        break;
                    case 'л':
                        rez.Append("'456'");
                        break;
                    case 'м':
                        rez.Append("'146'");
                        break;
                    case 'н':
                        rez.Append("'1246'");
                        break;
                    case 'о':
                        rez.Append("'246'");
                        break;
                    case 'п':
                        rez.Append("'1456'");
                        break;
                    case 'р':
                        rez.Append("'2456'");
                        break;
                    case 'с':
                        rez.Append("'156'");
                        break;
                    case 'т':
                        rez.Append("'1256'");
                        break;
                    case 'у':
                        rez.Append("'346'");
                        break;
                    case 'ф':
                        rez.Append("'145'");
                        break;
                    case 'х':
                        rez.Append("'245'");
                        break;
                    case 'ц':
                        rez.Append("'14'");
                        break;
                    case 'ч':
                        rez.Append("'12456'");
                        break;
                    case 'ш':
                        rez.Append("'234'");
                        break;
                    case 'щ':
                        rez.Append("'1346'");
                        break;
                    case 'ъ':
                        rez.Append("'23456'");
                        break;
                    case 'ы':
                        rez.Append("'4623'");
                        break;
                    case 'ь':
                        rez.Append("'12356'");
                        break;
                    case 'э':
                        rez.Append("'135'");
                        break;
                    case 'ю':
                        rez.Append("'2345'");
                        break;
                    case 'я':
                        rez.Append("'1345'");
                        break;
                    case 'A':
                        rez.Append("'13''4'");
                        break;
                    case 'B':
                        rez.Append("'13''45'");
                        break;
                    case 'C':
                        rez.Append("'13''41'");
                        break;
                    case 'D':
                        rez.Append("'13''412'");
                        break;
                    case 'E':
                        rez.Append("'13''24'");
                        break;
                    case 'F':
                        rez.Append("'13''541'");
                        break;
                    case 'G':
                        rez.Append("'13''1245'");
                        break;
                    case 'H':
                        rez.Append("'13''452'");
                        break;
                    case 'I':
                        rez.Append("'13''51'");
                        break;
                    case 'J':
                        rez.Append("'13''125'");
                        break;
                    case 'K':
                        rez.Append("'13''46'");
                        break;
                    case 'L':
                        rez.Append("'13''456'");
                        break;
                    case 'M':
                        rez.Append("'13''146'");
                        break;
                    case 'N':
                        rez.Append("'13''1246'");
                        break;
                    case 'O':
                        rez.Append("'13''426'");
                        break;
                    case 'P':
                        rez.Append("'13''1456'");
                        break;
                    case 'Q':
                        rez.Append("'13''12345'");
                        break;
                    case 'R':
                        rez.Append("'13''2456'");
                        break;
                    case 'S':
                        rez.Append("'13''156'");
                        break;
                    case 'T':
                        rez.Append("'13''1256'");
                        break;
                    case 'U':
                        rez.Append("'13''463'");
                        break;
                    case 'V':
                        rez.Append("'13''3456'");
                        break;
                    case 'W':
                        rez.Append("'13''1235'");
                        break;
                    case 'X':
                        rez.Append("'13''4163'");
                        break;
                    case 'Y':
                        rez.Append("'13''12346'");
                        break;
                    case 'Z':
                        rez.Append("'13''2346'");
                        break;
                    case 'А':
                        rez.Append("'12''4'");
                        break;
                    case 'Б':
                        rez.Append("'12''45'");
                        break;
                    case 'В':
                        rez.Append("'12''1235'");
                        break;
                    case 'Г':
                        rez.Append("'12''1245'");
                        break;
                    case 'Д':
                        rez.Append("'12''124'");
                        break;
                    case 'Е':
                        rez.Append("'12''24'");
                        break;
                    case 'Ё':
                        rez.Append("'12''34'");
                        break;
                    case 'Ж':
                        rez.Append("'12''125'");
                        break;
                    case 'З':
                        rez.Append("'12''1356'");
                        break;
                    case 'И':
                        rez.Append("'12''15'");
                        break;
                    case 'Й':
                        rez.Append("'12''13456'");
                        break;
                    case 'К':
                        rez.Append("'12''46'");
                        break;
                    case 'Л':
                        rez.Append("'12''456'");
                        break;
                    case 'М':
                        rez.Append("'12''146'");
                        break;
                    case 'Н':
                        rez.Append("'12''1246'");
                        break;
                    case 'О':
                        rez.Append("'12''246'");
                        break;
                    case 'П':
                        rez.Append("'12''1456'");
                        break;
                    case 'Р':
                        rez.Append("'12''2456'");
                        break;
                    case 'С':
                        rez.Append("'12''156'");
                        break;
                    case 'Т':
                        rez.Append("'12''1256'");
                        break;
                    case 'У':
                        rez.Append("'12''346'");
                        break;
                    case 'Ф':
                        rez.Append("'12''145'");
                        break;
                    case 'Х':
                        rez.Append("'12''245'");
                        break;
                    case 'Ц':
                        rez.Append("'12''14'");
                        break;
                    case 'Ч':
                        rez.Append("'12''12456'");
                        break;
                    case 'Ш':
                        rez.Append("'12''234'");
                        break;
                    case 'Щ':
                        rez.Append("'12''1346'");
                        break;
                    case 'Ъ':
                        rez.Append("'12''23456'");
                        break;
                    case 'Ы':
                        rez.Append("'12''4623'");
                        break;
                    case 'Ь':
                        rez.Append("'12''12356'");
                        break;
                    case 'Э':
                        rez.Append("'12''135'");
                        break;
                    case 'Ю':
                        rez.Append("'12''2345'");
                        break;
                    case 'Я':
                        rez.Append("'12''1345'");
                        break;
                    case ' ':
                        rez.Append(" ");
                        break;
                    case '.':
                        rez.Append("'235'");
                        break;
                    case ',':
                        rez.Append("'5'");
                        break;
                    default:
                        break;
                }
            }
            textbox5.Text = rez.ToString();
            rez.Clear();
        }

        private void spacebtn_Click(object sender, RoutedEventArgs e)
        {
            rez.Append(" ");
            TextBox3.Text = rez.ToString();
        }
    }
}
