public class Solution {
    public int MaximumWealth(int[][] accounts) {
        int max = 0;
        foreach(var customer in accounts){
            int currentMax = 0;
            foreach(var account in customer){
                currentMax += account;
            }
            max = Math.Max(currentMax, max );
        } 
        return max;      
    }
}

// The goeal is to find the customer with the highest wealth
// Since Each row represnt a cutomer, I'll iterate over each customer and sum up thier account balances/ 

// We want to track the the highest sum encountered -> variable max 
// Update it whenever i find a wealthier customer