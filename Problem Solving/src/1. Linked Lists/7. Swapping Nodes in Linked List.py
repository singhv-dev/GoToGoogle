# Definition for singly-linked list.
from typing import Optional


class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next
        
class Solution:
    def swapNodes(self, head: Optional[ListNode], k: int) -> Optional[ListNode]:
        if head is None:
            return head 
        
        total_size = 0
        curr = head 
        while curr is not None:
            total_size += 1
            curr = curr.next 

        first = None
        last_index = total_size - k + 1
        first_index = min(k, last_index)
        last_index = max(k, last_index)

        curr = head 
        for i in range(1, total_size + 1):
            if i == first_index:
                first = curr
            elif i == last_index:
                temp = curr.val 
                curr.val = first.val
                first.val = temp

            curr = curr.next

        return head