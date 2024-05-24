import math
import sys
import random
a = math.pow(math.exp(4) - math.log2(34), 1/3)
a = round(a, 2)
b = math.pow(math.log(20) + math.cos(45) + math.e, 1/3)
b = round(b, 2)
c = math.pow(math.log(20, 3) + math.sin(45) * (5/8), 1/4)
c = round(c, 2)
d = math.log(23, 3) + math.pow(math.sin(34) + 5, 1/3)
d = round(d, 2)
e = math.pow(math.log2(32) + math.pi + math.sin(56), 1/4)
e = round(e, 2)
print(a)
print(b)
print(c)
print(d)
print(e)
n=int(input("Podaj liczbe"))
napis=""
puste=""
for i in range(1,n+1):
    puste=(n-i)*" "
    if i<=1:
        napis=i*"A"
    else:
        napis=i*"A"+(i-1)*"A"
    print(puste+napis)
def wektor_nxn(n):
    wektor = []
    for i in range(0, n):
        lista = [random.randint(0, 20) for _ in range(n)]
        wektor.append(lista)
    print(wektor)
    for j in wektor:
        print(j, sum(j))

wektor_nxn(5)
