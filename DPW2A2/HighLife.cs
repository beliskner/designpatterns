namespace ConwayGameOfLife
{
    public class HighLife : ConwayGameOfLife
    {
        public override bool CellShouldLive(bool livingCell, int neighbourCount)
        {
            // B36/S23
            return livingCell switch
            {
                // a cell is born if it has 3 or 6 neighbors
                false when (neighbourCount == 3 || neighbourCount == 6) => true,
                // a cell survives if it has 2 or 3 neighbors
                true when (neighbourCount == 2 || neighbourCount == 3) => true,
                _ => false
            };
        }
    }
}