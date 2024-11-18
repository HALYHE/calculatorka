using calculatorka;
using System;
using System.Windows;

namespace WpfApp
{
    public partial class MainWindow : Window
    {
        private Calculator calculator = new Calculator();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            double num1 = double.Parse(FirstNumberTextBox.Text);
            double num2 = double.Parse(SecondNumberTextBox.Text);
            double result = calculator.Add(num1, num2);
            ResultLabel.Content = "Результат: " + result;
        }

        private void SubtractButton_Click(object sender, RoutedEventArgs e)
        {
            double num1 = double.Parse(FirstNumberTextBox.Text);
            double num2 = double.Parse(SecondNumberTextBox.Text);
            double result = calculator.Subtract(num1, num2);
            ResultLabel.Content = "Результат: " + result;
        }

        private void MultiplyButton_Click(object sender, RoutedEventArgs e)
        {
            double num1 = double.Parse(FirstNumberTextBox.Text);
            double num2 = double.Parse(SecondNumberTextBox.Text);
            double result = calculator.Multiply(num1, num2);
            ResultLabel.Content = "Результат: " + result;
        }

        private void DivideButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double num1 = double.Parse(FirstNumberTextBox.Text);
                double num2 = double.Parse(SecondNumberTextBox.Text);
                double result = calculator.Divide(num1, num2);
                ResultLabel.Content = "Результат: " + result;
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
