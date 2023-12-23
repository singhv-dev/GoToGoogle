from ast import List


class Solution:
    def buyChoco(self, prices: List[int], money: int) -> int:
        first = min(prices[0], prices[1])
        second = max(prices[0], prices[1])

        for i in range(2, len(prices)):
            if prices[i] <= first:
                second = first
                first = prices[i]
            elif prices[i] <= second:
                second = prices[i]

        return money if first + second > money else (money - first - second)
        