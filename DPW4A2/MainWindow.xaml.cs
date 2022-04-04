using System;
using System.Windows;
using System.Windows.Threading;
using ConwayGameOfLife.LifeBehaviour;

namespace ConwayGameOfLife
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const int ImageStretch = 2;

        private ConwayGameOfLife game;
        private ConwayGameOfLifeDrawer drawer;
        private DispatcherTimer timer;

        private bool standardLife;
        private bool[,] glidergun;  // should work in standard life
        private bool[,] replicator;  // should work in high life

        public MainWindow()
        {
            InitializeComponent();

            drawer = new ConwayGameOfLifeDrawer();

            // create a game
            game = new ConwayGameOfLife();
            SetActiveLife(true);

            ConwayGameOfLifeReader gameReader = new ConwayGameOfLifeReader();
            this.glidergun = gameReader.Read("glidergun.txt");
            this.replicator = gameReader.Read("replicator.txt");

            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(100 - sliderSpeed.Value);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            game.Evolve();
            drawer.Draw();
        }

        private void btnResetSpace_Click(object sender, RoutedEventArgs e)
        {
            game.Reset();
        }

        private void btnClearSpace_Click(object sender, RoutedEventArgs e)
        {
            game.ClearSpace();
        }

        private void imgConway_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Point position = e.GetPosition(imgConway);

            int row = (int)position.Y / ImageStretch;
            int column = (int)position.X / ImageStretch;

            if (this.standardLife)
                game.StoreSpace(glidergun, row, column);
            else
                game.StoreSpace(replicator, row, column);
        }

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (timer != null)
            {
                timer.Interval = TimeSpan.FromMilliseconds(100 - sliderSpeed.Value);
            }
        }

        private void btnHighLife_Click(object sender, RoutedEventArgs e)
        {
            // change to HighLife here
            // todo...
            SetActiveLife(false);
        }

        private void btnStandardLife_Click(object sender, RoutedEventArgs e)
        {
            // change to StandardLife here
            // todo...
            SetActiveLife(true);
        }

        private void SetActiveLife(bool standardLife)
        {
            this.standardLife = standardLife;
            if (standardLife)
            {
                this.lblActiveLife.Content = "active life: standard life";
                this.game.LifeBehaviour = new StandardLifeBehaviour();
            }
            else
            {
                this.lblActiveLife.Content = "active life: high life";
                this.game.LifeBehaviour = new HighLifeBehaviour();
            }
            drawer.Initialize(game, this.imgConway, ImageStretch);
        }
    }
}