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

namespace PR_22._101Nikolaenko3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try { 
                if (int.TryParse(TextBox.Text, out int inputText) &&
                    int.TryParse(minTextBox.Text, out int minValue) &&
                    int.TryParse(maxTextBox.Text, out int maxValue))
                {
                    Random random = new Random();
                    int[] array = new int[inputText];

                    for (int i = 0; i < inputText; i++)
                    {
                        array[i] = random.Next(minValue, maxValue + 1); 
                    }

                    int[] sortedArray = array.OrderBy(x => x % 2).ToArray();

                    resultTextBlock.Text = "Отсортированный массив: " + string.Join(", ", sortedArray);
                }
                else
                {
                    resultTextBlock.Text = "Пожалуйста, введите корректные числа.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
