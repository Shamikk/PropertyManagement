namespace PropertyManagement.BLL.Entities
{
    public class House : Property
    {
        public int Levels { get; set; }
        public int Rooms { get; set; }
        public bool HasGarrage { get; set; }
    }
}
