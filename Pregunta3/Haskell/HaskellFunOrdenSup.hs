fiboRecursivo :: Integer -> Integer
fiboRecursivo 0 = 0
fiboRecursivo 1 = 1
fiboRecursivo 2 = 1
fiboRecursivo n = fiboRecursivo(n-1) + fiboRecursivo(n-2) + fiboRecursivo(n-3)

generarFibo :: Integer -> (Integer ->Integer) -> IO() 
generarFibo n fun = do
    if n >= 0
    then do
       generarFibo (n-1) fun
       putStr $ (show(fun n)++" ")
    else putStr ""

main :: IO()
main = do
    putStrLn ("Generar los n terminos:")
    putStrLn ("Fibonnaci con funciones de orden Superior")
    n <- getLine
    let fibonnaci = generarFibo (read n)
    fibonnaci fiboRecursivo

