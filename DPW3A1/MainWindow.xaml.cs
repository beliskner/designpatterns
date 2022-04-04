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
using DPW3A1.Controllers;
using DPW3A1.ObserverModels;

namespace DPW3A1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ITrainController _trainController;
        public MainWindow()
        {
            _trainController = new TrainController();
            InitializeComponent();
        }
        
        private void Next_Station_Button_Click(object sender, RoutedEventArgs e)
        {
            _trainController.NextStation();
        }
        
        private void New_Display_Button_Click(object sender, RoutedEventArgs e)
        {
            _trainController.NewDisplay();
        }
    }
}