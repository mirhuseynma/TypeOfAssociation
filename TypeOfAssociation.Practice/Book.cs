namespace TypeOfAssociation.Practice
{
    public class Book:Product
    {
        public string Genre;
        public int ThisInput;

        public Book(string name, double price, string genre) : base(name, price)
        {
            Genre = genre;
        }

       
        
        public void ShowInfo()
        {
            int bookClass = 0;
            Console.WriteLine("Ne qeder kitab elave etmek istediyinizi yazin!");
            ThisInput = Convert.ToInt32(Console.ReadLine());
            Book[] books = new Book[ThisInput];
            for(int i = 0; i<ThisInput; i++)
            {
                Console.WriteLine($"{i + 1}. kitabin melumatlarini daxil edin:");
                Console.WriteLine("Kitabin adi: ");
                Name = Console.ReadLine();
                Console.WriteLine("Kitabin qiymeti: ");
                Price = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Kitabin janri: ");
                Genre = Console.ReadLine();
                books[i] = new Book(Name,Price,Genre);

            }

            Console.WriteLine("                MENU                 ");
            Console.WriteLine("1.Kitablari qiymete gore filtirle!");
            Console.WriteLine("2.Butun kitablari goster!");
            Console.WriteLine("0.Programi bagla!");
            int choseMenu = Convert.ToInt32(Console.ReadLine());
            switch (choseMenu)
            {
                case 1:
                    Console.WriteLine("Minimum qiymeti sechin:");
                    double minPrice = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Maximum qiymeti sechin:");
                    double maxPrice = Convert.ToDouble(Console.ReadLine());
                    foreach (Book book in books)
                    {
                        bookClass += 1;
                        if (book.Price >= minPrice && book.Price <= maxPrice) 
                            Console.WriteLine($"{bookClass}. Kitabin adi: {book.Name}, kitabin qiymeti: {book.Price}, kitabin janri: {book.Genre}");
                    }
                    break;
                case 2:
                    foreach (Book book in books)
                    {
                        bookClass += 1;
                        Console.WriteLine($"{bookClass}. Kitabin adi: {book.Name}, kitabin qiymeti: {book.Price}, kitabin janri: {book.Genre}");   
                    }
                    break; 
                case 0: Console.WriteLine("Istifade etdiyiniz ucun tesekkhur edirik!!!");  
                    break;
                default: Console.WriteLine("Zehmet olmasa dogru reqemi secdiyinizden emin olun!!!");
                    break;
                    }
        }
    }
}
