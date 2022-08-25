class Solution:
    def containsDuplicate(self, nums: List[int]) -> bool:
        
        dictonary ={}
        for i in range(len(nums)):  
            if dictonary.get(nums[i]) is not None:
                 return True
            else :
                dictonary[nums[i]] = 2
        return False
            
               
                
