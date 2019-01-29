def merge(left, right):
  result = []
  leftIndex = 0
  rightIndex = 0
  while leftIndex < len(left) and rightIndex < len(right):
    if left[leftIndex] <= right[rightIndex]:
      result.append(left[leftIndex])
      leftIndex += 1
    else:
      result.append(right[rightIndex])
      rightIndex += 1

  if leftIndex < len(left):
    result.extend(left[leftIndex:])
  elif rightIndex < len(right):
    result.extend(right[rightIndex:])
  return result

def mergesort(m):
  if len(m) <= 1:
      return m

  middle = len(m) // 2
  left = m[:middle]
  right = m[middle:]

  left = mergesort(left)
  right = mergesort(right)
  return list(merge(left, right))



array = [2000, 8, 1, 4, 14, 7, 16, 10, 9, 3, 53, 64, 2435, 234, 123, 135, 6, 76, 543]
sortedArray = mergesort(array)

print(sortedArray)
