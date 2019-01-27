        static int BinarySearch(int[] intArray, int needle)
        {
            int needleIndex = -1;

            int middlePoint = intArray.Length / 2;
            if (intArray.Length >= 1) // breaking recursion
            {
                if (needle == intArray[middlePoint])
                {
                    return middlePoint;
                }
                if (needle < intArray[middlePoint])
                {
                    // if the term is found in the first half of the array
                    return BinarySearch(intArray.Skip(0).Take(middlePoint).ToArray(), needle);
                }
                else if (needle > intArray[middlePoint])
                {
                    // if the term is found in the second half of the array. !!! we need to keep track of the final recursion returns -1
                    // in such case, we break and return -1
                    int recNeedleIndex = BinarySearch(intArray.Skip(middlePoint + 1).Take(intArray.Length - 1).ToArray(), needle);
                    if (recNeedleIndex == -1)
                    {
                        return -1;
                    }
                    return recNeedleIndex + middlePoint + 1;
                }
            }
            return needleIndex;
        }
