class Solution:
    def findClosestNumber(self, nums: List[int]) -> int:
        
        closest_to_zero = nums[0]
        for element in nums[1:]:
            if abs(element) < abs(closest_to_zero):
                closest_to_zero = element
            elif abs(closest_to_zero) == abs(element):
                closest_to_zero = max(element,closest_to_zero)
        return closest_to_zero
                
        
            
        