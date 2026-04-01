int [] numbers = {1,3,5,7,9};

int target = 7;

var result = Contains(numbers , target);

Console.WriteLine($"'{target}' {(result ? "Found" : "Not Found")} ");


static bool Contains(int[] source , int target) {
 for (int i = 0 ; i < source.Length ; i ++){
    if(source[i] == target){
        return true;
    }
 }
 return false;
}
