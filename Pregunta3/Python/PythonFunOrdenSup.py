# -*- coding: utf-8 -*-
"""
Created on Fri Jun 10 00:07:29 2022

@author: Orlando
"""
# Fibonnaci con funciones de orden superior

def fibo3terminos(fun, n, f1 = -1, f2 = 1, f3 = 0):
    if (n >= 0):
        f = fun(f1, f2, f3)
        print(f,end=" ")
        fibo3terminos(fun, n-1, f2, f3, f)

def suma3terminos(f1, f2, f3):
    return (f1 + f2 + f3)

n = int(input("Generar los n terminos: "))
print("Fibonnaci con funcion de orden superior")
fibo3terminos(suma3terminos, n)


