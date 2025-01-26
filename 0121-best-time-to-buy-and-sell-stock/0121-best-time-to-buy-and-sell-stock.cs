public class Solution {
    public int MaxProfit(int[] prices) {
    
    int max_profit = 0;
    int min_prices = prices[0];

    for(int i=1; i<prices.Length; i++){
        // If we've a better price to buy(lower)
        if(prices[i] < min_prices ){
            min_prices = prices[i];
        }
        if(prices[i] - min_prices > max_profit){
            max_profit = prices[i] - min_prices;
        }
    }
    return max_profit;


        // int P = prices.Length;
        // int profit = 0;
        // for(int i=0; i<P;i++){
        //     for(int j=i+1;j<P;j++){
        //         if(profit < prices[j] - prices[i]){
        //             profit = prices[j] - prices[i];
        //         }
        //     } 
        // }
        // return profit; 
    }
}

    //     if(P==1){
    //         return 0;
    //     }

    //     int dayToBuy = 0;
    //     for(int i=1; i<P-1; i++){
    //         if(prices[dayToBuy] > prices[i]){
    //             dayToBuy = i;
    //         }
    //     }
    //     int dayToSell = dayToBuy+1;
    //     for(int i=dayToBuy+2;i<P;i++){
    //         if(prices[dayToSell] < prices[i]){
    //             dayToSell = i;
    //         }
    //     }

    //     if(prices[dayToBuy] > prices[dayToSell]){
    //         return 0;
    //     }
    //     return prices[dayToSell] - prices[dayToBuy];
    // }
