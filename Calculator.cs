namespace nelio_dotnet
{
  class Calculator
  {
    public static int Sum(params int[] nums)
    {
      int sum = 0;

      foreach (int num in nums)
      {
        sum += num;
      }

      return sum;
    }
  }
}