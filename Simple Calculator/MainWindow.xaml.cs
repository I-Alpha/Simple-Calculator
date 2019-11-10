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

namespace Simple_Calculator
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

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int num1 = Convert.ToInt32(textBox.Text); 
            int num2 = Convert.ToInt32(textBox1.Text);

            int num3 = num1 + num2;

            textBox2.Text = Convert.ToString(num3); 

            MessageBox.Show("Operation Complete");
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            int num1 = Convert.ToInt32(textBox.Text);
            int num2 = Convert.ToInt32(textBox1.Text);

            int num3 = num1 * num2;

            textBox2.Text = Convert.ToString(num3);

            MessageBox.Show("Operation Complete");

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            int num1 = Convert.ToInt32(textBox.Text);
            int num2 = Convert.ToInt32(textBox1.Text);

            int num3 = num1 - num2;

            textBox2.Text = Convert.ToString(num3);

            MessageBox.Show("Operation Complete");
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            int num1 = Convert.ToInt32(textBox.Text);
            int num2 = Convert.ToInt32(textBox1.Text);

            int num3 = num1 / num2;

            textBox2.Text = Convert.ToString(num3);

            MessageBox.Show("Operation Complete");
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
//bool functions for input control 
        private bool IsNumberKey(Key inKey)                  //numberkeys and numpad
        {
            if (inKey < Key.D0 || inKey > Key.D9)
            {
                if (inKey < Key.NumPad0 || inKey > Key.NumPad9)
                {
                    return false;
                }
            }
            return true;
        }
        private bool IsDelOrBackspaceOrTabKey(Key inKey)      //backspace,del
        {
            return inKey == Key.Delete || inKey == Key.Back || inKey == Key.Tab;
        }
//end


        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = !IsNumberKey(e.Key) && !IsDelOrBackspaceOrTabKey(e.Key);
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = !IsNumberKey(e.Key) && !IsDelOrBackspaceOrTabKey(e.Key);
        }
    }
}
