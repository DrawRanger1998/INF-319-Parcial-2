namespace Library1

module GenerarFibo =
    let fiboEstrucut n =
        let mutable cad = ""
        let mutable f = 0
        let mutable f1 = -1
        let mutable f2 = 1
        let mutable f3 = 0
        for i in 1..(n+1) do
            f <- f1 + f2 + f3
            f1 <- f2
            f2 <- f3
            f3 <- f
            cad <- cad + f.ToString() + " "
        cad

    let rec fibonnaci n =
        if n = 0 then 0
        elif n = 1 || n = 2 then 1
        else fibonnaci(n-1) + fibonnaci(n-2) + fibonnaci(n-3)

    let rec fiboRecursivo n x =
        if n >= 0 then
            let mutable cad = fiboRecursivo (n-1) x
            cad <- cad + (fibonnaci n).ToString()+" "
            cad
        else
            ""

type Class1() = 
    member this.X = "F#"
