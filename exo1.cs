using System;
using System.Threading;
using System.Threading.Tasks;

class Program {
	
	static void Factorial(int n){
	    int i = 1;
		while(n!=1){
			i = i*n;
			n=n-1;
		}
	    
	    Thread.Sleep(3000);
	    Console.WriteLine("Sync way");
	    Console.WriteLine(i);
	}
	

	
	static async void FactorialAsync(int n){
	    Console.WriteLine("Async way");
	    await Task.Run(()=>Factorial(n));
	}
	

    static void Main(string[] args) {
        FactorialAsync(3);
		Factorial(3);
		Console.Read();
    }
}