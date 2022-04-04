using System;

namespace ConwayGameOfLife
{
    public abstract class ConwayGameOfLife
    {
        const int WIDTH = 300;
        const int HEIGHT = 150;
        const int LIVECHANCE = 10; // each cell has a chance to be (initially) alive

        public bool[,] Space { get; private set; }

        // constructor
        public ConwayGameOfLife()
        {
            // make space for life
            this.Space = new bool[HEIGHT, WIDTH];

            InitializeLife();
        }

        // initialize space with random life
        private void InitializeLife()
        {
            Random random = new Random(DateTime.Now.Millisecond);

            // process each row
            for (int r = 0; r < HEIGHT; r++)
            {
                // process each column
                for (int c = 0; c < WIDTH; c++)
                {
                    // put random value in space (chance of live cell: <LIVECHANCE>%)
                    this.Space[r, c] = (random.Next(1, (100 / LIVECHANCE)) == 1);
                }
            }
        }

        public void Reset()
        {
            InitializeLife();
        }

        // evolve life
        public void Evolve()
        {
            // copy space for testing (not modified) cells
            bool[,] copySpace = new bool[HEIGHT, WIDTH];
            for (int r = 0; r < HEIGHT; r++)
                for (int c = 0; c < WIDTH; c++)
                    copySpace[r, c] = this.Space[r, c];

            // process each row
            for (int r = 0; r < HEIGHT; r++)
            {
                // process each column
                for (int c = 0; c < WIDTH; c++)
                {
                    // current cell live of dead? (use copy space!)
                    bool livingCell = copySpace[r, c];

                    // get number of live (surrounding) cells
                    int neighBourCount = GetLiveNeighbours(copySpace, r, c);

                    // cell should live?
                    this.Space[r, c] = CellShouldLive(livingCell, neighBourCount);
                }
            }
        }
        
        public abstract bool CellShouldLive(bool livingCell, int neighbourCount);

        /// <summary>Count live neighbours of given cell.</summary>
        /// <param name="space"></param>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <returns>number of live neighbours</returns>
        private int GetLiveNeighbours(bool[,] space, int row, int column)
        {
            int count = 0;

            for (int r = -1; r <= 1; r++)
            {
                for (int c = -1; c <= 1; c++)
                {
                    // skip middle cell 
                    if ((r == 0) && (c == 0)) continue;

                    int r2 = row + r;
                    if (r2 < 0)
                        r2 += HEIGHT;
                    else if (r2 >= HEIGHT)
                        r2 -= HEIGHT;

                    int c2 = column + c;
                    if (c2 < 0)
                        c2 += WIDTH;
                    else if (c2 >= WIDTH)
                        c2 -= WIDTH;

                    if (space[r2, c2])
                        count++;
                }
            }

            return count;
        }
    }
}