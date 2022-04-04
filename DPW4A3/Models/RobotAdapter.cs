namespace DPW4A3.Models
{
    public class RobotAdapter : IAttacker
    {

        public string Driver { get; set; }
        private Robot Robot { get; set; }

        public RobotAdapter() => Robot = new Robot();

        public void AssignDriver(string driverName)
        {
            Robot.MoveByPerson(driverName);
            Driver = Robot.Person;
        }

        public void DriveForward()
        {
            Robot.WalkForward();
        }

        public void UseWeapon()
        {
            Robot.BashWithHands();
        }
    }
}