# Definition for singly-linked list.
from typing import Optional


class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next
        
class Solution:
    def reverseList(self, head: Optional[ListNode]) -> Optional[ListNode]:
        if head is None:
            return head 
        
        curr = head 
        head = None 
        while curr is not None:
            if head is None:
                head = curr
                curr = curr.next
                head.next = None 
            else:
                temp = curr 
                curr = curr.next 
                temp.next = head
                head = temp

        return head 