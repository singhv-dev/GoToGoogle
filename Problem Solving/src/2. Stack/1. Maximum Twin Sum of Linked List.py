# Definition for singly-linked list.
class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next

class Solution:
    def pairSum(self, head: Optional[ListNode]) -> int:
      if head is None:
        return 0 
      
      # find the second half of linked list
      slow = fast = head 
      while (fast is not None and fast.next is not None):
        slow = slow.next
        fast = fast.next.next

      # store the second half of linked list into stack 
      stack = []
      while (slow is not None):
        stack.append(slow.val)
        slow = slow.next

      # get the twin sum using first half of linked list and stack.
      result = 0 
      while (len(stack) > 0):
        result = max(stack.pop() + head.val, result)
        head = head.next


      return result 
        