# Definition for singly-linked list.
from numbers import Number
from typing import Optional


class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next

class Solution:
    def usingRecursion(self, head: Optional[ListNode]):
        if head.next is None:
            return (head, head.val)
        
        curr = head 
        (new_head, max_ele) = self.usingRecursion(head.next)
        if curr.val < max_ele:
            return (new_head, max_ele)
        else:
            curr.next = new_head
            return (curr, curr.val)
            
    def removeNodes(self, head: Optional[ListNode]) -> Optional[ListNode]:
        if head is None:
            return head
        
        (head, max_ele) = self.usingRecursion(head)

        return head 