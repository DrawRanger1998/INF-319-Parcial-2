object ScalaFibonnaci {

  // Fibonnaci estructural
  def fiboEstructural(n:Int): Int = {
    var f = 0
    var f1 = -1
    var f2 = 1
    var f3 = 0
    for(w <- 0 to n){
      f = f1 + f2 + f3
      f1 = f2
      f2 = f3
      f3 = f
      print(f)
      print(" ")
    }
    return 0
  }

  // Fibonnaci Recursivo
  def fiboRecursivo(n:Int): Int = {
      if(n >= 0) {
        fiboRecursivo(n-1)
        print(fibonnaci(n))
        print(" ")
      }
      return 0
  }

  def fibonnaci(n:Int): Int = {
    if (n == 0) {
        return 0
    } else if( n == 1 || n == 2) {
        return 1
    } else{
        return fibonnaci(n-1) + fibonnaci(n-2) + fibonnaci(n-3)
    }
  }


  def main(args:Array[String]):Unit = {
      println("Generar los n terminos:")
      var n = scala.io.StdIn.readInt()
      println("Fibonnaci Estructural")
      fiboEstructural(n)
      println("\nFibonnaci Recursivo")
      fiboRecursivo(n)
  }
}