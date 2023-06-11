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

namespace WpfControlsApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int count = 0;
        public MainWindow()
        {
            InitializeComponent();
            //stack.Children.Add(new TextBlock() { Text = "8756765"});
            for(int i = 0; i < 3; i++)
            {
                RadioButton rb = new RadioButton();
                rb.Content = "RB " + i.ToString();
                rb.Checked += RadioButton_Checked;

                stack1.Children.Add(rb);
            }
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            ++count;
            txt.Text = count.ToString();
        }

        private void RepeatButton_Click(object sender, RoutedEventArgs e)
        {
            ++count;
            txt.Text = count.ToString();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if(sender is RadioButton rb)
                txt.Text = rb.Content.ToString();

        }

        private void RepeatButton_MouseEnter(object sender, MouseEventArgs e)
        {
            popup.IsOpen = true;
        }

        private void RepeatButton_MouseLeave(object sender, MouseEventArgs e)
        {
            popup.IsOpen = false;
        }
    }
}
