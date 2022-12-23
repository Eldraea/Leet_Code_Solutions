int[] array = new int[] { 4, 3, 2, 1, 4 };
Console.WriteLine(GetAreaOfContainerWithMostWater(array));

int GetAreaOfContainerWithMostWater(int[] array)
{
    var (firstMarker, indexFirstMarker) = (array[0], 0);
    var (secondMarker, indexSecondMarker) = (array[array.Length - 1], array.Length - 1);
    var maximum = Math.Min(firstMarker, secondMarker) * Math.Abs(indexFirstMarker - indexSecondMarker);
    if (array.Length == 0 || array.Length == 1)
        return 0;
    else if (array.Length == 2)
        return array.Min();

    while (indexFirstMarker < indexSecondMarker)
    {
        if(firstMarker >= secondMarker)
        {
            indexSecondMarker--;
            secondMarker = array[indexSecondMarker];
        }
        else
        {
            indexFirstMarker++;
            firstMarker = array[indexFirstMarker];
        }

        var newMaximum = Math.Min(firstMarker, secondMarker) * Math.Abs(indexFirstMarker - indexSecondMarker);
        if (maximum < newMaximum)
            maximum = newMaximum;

    }
    return maximum;
}
