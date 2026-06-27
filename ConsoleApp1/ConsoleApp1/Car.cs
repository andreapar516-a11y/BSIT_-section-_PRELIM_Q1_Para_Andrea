using TransportChallenge;
 public class Car : Vehicle, IDriveable
{
    public void Drive()
    {
        throw new NotImplementedException();
    }

    public override string Move()
    {
        return "Driving on the road.";
    }
}
