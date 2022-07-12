using System.Text;

namespace TextEncoder
{
    public static class Encoder
    {
        public static void Encode(string text)
        {
            text=text.Replace(" ", "");
            var L = text.Length;
            var x = Math.Sqrt(L);
            int ceiling = (int)Math.Ceiling(x);
            int floor= (int)Math.Floor(x);
            for (var i = 0; i < ceiling; i++) {
                for (var j = 0; j <= floor; j++) {
                    int index = ceiling * j + i;
                    if (index < L)
                        Console.Write(text[index]);
                }
                Console.Write(" ");
            }
        }
    }
}
