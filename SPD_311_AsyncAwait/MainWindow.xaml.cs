using System.IO;
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

namespace SPD_311_AsyncAwait
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static Random random = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }
        //async -  allow method to use await keywords
        //await - wait task without freeze

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            //int value = GenerateValue();
            //Task<int> task=   Task.Run(GenerateValue);
            //task.Wait();//freeze
            //list.Items.Add(task.Result);//freeze
            /// 
            //int value = await task;
            //int value = await Task.Run(GenerateValue);
            //list.Items.Add(value);
            //list.Items.Add(await Task.Run(GenerateValue));
            //MessageBox.Show("Complete in button");
           

            list.Items.Add(await GenerateValueAsync());
            ///
            //File.Copy()
        }

        int GenerateValue()
        {
            Thread.Sleep(random.Next(5000));
            //MessageBox.Show("Complete");
            return random.Next(1000);
        }
        Task<int> GenerateValueAsync()
        {
            return Task.Run(() =>
            {
                Thread.Sleep(random.Next(5000));
                //MessageBox.Show("Complete");
                return random.Next(1000);
            });
         
        }
    }
}