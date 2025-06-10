public class Solution {

// To check if a number contains even digit: 
// 1. count the number of digit 
// 2. Convert it into a string and take the length


    public int FindNumbers(int[] nums) {
        int count = 0;
        foreach(var num in nums){
            if(even(num)){
                count++;
            }
        }
        return count;      
    }

    public bool even(int num){
        string num_str = num.ToString();
        return (num_str).Count()%2 == 0;
    }
}

        // 1. Loop over the array nums
        // 2. Each elemeent count the digit it has.
        // 3. if even (mod 10) -> increment our count.


// 1 mode 10 = 0
// 11 mode10 = 1