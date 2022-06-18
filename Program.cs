namespace ConsoleApp2
{
    class Programm
    {
        static void Main(string[] args)
        {
            ShowInfo(FillInfo());
        }

        public static (string name,string lastName,int age, bool havePet, int petCount, string[] petNames, int favoriteColorCount, string[] favoriteColors) FillInfo()
        {
            (string name,string lastName,int age, bool havePet, int petCount, string[] petNames, int favoriteColorCount, string[] favoriteColors) info;
            Console.WriteLine("Name: ");
            info.name = checkString(Console.ReadLine());
            Console.WriteLine("LastName: ");
            info.lastName = checkString(Console.ReadLine());
            Console.WriteLine("Age: ");
            info.age = checkValue(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("HavePet: (y/n)");
            switch (checkString(Console.ReadLine()))
            {
                case "y":
                    info.havePet = true;
                    Console.WriteLine("Pet Count: ");
                    info.petCount = checkValue(Convert.ToInt32(Console.ReadLine()));
                    break;
                default:
                    info.havePet = false;
                    info.petCount = 0;
                    break;
            }
            info.petNames = PetNamesArray(info.petCount);
            Console.WriteLine("Favorite Color Count: ");
            info.favoriteColorCount = checkValue(Convert.ToInt32(Console.ReadLine()));
            info.favoriteColors = FavoriteColorsArray(info.favoriteColorCount);
            return info;
        }

        public static string[] PetNamesArray(int petCount)
        {
            string[] petNames = new string[petCount];
            for (int i = 0; i < petCount; i++)
            {
                Console.WriteLine($"Pet name number {i+1}: ");
                petNames[i] = checkString(Console.ReadLine());
            }
            return petNames;
        }
        
        public static string[] FavoriteColorsArray(int favColCount)
        {
            string[] favoriteColorsArray = new string[favColCount];
            for (int i = 0; i < favColCount; i++)
            {
                Console.WriteLine($"Fav color number {i+1}: ");
                favoriteColorsArray[i] = checkString(Console.ReadLine());
            }
            return favoriteColorsArray;
        }
        
        public static int checkValue(int value)
        {
            while (value <= 0)
            {
                Console.WriteLine("Некорректный ввод! Попробуйте еще раз: ");
                value = Convert.ToInt32(Console.ReadLine());
            }

            return value;
        }
        public static string checkString(string value)
        {
            while (value == "" || value.Any(Char.IsDigit))
            {
                Console.WriteLine("Некорректный ввод! Попробуйте еще раз: ");
                value = Console.ReadLine();
            }

            return value;
        }

        public static void ShowInfo(
            (string name, string lastName, int age, bool havePet, int petCount, string[] petNames, int
                favoriteColorCount, string[] favoriteColors) info)
        {
            Console.WriteLine($"Name: {info.name}");
            Console.WriteLine($"Last Name: {info.lastName}");
            Console.WriteLine($"Age: {info.age}");
            Console.WriteLine($"Have Pet: {info.havePet}");
            Console.WriteLine($"Pet Count: {info.petCount}");
            Console.WriteLine($"Pets: ");
            for (int i = 0; i < info.petCount; i++)
            {
                Console.WriteLine(info.petNames[i]);
            }
            Console.WriteLine($"Favorite Color Count: {info.favoriteColorCount}");
            Console.WriteLine("Favorite Colors: ");
            for (int i = 0; i < info.favoriteColorCount; i++)
            {
                Console.WriteLine(info.favoriteColors[i]);
            }
        }
    }
}