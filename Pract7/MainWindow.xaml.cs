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

namespace Pract7
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

        Equilateral equilateral;
        private void Отчистить_Click(object sender, RoutedEventArgs e)
        {
            inputValue.Text = null;
            outArea.Text = null;
        }

        private void О_Программе_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Использовать класс Triangle (треугольник) с полями-сторонами."+              
                " Создать производный класс Equilateral(равносторонний), имеющий поле площади."+
                " Определить метод вычисления площади.");
        }

        private void Выход_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Рассчитать_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                uint side = uint.Parse(inputValue.Text);//записываем введеное число в текст бокс

                equilateral=new Equilateral(side, side, side);//долно быть столько же переменных сколько и в классах

                equilateral.Area(out double perimeter);//обращаемся к производному классу 
                outArea.Text = perimeter.ToString();// записываем площадь в текст бокс    
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Объект не был создан!");
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("Данные должны быть больше 0");
            }
            catch (Exception ex)//все остальное ошибки
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
