# Definition for singly-linked list.
from typing import Optional


class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next
        
class Solution:
    def reverseBetween(self, head: Optional[ListNode], left: int, right: int) -> Optional[ListNode]:
        
        curr = head 
        prev = None 
        new_head = None 
        new_head_last = None 
        index = 1
        while index <= right:
            if index < left:
                prev = curr
                curr = curr.next  
            else: 
                if new_head is None:
                    new_head = curr
                    curr = curr.next 
                    new_head.next = None
                    new_head_last = new_head
                else: 
                    temp = curr 
                    curr = curr.next 
                    temp.next = new_head
                    new_head = temp 

            index += 1
        
        if prev is None:
            new_head_last.next = curr 
            return new_head
        else:
            prev.next = new_head
            new_head_last.next = curr 
            return head 