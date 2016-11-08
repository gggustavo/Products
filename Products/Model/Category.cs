namespace Model
{
    public class Category
    {
        public int IdCategory { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}