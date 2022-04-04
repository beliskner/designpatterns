namespace DPW4A3.Models
{
    public interface IAttacker
    {
        string Driver { get; set; }

        void AssignDriver(string driverName);
        void DriveForward();
        void UseWeapon();
    }
}