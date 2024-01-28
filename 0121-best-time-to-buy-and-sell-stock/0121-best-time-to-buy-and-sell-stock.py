from typing import List

class Solution:
    def maxProfit(self, prices: List[int]) -> int:
        if not prices or len(prices) == 1:
            return 0
        
        # Initialize variables
        best_profit = 0
        best_day_to_buy = 0

        # Iterate through the prices
        for i in range(1, len(prices)):
            if prices[i] < prices[best_day_to_buy]:
                best_day_to_buy = i
            else:
                # Calculate and update the best profit if selling on the current day
                best_profit = max(best_profit, prices[i] - prices[best_day_to_buy])

        return best_profit
                
                
                
            