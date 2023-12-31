class CustomStack:
    def __init__(self, maxSize: int):
      self.stack = [None for _ in range(maxSize)]
      self.top_index = -1 
      self.max_size = maxSize
        
    def push(self, x: int) -> None:
        if (self.top_index < self.max_size - 1):
          self.top_index += 1
          self.stack[self.top_index] = x

    def pop(self) -> int:
        if (self.top_index > -1):
          res = self.stack[self.top_index]
          self.stack[self.top_index] = None
          self.top_index -= 1

          return res 

        return -1

    def increment(self, k: int, val: int) -> None:
        max_index = min(self.top_index, k - 1)
        for i in range(max_index + 1):
          self.stack[i] = self.stack[i] + val
