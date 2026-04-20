

class LongestPalindromicSubstring
{
    static void Main()
    {
        string s = "babad";
        string longest = "";

        for (int i = 0; i < s.Length; i++)
        {
            for (int j = i; j < s.Length; j++)
            {
                // Trích xuất chuỗi con từ i đến j
                string sub = s.Substring(i, j - i + 1);

                // Kiểm tra xem sub có đối xứng không và có dài hơn kỷ lục cũ không
                if (IsPalindrome(sub) && sub.Length > longest.Length)
                {
                    longest = sub;
                }
            }
        }
        Console.WriteLine("Chuỗi dài nhất: " + longest);
    }

    // Hàm kiểm tra đối xứng "đa dụng" cho mọi trường hợp
    static bool IsPalindrome(string text)
    {
        int left = 0;
        int right = text.Length - 1;
        while (left < right)
        {
            if (text[left] != text[right]) return false;
            left++;
            right--;
        }
        return true;
    }
}

