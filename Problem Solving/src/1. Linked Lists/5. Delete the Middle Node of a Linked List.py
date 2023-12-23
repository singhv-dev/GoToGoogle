# Definition for singly-linked list.
from typing import Optional


class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next
        
class Solution1:
    def deleteMiddle(self, head: Optional[ListNode]) -> Optional[ListNode]:
        if head is None or head.next is None:
            return None 
         
        slow = fast = head
        prev_slow = None 
        while fast is not None and fast.next is not None:
            prev_slow = slow
            slow = slow.next
            fast = fast.next.next 

        prev_slow.next = slow.next

        return head