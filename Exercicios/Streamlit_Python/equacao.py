from math import *

class Equacao:
    def __init__(self, a, b, c):
        self.__a = a
        self.__b = b
        self.__c = c
    def delta(self):
        return self.__b ** 2 - 4 * self.__a * self.__c
    def x1(self):
        if self.delta() >= 0:
            return (-self.__b + sqrt(self.delta())) / (2 * self.__a)
        return None
    def x2(self):
        if self.delta() >= 0:
            return (-self.__b - sqrt(self.delta())) / (2 * self.__a)
        return None
    def y(self, x):
        return self.__a * 2 * x + self.__b * x + self.__c
    def xplano(self):
        return 
    def __str__(self):
        return f"Equação Valores: a = {self.__a} -- b = {self.__b} -- c = {self.__c} -> Equação: {self.__a}X²+{self.__b}X+{self.__c}"
