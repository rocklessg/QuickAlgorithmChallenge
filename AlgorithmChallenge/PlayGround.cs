namespace AlgorithmChallenge
{
    internal class PlayGround
    {

    }

    public class Asset
    {
        public string Name;
        public virtual Asset Clone() => new Asset { Name = Name };
    }
    public class House : Asset
    {
        public decimal Mortgage;
        public override House Clone() => new House
        { Name = Name, Mortgage = Mortgage };
    }
}
