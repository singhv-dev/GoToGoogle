# Nice problem. 

class Solution:
    def scoreOfParentheses(self, s: str) -> int:
        score = 0
        stack = []
        for ch in s:
          if ch == '(':
            stack.append(score)
            score = 0
          else:
            score = score + max(2 * score, 1)

        return score 