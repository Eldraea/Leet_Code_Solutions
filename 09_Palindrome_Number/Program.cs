bool IsPalindrome(int number)
{
    int reversedNumber = 0;
    int reminderNumber = number;

    if (number < 0)
        return false;

    while (number > 0)
    {
        reversedNumber = reversedNumber* 10 + number % 10;
        number /= 10;
    }   
    return reversedNumber == reminderNumber ;
}

