using System;

namespace Open_Lab_05._10
{
    public class Challenge
    {
        public int MysteryFunc(int num)
        {
            throw new NotImplementedException();
            int total_number = 1;
            char[] num_characters = num.ToString().ToCharArray();
            foreach (var number_char in num_characters)
            {
                int intStr; bool intResultTryParse = int.TryParse(number_char.ToString(), out intStr);
                total_number = total_number * intStr;
            }
            return total_number;
        }
    }
}
