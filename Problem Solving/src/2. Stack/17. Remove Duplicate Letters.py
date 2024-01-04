# cbacdcbc
class Solution:
    def removeDuplicateLetters(self, s: str) -> str:
        stack = []
        
        mp = {i:0 for i in range(26)}
        print(mp[0])
        for ch in s:
          mp[ord(ch) - ord('a')] += 1

        distinct = set()
        for ch in s:
          if len(stack) == 0:
            stack.append(ch)
            distinct.add(ch)
            mp[ord(ch) - ord('a')] -= 1
          else:
            if ch in distinct:
              mp[ord(ch) - ord('a')] -= 1
              continue

            while len(stack) > 0 and stack[-1] > ch and mp[ord(stack[-1]) - ord('a')] > 0:
                curr_ch = stack.pop()
                distinct.remove(curr_ch)

            stack.append(ch)
            distinct.add(ch)
            mp[ord(ch) - ord('a')] -= 1


        res = ""
        while len(stack) > 0:
          res += stack[-1]
          stack.pop()

        return res[::-1]