using System;

namespace Converter{
    public class Converter{
        static string SecToTimestamp(long sec){
            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dateTime = dateTime.AddSeconds(sec).ToLocalTime();
            return $"{dateTime}";
        }

        public static void Main(string[] args){
            while(true){
                Console.Write("Unix timestamp in seconds: ");
                long n = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine(SecToTimestamp(n));
            }
        }
    }
}
