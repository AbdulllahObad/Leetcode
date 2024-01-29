class Solution:
    def majorityElement(self, nums: List[int]) -> int:
        n = len(nums)
        if len(nums) == 1: 
            return nums[0]
        # Initialize candidate and count
        candidate = nums[0]
        count = 1
        # Iterate through the rest of the array
        for i in range(1, len(nums)):
            if count == 0:
                # If count is zero, update candidate
                candidate = nums[i]

            # Update count based on whether the current element is the candidate
            count += 1 if nums[i] == candidate else -1
        # At this point, 'candidate' contains a potential majority element
        # You may want to check if it's the actual majority element by counting its occurrences
        return candidate
        
        
        
        
        