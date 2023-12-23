# Definition for singly-linked list.
from typing import Optional


class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next
        
class Solution:
    def pairSum(self, head: Optional[ListNode]) -> int:
        slow = fast = head 
        half_len = 0
        while fast is not None:
            half_len += 1
            slow = slow.next
            fast = fast.next.next 

        slow_head = None
        while slow is not None:
            if slow_head is None:
                slow_head = slow
                slow = slow.next
                slow_head.next = None 
            else: 
                temp = slow
                slow = slow.next
                temp.next = slow_head
                slow_head = temp
        res = 0
        for i in range(0, half_len):
            res = max(head.val + slow_head.val, res)
            head = head.next 
            slow_head = slow_head.next 

        return res
        
