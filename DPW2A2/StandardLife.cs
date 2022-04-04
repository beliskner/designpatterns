namespace ConwayGameOfLife
{
    public class StandardLife : ConwayGameOfLife
    {
        public override bool CellShouldLive(bool livingCell, int neighbourCount)
        {
            // B3/S23
            return livingCell switch
            {
                // a cell is born if it has 3 neighbors
                false when neighbourCount == 3 => true,
                // a cell survives if it has 2 or 3 neighbors
                true when (neighbourCount == 2 || neighbourCount == 3) => true,
                _ => false
            };
        }
    }
}