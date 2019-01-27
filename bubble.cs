        static int BinarySearch(int[] haystack, int needle, ref int numOfComparison)
        {
            int needleIndex = -1;
            numOfComparison++;

            int middlePoint = haystack.Length / 2;
            if (haystack.Length >= 1) // breaking recursion
            {
                if (needle == haystack[middlePoint])
                {
                    return middlePoint;
                }
                if (needle < haystack[middlePoint])
                {
                    // if the term is found in the first half of the array
                    return BinarySearch(haystack.Skip(0).Take(middlePoint).ToArray(), needle, ref numOfComparison);
                }
                else if (needle > haystack[middlePoint])
                {
                    // if the term is found in the second half of the array. !!! we need to keep track of the final recursion returns -1
                    // in such case, we break and return -1
                    int recNeedleIndex = BinarySearch(haystack.Skip(middlePoint + 1).Take(haystack.Length - 1).ToArray(), needle, ref numOfComparison);
                    if (recNeedleIndex == -1)
                    {
                        return -1;
                    }
                    return recNeedleIndex + middlePoint + 1;
                }
            }
            return needleIndex;
        }
