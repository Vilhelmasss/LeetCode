// https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/564/

public class Solution {
    public int MaxProfit(int[] prices) {
        int profit = 0;
        for(int i = 0; i < prices.Length - 1; i++) {
            if(prices[i] < prices[i+1]) {
                profit += prices[i+1] - prices[i];
            }
        }
        return profit;
    }
}