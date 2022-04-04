using System;
using System.Windows;
using System.Windows.Threading;

namespace ConwayGameOfLife
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ConwayGameOfLife game;
        private ConwayGameOfLifeDrawer drawer;

        public MainWindow()
        {
            InitializeComponent();

            // create a game
            game = new HighLife();
            drawer = new ConwayGameOfLifeDrawer(game, this.imgConway, 2);

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(20);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            game.Evolve();
            drawer.Draw();
        }
    }
}