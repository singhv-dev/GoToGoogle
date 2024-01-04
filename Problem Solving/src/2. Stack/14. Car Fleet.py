from functools import cmp_to_key

class Solution:
    def sortByPosition(first, second):
      return -1 if first[0] <= second[0] else 1

    def carFleet(self, target: int, position: List[int], speed: List[int]) -> int:
        arr = []
        for i in range(0, len(position)):
          arr.append((position[i], (target - position[i]) / speed[i]))
        
        arr = sorted(arr, key=sortByPosition)

        stack = []
        for i in range(len(arr) - 1, -1, -1):
          if len(stack) == 0 or stack[-1] < arr[i][1]:
            stack.append(arr[i][1])

        return len(stack)