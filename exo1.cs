/* // Programmation parallèle

using System;
using System.Threading;
using System.Threading.Tasks;

class Program {
	
	static void Factoriel(int n){
	    Console.WriteLine("sequentielle");

	    int i = 1;
		while(n!=1){
			i = i*n;
			n=n-1;
		}
	    
	    Thread.Sleep(1000);
	    Console.WriteLine(i);
	}
	
    public static async Task<int> Factorial(int n){
        Console.WriteLine("Factorial");
        int i = 1;
      
		while(n!=1){
			i = i*n;
			n=n-1;
		}
		Thread.Sleep(3000);
	    return i;
    }
	
	static async void FactorialAsync(int n){
	    Console.WriteLine("async");
	    Task<int> task = Factorial(n);
	    Console.WriteLine("avant");
	    Thread.Sleep(4000);
	    Console.WriteLine("apres");
        int count = await task;
        Console.WriteLine(count);

	}

    static void Main(string[] args) {
        FactorialAsync(3);
		//Factoriel(3);
		
    }
} */

// Programmation parallèle

using System;
using System.Threading;
using System.Threading.Tasks;

class Program {
	
	static void Factorial(int n){
	    Console.WriteLine("sequentielle");

	    int i = 1;
		while(n!=1){
			i = i*n;
			n=n-1;
		}
	    
	    Thread.Sleep(3000);
	    Console.WriteLine(i);
	}
	

	
	static async void FactorialAsync(int n){
	    Console.WriteLine("Async");
	    await Task.Run(()=>Factorial(n));
	}
	

    static void Main(string[] args) {
        FactorialAsync(3);
        Console.Read();
		//Factorial(3);
	
		
    }
}