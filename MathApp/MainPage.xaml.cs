using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MathApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void boxerror()
        {
            boxResult.Text = "Invalid number format!";
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int result = int.Parse(boxFirstNumber.Text) + int.Parse(boxSecondNumber.Text);
                boxResult.Text = $"{boxFirstNumber.Text} + {boxSecondNumber.Text} = {result.ToString()}";
            }
            catch (FormatException)
            {
                boxerror();
            }
            
        }

        private void btnSubtract_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int result = int.Parse(boxFirstNumber.Text) - int.Parse(boxSecondNumber.Text);
                boxResult.Text = boxResult.Text = $"{boxFirstNumber.Text} - {boxSecondNumber.Text} = {result.ToString()}";
            }
            catch (FormatException)
            {
                boxerror();
            }
            
        }

        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int result = int.Parse(boxFirstNumber.Text) * int.Parse(boxSecondNumber.Text);
                boxResult.Text = boxResult.Text = $"{boxFirstNumber.Text} x {boxSecondNumber.Text} = {result.ToString()}";
            }
            catch (FormatException)
            {
                boxerror();
            }
            
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int result = int.Parse(boxFirstNumber.Text) / int.Parse(boxSecondNumber.Text);
                boxResult.Text = boxResult.Text = $"{boxFirstNumber.Text} / {boxSecondNumber.Text} = {result.ToString()}";
            }
            catch (DivideByZeroException)
            {
                boxResult.Text = "Division by Zero not allowed!";
            }    
            catch (FormatException)
            {
                boxerror();
            }
        }

        private async void btnExit_Click(object sender, RoutedEventArgs e)
        {
            MessageDialog msg = new MessageDialog("Are you sure you want to exit?");
            await msg.ShowAsync();

            Application.Current.Exit();
        }
    }
}