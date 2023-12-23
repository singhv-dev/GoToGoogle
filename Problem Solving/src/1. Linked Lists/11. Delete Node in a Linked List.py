# Definition for singly-linked list.
class ListNode:
    def __init__(self, x):
        self.val = x
        self.next = None

class Solution:
    def deleteNode(self, node):
        curr = node 
        while curr.next.next is not None:
          temp_val = curr.next.val  
          curr.next.val = curr.val 
          curr.val = temp_val
          
          curr = curr.next 
        
        curr.val = curr.next.val
        curr.next = None 