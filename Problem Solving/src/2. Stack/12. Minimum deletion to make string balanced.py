# Good Problem to solve 
class Solution:
    def minimumDeletions(self, s: str) -> int:
        a_total = b_total = 0
        for ch in s:
          if ch == 'a':
            a_total += 1
          else:
            b_total += 1

        
        a_curr = b_curr = 0
        res = 1000 * 1000
        for ch in s:
          if ch == 'a':
            a_curr += 1
            res = min(res, b_curr + (a_total - a_curr))
          else:
            res = min(res, b_curr + (a_total - a_curr))
            b_curr += 1

        return res

          