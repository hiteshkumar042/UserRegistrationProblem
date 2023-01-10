namespace UserRegistrationProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Welcome Message  
            Console.WriteLine("========================================\nWelcome To the User Registration Problem\n========================================");
            RegistrationValidate registrationValidate= new RegistrationValidate();
            registrationValidate.ValidateFirstName("Hitesh");
            registrationValidate.ValidateFirstName("hitesh");

        }
    }
}