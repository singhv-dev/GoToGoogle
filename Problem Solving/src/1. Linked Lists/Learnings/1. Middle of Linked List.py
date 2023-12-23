# Definition for singly-linked list.

from typing import Optional

class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next

class Solution:
    def middleNode(self, head: Optional[ListNode]) -> Optional[ListNode]:
        if head is None:
            return head 
        
        slow = fast = head 
        while fast is not None or fast.next is not None:
            slow = slow.next
            fast = fast.next.next 

        return slow