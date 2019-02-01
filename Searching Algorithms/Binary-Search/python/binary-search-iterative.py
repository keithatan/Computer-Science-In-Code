# Time Complexity: O log(n)
# Can only be done on a SORTED array
# This solution only works when its sorted in increasing order however can be modified to do the reverse

def binarySearch(self, nums, target):
    # nums is the array being passed into search
    # target is the number we are looking for
    
    # Initializing pointers
    start = 0
    end = len(nums) -1
    
    # This is a specific edge case for when the array has only one element

    if (len(nums) == 1):
        if (nums[0] == target):
            return 0
        else:
            return -1
        
    # This is the search
    # How it works:
    # We go to the middle of the array and check the number
    # If that index is the number, we are done.
    # If not, we check the left half if its greater, right half if its less

    while (start <= end):
        mid = start + (end - start) //2
        if (nums[mid] == target):
            return mid
        elif(nums[mid] < target):
            start = mid + 1
        else:
            end = mid-1

    return -1
