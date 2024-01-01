class Solution:
    def nextGreaterElements(self, nums: List[int]) -> List[int]:
        stack = []
        for i in range(len(nums) - 1, -1, -1):
          while len(stack) > 0 and stack[-1] <= nums[i]:
            stack.pop()
          stack.append(nums[i])

        res = [-1 for _ in range(len(nums))]
        for i in range(len(nums) - 1, -1, -1):
          while len(stack) > 0 and stack[-1] <= nums[i]:
            stack.pop()

          if len(stack) > 0:
            res[i] = stack[-1]
          
          stack.append(i)

        return res


class Solution2:
    def nextGreaterElements(self, nums: List[int]) -> List[int]:
        res = []
        stack = []
        for i in range(len(2 * nums) - 1, -1, -1):
          while len(stack) > 0 and nums[stack[-1]] <= nums[i % len(nums)]:
            stack.pop()
          
          res[i % len(nums)] = -1 if len(stack) == 0 else nums[stack[-1]]

          stack.append(i % len(num))

        return res