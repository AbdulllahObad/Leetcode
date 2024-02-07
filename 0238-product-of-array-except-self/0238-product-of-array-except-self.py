class Solution:
    def productExceptSelf(self, nums: List[int]) -> List[int]:
       ## Create a answer output arr, give each position an initial value of one
        answer = [1]*(len(nums))
        prefix = 1 
        # we ganna go through each position in our input arr
        for i in range(len(nums)): 
         ## for each position in our output arr i, 
         ## we ganna take the prefix, put it in that position
             answer[i] = prefix
         ## take the input arr value nums[i]* prefix
             prefix *= nums[i]
         ## store the prefixes in the answer output arr. 
        postfix = 1 
        for i in range(len(nums) -1, -1, -1  ): 
            answer[i] *= postfix
            postfix *= nums[i]
        return answer
         
            