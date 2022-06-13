# -*- coding: utf-8 -*-
"""
Created on Sat Jun 11 15:33:14 2022

@author: Orlando
"""
# Fibonnaci con funciones temporales"

suma3terminos = lambda f1, f2, f3: f1 + f2 + f3
fibonnaci = lambda n: generarFibo(n, -1, 1, 0)

def generarFibo(n, f1, f2, f3):
    if n >= 0:
        f = suma3terminos(f1, f2, f3)
        print(f, end=" ")
        generarFibo(n-1, f2, f3, f)

n = int(input("Generar los n terminos: "))
print("Fibonnaci con funciones temporales")
fibonnaci(n)