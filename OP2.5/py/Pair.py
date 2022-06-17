
from abc import ABC, abstractmethod


class Pair(ABC):
    @abstractmethod
    def get_key(self):
        pass

    @abstractmethod
    def set_key(self, value):
        pass

    @abstractmethod
    def get_value(self):
        pass

    @abstractmethod
    def set_value(self, value):
        pass

    @abstractmethod
    def increm(self):
        pass

    @abstractmethod
    def decrem(self):
        pass


class Money(Pair):
    def __init__(self, key, value):
        self.set_key(key)
        self.set_value(value)

    def __str__(self):
        return f"{self.__hryvnia}.{self.__cent}"

    def get_key(self):
        return self.__hryvnia

    def set_key(self, value):
        if value < 0:
            self.__hryvnia = 0
        else:
            self.__hryvnia = value

    def get_value(self):
        return self.__cent

    def set_value(self, value):
        self.__cent = value % 100
        self.__hryvnia += value // 100

    def increm(self):
        self.set_value(self.get_value() + 1)

    def decrem(self):
        self.set_value(self.get_value() - 1)


class Time(Pair):
    def __init__(self, key, value):
        self.set_key(key)
        self.set_value(value)

    def __str__(self):
        return f"{self.__hour}:{self.__minute}"

    def get_key(self):
        return self.__hour

    def set_key(self, value):
        if value < 0:
            self.__hour = 0
        else:
            self.__hour = value

    def get_value(self):
        return self.__minute

    def set_value(self, value):
        self.__minute = value % 60
        self.__hour += value // 60
        if value < 0:
            self.__minute = 59
            self.__hour -= 1

    def increm(self):
        self.set_value(self.get_value() + 1)

    def decrem(self):
        self.set_value(self.get_value() - 1)