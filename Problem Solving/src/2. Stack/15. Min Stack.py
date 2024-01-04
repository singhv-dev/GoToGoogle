class MinStack:

    def __init__(self):
        self.stack = []
        self.min_ele = None
        

    def push(self, val: int) -> None:
        if len(self.stack) == 0 or self.min_ele <= val:
            self.stack.append(val)
            self.min_ele = val if self.min_ele is None else self.min_ele
        else:
            self.stack.append(2 * val - self.min_ele)
            self.min_ele = val

    def pop(self) -> None:
        if len(self.stack) == 0:
            return None 
        elif self.stack[-1] >= self.min_ele:
            self.min_ele = None if len(self.stack) == 1 else self.min_ele
            return self.stack.pop()
        else:
            curr = self.min_ele
            self.min_ele = 2 * curr - self.stack[-1]
            self.min_ele = None if len(self.stack) == 1 else self.min_ele
            self.stack.pop()
            return curr

    def top(self) -> int:
        if self.stack[-1] < self.min_ele:
            return self.min_ele
        else:
            return self.stack[-1]

    def getMin(self) -> int:
        return self.min_ele


# Your MinStack object will be instantiated and called as such:
# obj = MinStack()
# obj.push(val)
# obj.pop()
# param_3 = obj.top()
# param_4 = obj.getMin()