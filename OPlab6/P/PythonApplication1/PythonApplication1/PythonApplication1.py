def nsd(a, b): #функція для обчислення
    while a != b:
        if a > b:
            a = a - b
        else:
            b = b - a
    return a


num1 = int(input("Enter first number: "))
num2 = int(input("Enter second number: "))
num3 = int(input("Enter third number: "))

res = nsd(nsd(num1, num2), num3) 

print("NSD =", res)