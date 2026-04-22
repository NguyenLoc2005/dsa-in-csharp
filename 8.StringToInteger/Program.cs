

class StringToInteger
{
    static void Main()
    {
        string str = " 42";
        for(int i=0; i < str.Length; i++)
        {
            if(str[i]== ' ')
            {
                continue;
            }

            int accessible = (int)(str[i] - '0'); 
            Console.Write(accessible);
        }
    }
}