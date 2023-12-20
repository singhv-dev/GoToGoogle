# Definition for singly-linked list.
from typing import Optional


class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next
        
class Solution:
    def mergeNodes(self, head: Optional[ListNode]) -> Optional[ListNode]:
        if head is None:
            return head 
        
        new_head = last = None
        next = head
        head = head.next
        next.next = None 

        sum = 0
        while head is not None:
            if head.val != 0:
                sum += head.val
                head = head.next 
            else:
                next.val = sum 
                
                if new_head is None:
                    new_head = last = next
                else:
                    last.next = next 
                    last = next

                next = head 
                head = head.next 
                next.next = None 
                sum = 0

        return new_head
