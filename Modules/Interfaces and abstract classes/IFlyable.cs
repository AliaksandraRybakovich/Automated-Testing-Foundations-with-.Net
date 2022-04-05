namespace Modules.Interfaces_and_abstract_classes
{
    internal interface IFlyable
    {
        string FlyTo(Coordinates destinationPoint); 
        double GetFlyTime(Coordinates destinationPoint);
    }
}
