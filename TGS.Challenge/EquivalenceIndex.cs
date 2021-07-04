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
      int equivalenceIndex = 0;
      var arrayCount = numbers.Length - 1;

      while (equivalenceIndex <= arrayCount)
      {
        int leftTotal = 0;
        int rightTotal = 0;

        leftTotal = CalculateLeftTota(numbers, leftTotal, equivalenceIndex, arrayCount);
        rightTotal = CalculateRightTotal(numbers, rightTotal, equivalenceIndex, arrayCount);

        if (leftTotal == rightTotal)
        {
          return equivalenceIndex;
        }
        if (equivalenceIndex == arrayCount)
        {
          equivalenceIndex = -1;
          return equivalenceIndex;
        }
        equivalenceIndex += 1;
      }

      return equivalenceIndex;
    }

    private static int CalculateLeftTota(int[] numbers, int leftTotal, int equivalenceIndex, int arrayCount)
    {
      for (int i = 0; i < arrayCount; i++)
      {
        if (i >= equivalenceIndex)
        {
          break;
        }
        leftTotal += numbers[i];
      }

      return leftTotal;
    }

    private static int CalculateRightTotal(int[] numbers, int rightTotal, int equivalenceIndex, int arrayCount)
    {
      for (int i = arrayCount; i >= 0; i--)
      {
        if (i <= equivalenceIndex)
        {
          break;
        }
        rightTotal += numbers[i];
      }

      return rightTotal;
    }
  }
}
