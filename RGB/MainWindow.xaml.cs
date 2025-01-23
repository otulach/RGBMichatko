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

namespace RGB
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void colorChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            byte red = (byte)redSlider.Value;
            byte green = (byte)greenSlider.Value;
            byte blue = (byte)blueSlider.Value;

            rectangle.Fill = new SolidColorBrush(Color.FromRgb(red, green, blue));

            redT.Text = red.ToString();
            greenT.Text = green.ToString();
            blueT.Text = blue.ToString();
        }

        private void textChanged(object sender, TextChangedEventArgs e)
        {
            byte red;
            byte blue;
            byte green;

            if (redT.Text != "")
            {
                if (byte.TryParse(redT.Text, out red))
                {
                    if (red < 0 | red > 255)
                    {
                        MessageBox.Show("Můžete zadávat jen hodnoty v rozmezí 0-255");
                    }
                    redSlider.Value = red;
                }
                else
                {
                    MessageBox.Show("Můžete zadávat jen hodnoty v rozmezí 0-255");
                }
            }

            if (blueT.Text != "")
            {
                if (byte.TryParse(blueT.Text, out blue))
                {
                    if (blue < 0 | blue > 255)
                    {
                        MessageBox.Show("Můžete zadávat jen hodnoty v rozmezí 0-255");
                    }
                    blueSlider.Value = blue;
                }
                else
                {
                    MessageBox.Show("Můžete zadávat jen hodnoty v rozmezí 0-255");
                }
            }

            if (greenT.Text != "")
            {
                if (byte.TryParse(greenT.Text, out green))
                {
                    if (green < 0 | green > 255)
                    {
                        MessageBox.Show("Můžete zadávat jen hodnoty v rozmezí 0-255");
                    }
                    greenSlider.Value = green;
                }
                else
                {
                    MessageBox.Show("Můžete zadávat jen hodnoty v rozmezí 0-255");
                }
            }
        }
    }
}