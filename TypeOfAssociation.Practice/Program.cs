namespace TypeOfAssociation.Practice
{
    public class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new("q", 0.5, "a");
            Product pr1 = new("Asus", 2250, 1.8);
            pr1.Discount();
            book1.ShowInfo();

            Shape shape = new("red");
            Circle circle = new("red", 5);
            Rectangle rectangle = new("red", 5, 6);
            shape.GetInfo();
            circle.GetInfo();
            rectangle.GetInfo();


        }
    }
}
