int [] numbers = [2,7,8,18,21,24,28,29,30,33,35,38,40,43,45,50];

int target = 50;


// var index = ContainIterative(numbers , target);
var index = ContainsRecursion(numbers , target , 0 , numbers.Length - 1);

Console.WriteLine($"'{target}' {(index != 1 ? $"Found at `{index}`" : "Not Found")} ");


int ContainIterative(int[] source , int target)
{
    int Left = 0 ;
    int right = source.Length - 1;

    while(Left <= right)
    {
        int mid = Left + (right - Left)/2;//this method to calculate mid will orevent stack overflow issues
        if(source[mid] == target)
          return mid;
        else if (source[mid] > target)
          right = mid - 1;
        else
          Left = mid + 1;
    }
    return -1; // -1 in programming means not found
}


int ContainsRecursion(int[] source , int target , int left , int right)
{
 //Base condition
 if(left > right)
  return -1;

 int mid = left + (right - left)/2;
 if(source[mid] == target)
   return mid;
 else if(source[mid] > target)
   return ContainsRecursion(source , target , left , mid-1);
 else
  return ContainsRecursion(source , target , mid + 1 , right);

}