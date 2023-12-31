class Solution:
    def minSwaps(self, s: str) -> int:
        left = bal = 0 
        for ch in s:
          bal += 1 if ch == '[' else -1
          if bal == -1:
            left += 1
            bal = 0
        minEle = min(left, bal)
        maxEle = max(left, bal)
        
        return (minEle + 1) // 2 + (maxEle - minEle + 1) // 2