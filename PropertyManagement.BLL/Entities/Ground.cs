namespace PropertyManagement.BLL.Entities
{
    public class Ground : Property
    {
        public bool HasTrees { get; set; }
        public bool HasWater { get; set; }
        public bool HasPower { get; set; }
        public bool HasGas { get; set; }
    }
}
