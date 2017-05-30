namespace FortuneTeller
{
    public class Program
    {
        static void Main()
        {
            FortuneRecipient fortuneRecipient = new FortuneRecipient();
            
            FortuneGame.GetFortune(fortuneRecipient);
        }
    }
}
