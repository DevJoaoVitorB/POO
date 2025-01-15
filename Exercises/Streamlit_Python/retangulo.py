from math import *

class Retangulo:
    def __init__(self, b, h):
        self.__b = b
        self.__h = h
    def calc_area(self):
        return f"{self.__b * self.__h:.2f}"
    def calc_diagonal(self):
        return f"{sqrt(self.__b ** 2 + self.__h ** 2):.2f}"
    def __str__(self):
        return f"Retângulo: \nBase:{self.__b} \nAltura:{self.__h}"