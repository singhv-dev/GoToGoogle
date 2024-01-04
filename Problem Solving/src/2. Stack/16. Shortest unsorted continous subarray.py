class Solution:
    def findUnsortedSubarray(self, nums: List[int]) -> int:
        stack = []
        left = len(nums) + 1
        right = -1

        for i in range(0, len(nums)):
          while len(stack) != 0 and stack[-1] <= nums[i]:
            stack.pop()

          right = max(right, (-1 if len(stack) == 0 else i))
          stack.append(nums[i])

        stack = []
        for i in range(len(nums) - 1, -1, -1):
          while len(stack) != 0 and stack[-1] >= nums[i]:
            stack.pop()

          left = min(left, (len(nums) if len(stack) == 0 else i))
          stack.append(nums[i])

        if left > right:
          return 0
        else:
          return (right - left + 1)