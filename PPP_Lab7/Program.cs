
namespace PPP_Lab7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User User1 = new User(1, "Alice", "Cather", 25);
            User User2 = new User(2, "Bob","Bracker" , 30);

            RatingSystem ratingSystem = new RatingSystem();

            ratingSystem.AddOrUpdateRating(User1, 5);
            ratingSystem.AddOrUpdateRating(User2, 4);

            Console.WriteLine($"Список рейтингов пользователей:\n{ratingSystem}");

            ratingSystem.ModifyRating(User1, 10);
            ratingSystem.ModifyRating(User2, 20);

            Console.WriteLine($"Обновленный рейтинг для {User1.FirstName}: {ratingSystem.GetRating(User1)}");
            Console.WriteLine($"Обновленный рейтинг для {User2.FirstName}: {ratingSystem.GetRating(User2)}\n");
            
            ratingSystem.RemoveRating(User2);
            Console.WriteLine($"Список рейтингов пользователей после удаления {User2.FirstName}:\n{ratingSystem}");
        }
    }
}