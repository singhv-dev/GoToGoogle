class BrowserHistory:
    def __init__(self, homepage: str):
      self.stack = [homepage]
      self.forward_stack = []

    def visit(self, url: str) -> None:
        self.forward_stack = []
        self.stack.append(url)

    def back(self, steps: int) -> str:
        while steps > 0 and len(self.stack) > 1:
          self.forward_stack.append(self.stack.pop())
          steps -= 1

        return self.stack[-1]

    def forward(self, steps: int) -> str:
        while steps > 0 and len(self.forward_stack):
          self.stack.append(self.forward_stack.pop())
          steps -= 1

        return self.stack[-1]