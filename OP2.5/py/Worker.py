from random import randint
from Pair import *


def get_values() -> dict[Time: Money]:
    n = int(input("Enter a num: "))
    people = {}
    for i in range(n):
        people[Time(randint(0, 24), randint(0, 59))] = Money(randint(0, 10), randint(0, 99))

    return people


def print_people(people: dict):
    workers_count = 1
    for key, value in people.items():
        print(f"worker {workers_count} : {key}-{value}")
        workers_count += 1


def print_payment(money: list[Money]):
    workers_count = 1
    for worker_money in money:
        print(f"worker {workers_count} : {worker_money}")
        workers_count += 1


def get_tax(people: dict[Time: Money]) -> list[Money]:
    payment = []
    counter = 0
    for key, value in people.items():
        tax_time = key
        while tax_time.get_key() >= 0:
            tax_time.decrem()
            counter += 1

        payment.append(Money(value.get_key() * counter, value.get_value() * counter))
    return payment