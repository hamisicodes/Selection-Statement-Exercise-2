namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what's your favorite subject?");
            var favoritSubject = Console.ReadLine();

            switch(favoritSubject){
                case "Mathematics":
                    Console.WriteLine("I see you love Mathematics");
                    break;
                case "Biology":
                    Console.WriteLine("Biology is your favorite subject");
                    break;
                case "Physics":
                    Console.WriteLine("It seems you really love physics");
                    break;
                case "Chemistry":
                    Console.WriteLine("You favorite subject is chemistry");
                    break;
                case "Arts":
                    Console.WriteLine("You chose Arts as your favorite subject.");
                    break;
                default:
                    Console.WriteLine("Seems your favorite subject is not in our list. We'll definitely add it.");
                    break;
            }


        }
    }
}