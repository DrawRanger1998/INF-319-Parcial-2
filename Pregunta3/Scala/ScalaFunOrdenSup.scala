object ScalaFunOrdenSup {
    // Fibonnaci con funciones de orden superior
    def fib3terminos(fun:(Int,Int,Int)=>Int,n:Int,f1:Int,f2:Int,f3:Int):Unit = {
        if(n >= 0){
            var f = fun(f1,f2,f3)
            print(f)
            print(" ")
            fib3terminos(fun,n-1,f2,f3,f)
        }
    }

    def suma3terminos(f1:Int,f2:Int,f3:Int): Int= {
        f1+f2+f3
    }

    def main(args:Array[String]):Unit = {
        println("Generar lo n terminos:")
        println("Fibonnaci con funciones de orden superior")
        var n = scala.io.StdIn.readInt()
        fib3terminos(suma3terminos,n,-1,1,0)        
    }
}