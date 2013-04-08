using System;
using System.Collections.Generic;
using System.Linq;
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
using System.ComponentModel;

namespace TestWpfProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public event EventHandler _heightChanged;

        public MainWindow()
        {
            InitializeComponent();
            _heightChanged +=new EventHandler(MainWindow__heightChanged);
        }

        private void MainWindow__heightChanged(object sender, EventArgs e) 
        {
            statusTextBlock.Text = "Height Changed";
        }

        private void Change_H_Btn(object sender, RoutedEventArgs e)
        {
            redRectangle.Height += 20;
        }

        /// <summary>
        /// Dependency Property registering 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Attach_Event_Button(object sender, RoutedEventArgs e) 
        {
            DependencyPropertyDescriptor dp;
            dp = DependencyPropertyDescriptor.FromProperty(
                Rectangle.HeightProperty, typeof(Rectangle));
            dp.AddValueChanged(redRectangle, _heightChanged);
        }

        private void Reset_Text(object sender, RoutedEventArgs e)
        {
            statusTextBlock.Text = "hmm hmm hmm";
        }

        private void Detach_Event_Button(object sender, RoutedEventArgs e)
        {
            DependencyPropertyDescriptor dp;
            dp = DependencyPropertyDescriptor.FromProperty(
                Rectangle.HeightProperty, typeof(Rectangle));
            dp.RemoveValueChanged(redRectangle, _heightChanged);
        }

    }
}
