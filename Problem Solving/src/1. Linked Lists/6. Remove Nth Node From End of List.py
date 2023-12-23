from typing import Optional

class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next

class Solution:
    def removeNthFromEnd(self, head: Optional[ListNode], n: int) -> Optional[ListNode]:
        if head is None:
            return head 
        
        list_size = 0
        curr = head 
        while curr is not None:
            list_size += 1
            curr = curr.next 

        from_start = list_size - n
        if from_start == 0:
            return head.next 
        
        curr = head 
        for i in range(1, from_start):
            curr = curr.next 
            
        curr.next = curr.next.next 

        return head
        