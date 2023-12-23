# Definition for singly-linked list.
from typing import Optional


class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next

# First Solution.
class Solution1:
    def removeElements(self, head: Optional[ListNode], val: int) -> Optional[ListNode]:
        if head is None:
            return None
        
        new_head = last = None

        while(head is not None):
            next_node = head.next
            head.next = None

            if head.val != val:
                if last is None:
                    new_head = last = head
                else:
                    last.next = head
                    last = head
                
            head = next_node

        return new_head
    
# Second Solution
class Solution2:
  def removeElements(self, head: Optional[ListNode], val: int) -> Optional[ListNode]:
      if head is None:
          return None
      
      new_head = last = None

      while(head is not None):
          if head.val != val:
              if last is None:
                  new_head = last = head
              else:
                  last.next = head
                  last = head
          head = head.next
          if last is not None:
              last.next = None

      return new_head