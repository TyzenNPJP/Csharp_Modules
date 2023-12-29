/*
 * Write a C# programme to check the said string is valid or not. 
 * The input string will be valid when open brackets and closed brackets are same type of brackets.
    Or
   open brackets will be closed in proper order.
*/

class Program
{
    static void Function(string brackets)
    {
        int angle_l = 0;
        int angle_r = 0;
        int round_l = 0;
        int round_r = 0;
        int curly_l = 0;
        int curly_r = 0;
        int square_l = 0;
        int square_r = 0;

        foreach (char c in brackets)
        {
            // Count the numbers of different types of brackets
            switch (c)
            {
                // Make sure the left bracket comes first
                case '<':
                    if (angle_l >= angle_r)
                        angle_l++; break;
                case '>': angle_r++; break;
                case '(':
                    if (round_l >= round_r)
                        round_l++; break;
                case ')': round_r++; break;
                case '{':
                    if (curly_l >= curly_r)
                        curly_l++; break;
                case '}': curly_r++; break;
                case '[':
                    if (square_l >= square_r)
                        square_l++; break;
                case ']': square_r++; break;
            }
        }

        if (angle_l == angle_r && round_l == round_r && curly_l == curly_r && square_l == square_r)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }

    static void Main(string[] args)
    {
        Function("<{)}(>");
        Function("<{})(");
        Function("<>{}[]()");
    }
}