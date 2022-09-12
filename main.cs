// Programmation parallèle

using System;
using System.Threading;
using System.Threading.Tasks;

class Program {
	
	static void Process_one(){
		int i = 0;
		while(i < 3){
			Console.WriteLine("Process_one");
			Task.Delay(3000).Wait();
			i++;
		}
	}
	static void Process_two(object max){
		int i = 0;
		while(i < (int)max){
			Console.WriteLine("Process_two");
			Task.Delay(3000).Wait();
			i++;
		}
	}

    static void Main(string[] args) {

		Thread thread = new Thread (new ThreadStart(Process_one));
		thread.Start();

		Thread thread2 = new Thread (new ParameterizedThreadStart(Process_two));
		thread2.Start(3);

		int i = 0;
		while(i < 3){
			Console.WriteLine("Main");
			Task.Delay(3000).Wait();
			i++;				
		}
    }
}


// Programmation asynchrone 

using System;
using System.Threading;
using System.Threading.Tasks;

class Program {

	static async Task Process_one_async(){
		await Task.Run(() => Process_one());
		Console.WriteLine("Process_one_async");		
	}

	static async Task Process_two_async(int max){
		await Task.Run(() => Process_two(max));
		Console.WriteLine("Process_two_async");		
	}	
	
	static void Process_one(){
		int i = 0;
		while(i < 3){
			Console.WriteLine("Process_one");
			Task.Delay(3000).Wait();
			i++;
		}
	}

	static void Process_two(int max){
		int i = 0;
		while(i < max){
			Console.WriteLine("Process_two");
			Task.Delay(3000).Wait();
			i++;
		}
	}

    static void Main(string[] args) {

		Process_one_async();
		Process_two_async(3);

		int i = 0;
		while(i < 3){
			Console.WriteLine("Main");
			Task.Delay(3000).Wait();
			i++;				
		}
    }
}
<amp-analytics config="https://www.googletagmanager.com/amp.json?id=GTM-52MBZ4M&amp;gtm.url=https://www.1jour1actu.com/culture/cest-qui-josephine-baker>" data-credentials="include"></amp-analytics>

<link rel="stylesheet" id="cmtooltip-css" href="https://www.1jour1actu.com/wp-content/plugins/enhanced-tooltipglossary/assets/css/tooltip.min.css?ver=5.8.2" type="text/css" media="all">
