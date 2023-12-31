class Solution:
    def maxDepthAfterSplit(self, seq: str) -> List[int]:
        res = []
        int bal = 0 
        for ch in seq:
          bal += 1 if ch == '(' else -1
          curr = bal if ch == '(' else bal + 1 
          res.append(curr % 2)

        return res 