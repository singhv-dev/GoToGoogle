# this problem is based upon the next greater element in the list 

class Solution:
    def dailyTemperatures(self, temperatures: List[int]) -> List[int]:
        res = [0 for _ in range(len(temperatures))]
        stack = []
        for i in range(len(temperatures) - 1, -1, -1):
          while len(stack) > 0 and temperatures[stack[-1]] <= temperatures[i]:
            stack.pop()

          if len(stack) > 0:
            res[i] = stack[-1] - i
          
          stack.append(i)

        return res
