
    def search(self, nums, target):
        start = 0
        end = len(nums) -1
        
        if (len(nums) == 1):
            if (nums[0] == target):
                return 0
            else:
                return -1
        
        while (start <= end):
            mid = start + (end - start) //2
            if (nums[mid] == target):
                return mid
            elif(nums[mid] < target):
                start = mid + 1
            else:
                end = mid-1
        
        return -1
