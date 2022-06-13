// Más información acerca de F# en http://fsharp.net
// Vea el proyecto "Tutorial de F#" para obtener más ayuda.
open System

let rec fibonnaci n = 
    if n = 0 then 0
    elif n = 1 || n = 2 then 1
    else fibonnaci(n-1) + fibonnaci(n-2) + fibonnaci(n-3)

let rec generarFibo (n: int) (fu:(int -> int)) = 
    if n >= 0 then
        generarFibo (n-1) fu
        Console.Write(fu(n))
        Console.Write(" ")

[<EntryPoint>]
let main argv = 
    Console.WriteLine("Generar los n terminos:")
    Console.WriteLine("Fibonnaci con funciones de orden superior")
    let n = Convert.ToInt32(Console.ReadLine())
    generarFibo n fibonnaci
    let d = Console.ReadKey()
    0 // devolver un código de salida entero
