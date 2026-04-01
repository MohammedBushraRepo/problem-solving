int [] numbers = [2,7,8,18,21,24,28,29,30,33,35,38,40,43,45,50];

int target = 32;


var index = ContainIterative(numbers , target);

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