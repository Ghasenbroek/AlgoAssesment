namespace TGS.Challenge
{
  /*
       Given a zero-based integer array of length N, the equivalence index (i) is the index where the sum of all the items to the left of the index
       are equal to the sum of all the items to the right of the index.

       Constraints: 0 <= N <= 100 000

       Example: Given the following array [1, 2, 3, 4, 5, 7, 8, 10, 12]
       Your program should output "6" because 1 + 2 + 3 + 4 + 5 + 7 = 10 + 12

       If no index exists then output -1

       There are accompanying unit tests for this exercise, ensure all tests pass & make
        sure the unit tests are correct too.
     */

  public class EquivalenceIndex
  {
    public int Find(int[] numbers)
    {
      int left, right;
      int index = 0;
      var numberCount = numbers.Length - 1;

      while (index <= numberCount)
      {
        left = 0;
        right = 0;

        left = CalculateLeft(numbers, left, index, numberCount);
        right = CalculateRight(numbers, right, index, numberCount);

        if (left == right)
        {
          return index;
        }
        if (index == numberCount)
        {
          index = -1;
          return index;
        }
        index += 1;
      }

      return index;
    }

    private static int CalculateRight(int[] numbers, int right, int index, int numberCount)
    {
      for (int i = numberCount; i >= 0; i--)
      {
        if (i <= index)
        {
          break;
        }
        right += numbers[i];
      }

      return right;
    }

    private static int CalculateLeft(int[] numbers, int left, int index, int numberCount)
    {
      for (int i = 0; i < numberCount; i++)
      {
        if (i >= index)
        {
          break;
        }
        left += numbers[i];
      }

      return left;
    }
  }
}
