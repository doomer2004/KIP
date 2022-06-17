from os import system
from Worker import *


def main():
    workers = get_values()
    print_people(workers)
    pay = get_tax(workers)
    print_payment(pay)




if __name__ == '__main__':
    main()
    system('pause')
