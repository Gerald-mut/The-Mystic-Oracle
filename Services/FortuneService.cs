namespace MysticOracle.Services
{
    public class FortuneService
    {
        private List<string> _fortunes = new List<string>
        {
            "A wondrous opportunity will soon appear.",
            "Your question is cloudy, ask again later...",
            "You will soon travel to a new, exciting place.",
            "Yes, most assuredly.",
            "Do not count on it."
        };

        public string GetRandomFortune()
        {
            var random = new Random();
            int index = random.Next(_fortunes.Count);
            return _fortunes[index];
        }
    }
}