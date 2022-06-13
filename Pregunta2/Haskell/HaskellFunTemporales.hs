suma3terminos = (\x y z -> x + y + z)
fibonnaci = \n -> (generarFibo n (-1) 1 0)

generarFibo :: Integer -> Integer -> Integer -> Integer -> IO() 
generarFibo n f1 f2 f3 = do
    if n >= 0
    then do
       let f = suma3terminos f1 f2 f3
       putStr $ (show(f)++" ")
       generarFibo (n-1) f2 f3 f
    else putStr ""

main :: IO()
main = do
    putStrLn ("Generar los n terminos:")
    putStrLn ("Fibonnaci con funciones temporales")
    n <- getLine
    fibonnaci (read n)

