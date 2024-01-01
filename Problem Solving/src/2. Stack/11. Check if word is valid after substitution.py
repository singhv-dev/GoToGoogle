class Solution:
    def isValid(self, s: str) -> bool:
        stack = []
        for ch in s:
          if ch == 'c' and len(stack) > 1 and stack[-1] == 'b' and stack[-2] == 'a':
            stack.pop()
            stack.pop()
          else:
            stack.append(ch)

        return true if len(stack) == 0 else false
