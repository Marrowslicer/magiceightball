using System;
using System.Threading;
using System.Windows;
using System.Windows.Input;

namespace MagicEightBall
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

        private void CommandButton_OnClick(object sender, RoutedEventArgs e)
        {
            // Artificial delay.
            Cursor = Cursors.Wait;
            Thread.Sleep(TimeSpan.FromSeconds(1));

            var answer = AnswerGenerator.GenerateAnswer();
            AnswerTextBox.Text = answer;

            Cursor = null;
        }
    }
}
