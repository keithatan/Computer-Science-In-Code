from collections import deque
class MyStack:
    def __init__(self):
        self.q = deque()
        

    def push(self, x):
        s = len(self.q)
        
        self.q.appendleft(x)
        
        for i in range(s):
            t = self.q.pop()
            self.q.appendleft(t)
        

    def pop(self):
        t = self.q.pop()
        return t
        

    def getTop(self):
        return self.q[len(self.q)  -1]
        

    def isEmpty(self):
        if (len(self.q) == 0):
            return True
        else:
            return False
