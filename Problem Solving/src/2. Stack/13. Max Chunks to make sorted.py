class Solution:
    def maxChunksToSorted(self, arr: List[int]) -> int:
        maxArr = [-1 for i in range(len(arr))]
        minArr = [sys.maxsize for i in range(len(arr))]

        for i in range(1, len(arr)):
          maxArr[i] = max(arr[i], arr[i - 1])

        for i in range(len(arr) - 1, -1, -1):
          if i == len(arr) - 1:
            minArr[i] = arr[i]
          else:
            minArr[i] = min(arr[i], arr[i + 1])
        
        chunks = 1
        for i in range(1, len(arr)):
          if maxArr[i] <= minArr[i]:
            chunks += 1

        return chunks