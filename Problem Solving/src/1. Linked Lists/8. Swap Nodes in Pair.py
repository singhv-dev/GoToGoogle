# Definition for singly-linked list.
from typing import Optional


class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next
        
class Solution:
    def swapPairs(self, head: Optional[ListNode]) -> Optional[ListNode]:
        if head is None or head.next is None:
            return head 
        
        new_head = prev_node = next_node = None 
        while head is not None and head.next is not None:
            next_node = head.next.next 

            if new_head is None:
                new_head = head.next 
                new_head.next = head
                head.next = next_node
                prev_node = head
            else:
                prev_node.next = head.next
                prev_node.next.next = head 
                head.next = next_node
                prev_node = head 

            head = next_node

        return new_head