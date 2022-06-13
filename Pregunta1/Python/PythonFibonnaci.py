# -*- coding: utf-8 -*-
"""
Created on Wed Jun  8 16:27:37 2022

@author: Orlando
"""

"""

Fibonacci de 3 terminos

Serie: 0 1 1 2 4 7 13 ...
Term:  0 1 2 3 4 5 6 ...

Formula:
f(0) = 0: Caso base 1
f(1) = 1: Caso base 2 
f(2) = 1: Caso base 3
f(n) = f(n-1) + f(n-2) + f(n-3): formula

"""
# Fibonnaci estructural

def fiboEstructural(n):
    f1 = -1
    f2 = 1
    f3 = 0
    for i in range (n+1):
        f = f1 + f2 + f3
        f1 = f2
        f2 = f3
        f3 = f
        print(f,end=" ")

# Fibonnaci Recursivo

def fiboRecursivo(n):
    if (n >= 0):
        fiboRecursivo(n-1)
        print(fibonnaci(n), end=" ")
        
def fibonnaci(n):
    if (n == 0):
        return 0
    elif (n == 1 or n == 2):
        return 1
    else:
        return fibonnaci(n-1) + fibonnaci(n-2) + fibonnaci(n-3) 
        


n = int(input("Generar los n terminos: "))
print("Fibonnaci Estructural")
fiboEstructural(n)
print("\nFibonnaci Recursivo")
fiboRecursivo(n)
        
        
        
        
        
        
        
        