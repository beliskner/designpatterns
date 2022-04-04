namespace ConwayGameOfLife.LifeBehaviour
{
    public interface ILifeBehaviour
    {
        bool CellShouldLive(bool livingCell, int neighbourCount);
    }
}