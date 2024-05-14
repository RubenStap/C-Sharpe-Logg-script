using Loggers;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            MyLogger logger = new MyLogger("testclass");
            MyLogger logger1 = new MyLogger("balta blud");

            logger1.Info("een andere error");

            logger.Debug("Het programma draait op localhost:8000");
            logger.Info("Het programma is succesvol gestart");
            logger.Warning("De harde schijf is bijna vol, zorg dat je ruimte maakt");
            logger.Error("Er is een fout opgetreden in de database, start mysql opnieuw op!");
            logger.Log("SPACESHIP", "Hallo aarde!");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}