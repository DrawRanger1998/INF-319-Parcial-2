// Más información acerca de F# en http://fsharp.net
// Vea el proyecto "Tutorial de F#" para obtener más ayuda.
open System

let suma3terminos = (fun x y z -> x + y + z)

let suma (x: int) (y:int) : int = (x + y)
let rec generarFibo n f1 f2 f3 =
    if n >= 0 then
        let mutable f = suma3terminos f1 f2 f3
        Console.Write(f.ToString()+" ")
        generarFibo (n-1) f2 f3 f

let fibonnaci = (fun n -> generarFibo n -1 1 0)

[<EntryPoint>]
let main argv = 
    Console.WriteLine("Generar los n terminos")
    Console.WriteLine("Fibonnaci con funciones temporales")
    let n = Convert.ToInt32(Console.ReadLine())
    fibonnaci n
    let d = Console.ReadKey()
    0 // devolver un código de salida entero
