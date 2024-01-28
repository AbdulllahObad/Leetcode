The goal here is to find the maximum profit we can make by buying and selling stocks. Given the constraints, I'm thinking about a one-pass approach through the prices array. First, I need to find the best day to buy, and then, for each subsequent day, I'll check if selling on that day yields a better profit than what we've seen so far.

## How to find the best day to buy?​

for that, I'll iterate through the prices array. 
If the current price is lower than the price on the best day to buy so far,
   I'll update the best day to buy. This way, I'm always keeping track of the day with the lowest stock price

## How about finding the best day to sell?

Once I've found the best day to buy, I'll continue iterating through the array from that point onwards. For each day, I'll check if selling on that day would give a better profit than what we've seen so far. If it does, I'll update our best profit. This way, by the end of the iteration, I'll have the maximum profit achievable.

## Time complexity of your approach?"

With this approach, we only iterate through the prices array once, making it a linear time complexity, O(n), where n is the length of the prices array. We're keeping track of the best day to buy and updating the best profit as we go, making it an efficient solution. 

##Handle edge cases
I'd also handle edge cases, like when there's only one day or an empty array. In those cases, there's no opportunity to make a profit, so I'd return 0. Overall, this approach ensures we find the maximum profit while maintaining a simple and efficient implementation
