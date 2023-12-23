# Definition for singly-linked list.

import math
from typing import Optional


class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next


class Solution1:
    def insertGreatestCommonDivisors(self, head: Optional[ListNode]) -> Optional[ListNode]:
        if head is None:
            return head 
        
        curr = head 
        while curr is not None:
            if curr.next is not None:
                prev = curr 
                curr = curr.next
                
                gcd = math.gcd(prev.val, curr.val)
                gcd_node = ListNode(gcd, None)

                prev.next = gcd_node
                gcd_node.next = curr
            else:
                curr = curr.next
        
        return head