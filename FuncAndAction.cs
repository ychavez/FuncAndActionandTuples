namespace FuncAndAction
{
    public class FuncAndAction
    {
        public static void Run() 
        {
            string palabra = "aaaassssddddfffghhhj";
            Console.WriteLine(PrimerNoRepetidoClassic(palabra));
            Console.WriteLine(GetPrimerNoRepeditoFunc(palabra));
            
            char PrimerNoRepetidoClassic(string palabra)
            {
                int i, j;
                bool isRepeted = false;
                char[] chars = palabra.ToCharArray();
                for (i = 0; i < chars.Length; i++)
                {
                    isRepeted = false;
                    for (j = 0; j < chars.Length; j++)
                    {
                        if ((i != j) && (chars[i] == chars[j]))
                        {
                            isRepeted = true;
                            break;
                        }
                    }
                    if (isRepeted == false)
                    {
                        return chars[i];
                    }
                }
                return ' ';
            }
        }

        public static Func<string,char> GetPrimerNoRepeditoFunc 
            = (s) => s.ToArray()
                      .GroupBy(x => x)
                      .Where(x => x.Count() == 1)
                      .Select(x => x.Key)
                      .FirstOrDefault();


       

    }
}
