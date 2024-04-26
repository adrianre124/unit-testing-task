namespace CharsCounter;

public class CharsCounter
{
    // 1. Determining the maximum number of consecutive identical letters of the Latin alphabet in a line
    public int GetConsecutiveLatinCharsCount(string? str)
    {
        if (str is null)
        {
            throw new ArgumentNullException(nameof(str));
        }

        if (string.IsNullOrEmpty(str))
        {
            return 0;
        }

        int maxCount = 1;
        int currentCount = 1;

        for (int i = 1; i < str.Length; i++)
        {
            if (char.IsLetter(str[i]) && char.IsLetter(str[i - 1]))
            {
                if (str[i] == str[i - 1])
                {
                    currentCount++;
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                    }
                }
                else
                {
                    currentCount = 1;
                }
            }
            else
            {
                currentCount = 1;
            }
        }

        return maxCount;
    }

    // 2. Determining the maximum number of consecutive identical digits
    public int GetConsecutiveDigitsCount(string? str)
    {
        if (str is null)
        {
            throw new ArgumentNullException(nameof(str));
        }

        if (string.IsNullOrEmpty(str))
        {
            return 0;
        }

        int maxCount = 1;
        int currentCount = 1;

        for (int i = 1; i < str.Length; i++)
        {
            if (char.IsDigit(str[i]) && char.IsDigit(str[i - 1]))
            {
                if (str[i] == str[i - 1])
                {
                    currentCount++;
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                    }
                }
                else
                {
                    currentCount = 1;
                }
            }
            else
            {
                currentCount = 1;
            }
        }

        return maxCount;
    }
}
