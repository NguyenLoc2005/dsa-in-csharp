
class PalinromeNumber
{
    static void Main()
    {
        int x = -121;
        string str = x.ToString();
        bool isPalindrome = true;
        if (x < 0)
        {
            isPalindrome = false;
        }

        int left =0;
        int right = str.Length - 1;
        while(left < right)
        {
            left ++;
            right --;
            if(str[left] != str[right])
            {
                isPalindrome = false;
                break;
            }
        }
        if (isPalindrome)
        {
            Console.WriteLine("The number is a palindrome.");
        }
        else
        {
            Console.WriteLine("The number is not a palindrome.");
        }
    }
}


