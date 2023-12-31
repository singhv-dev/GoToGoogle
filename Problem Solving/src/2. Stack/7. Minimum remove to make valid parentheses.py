class Solution:
    def minRemoveToMakeValid(self, s: str) -> str:
        removable = []
        stack = []
        for i in range(0, len(s)):
          if ch == ')'and len(stack) == 0:
            removable.append(i)
          else if ch == ')':
            stack.pop()
          else:
            stack.append(i)

        for i in range(len(stack) - 1, -1):
          removable.append(stack[i])

        finalStr = ""
        removableIndex = 0
        for i in range(0, len(s)):
          if removableIndex < len(removable) and removable[removableIndex] == i:
            continue
            removableIndex += 1
          else:
            finalStr += s[i]

