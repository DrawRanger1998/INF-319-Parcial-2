-- Fibonnaci Estructural
suma3terminos :: Integer -> Integer -> Integer -> Integer
suma3terminos x y z = x + y + z 

generarFiboEst :: Integer -> Integer -> Integer -> Integer -> IO() 
generarFiboEst n f1 f2 f3 = do
    if n >= 0
    then do
       let f = suma3terminos f1 f2 f3
       putStr $ (show(f)++" ")
       generarFiboEst (n-1) f2 f3 f
    else putStr ""

-- Fibonnaci Recursivo
fiboRecursivo :: Integer -> Integer
fiboRecursivo 0 = 0
fiboRecursivo 1 = 1
fiboRecursivo 2 = 1
fiboRecursivo n = fiboRecursivo(n-1) + fiboRecursivo(n-2) + fiboRecursivo(n-3)

generarFiboRec :: Integer -> IO() 
generarFiboRec n = do
    if n >= 0
    then do
       generarFiboRec (n-1)
       putStr $ (show(fiboRecursivo n)++" ")
    else putStr ""

main :: IO()
main = do
    putStrLn ("Generar los n terminos:")
    n <- getLine
    putStrLn ("Fibonnaci Estructural")
    generarFiboEst (read n) (-1) 1 0
    putStrLn ("\nFibonnaci Recursivo")
    generarFiboRec (read n)
