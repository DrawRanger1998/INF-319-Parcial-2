// Más información acerca de F# en http://fsharp.net
// Vea el proyecto "Tutorial de F#" para obtener más ayuda.
open System

// Fibonnaci estructural
let fiboEstructural n =
    let mutable f = 0
    let mutable f1 = -1
    let mutable f2 = 1
    let mutable f3 = 0
    for i in 1..(n+1) do
        f <- f1 + f2 + f3
        f1 <- f2
        f2 <- f3
        f3 <- f
        printf "%d " f
    printfn ""

// Fibonnaci Recursivo
let rec fibonnaci n =
    if n = 0 then 0
    elif n = 1 || n = 2 then 1
    else fibonnaci(n-1) + fibonnaci(n-2) + fibonnaci(n-3)

let rec fiboRecursivo n =
    if n >= 0 then 
        fiboRecursivo(n-1)
        Console.Write(fibonnaci(n))
        Console.Write(" ")

[<EntryPoint>]
let main argv = 
    Console.WriteLine("Generar los n terminos")
    let n = Convert.ToInt32(Console.ReadLine())
    Console.WriteLine("Fibonnaci Estructural")
    fiboEstructural n
    Console.WriteLine("Fibonnaci Recursivo")
    fiboRecursivo n
    let tecla = Console.ReadKey()
    0 // devolver un código de salida entero
