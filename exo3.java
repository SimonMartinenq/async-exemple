import java.util.concurrent.*; 
//import java.util.concurrent.ExecutionException; 
//import java.util.concurrent.ExecutorService; 
//import java.util.concurrent.Executors; 
//import java.util.concurrent.Future; 

public class Main {
 
  public static void main(String args[]) throws InterruptedException, ExecutionException { 

    ExecutorService es = Executors.newSingleThreadExecutor();  

    Future<String> future = es.submit(() ->   {  
      Factorial(7);
      return "Task finished";
    });

    while(!future.isDone()){  
      System.out.println("The task is still in process....."); 
      Thread.sleep(200);  
    }  
    
    System.out.println("Task completed! getting the result");  
    String result = future.get();  
    System.out.println(result);  
    es.shutdown();  
  }

  private static void Factorial(int n) throws InterruptedException, ExecutionException{
    int factorial = 1;
    for (int i = 1; i <= n; i++)
    {
        factorial = factorial * i;
         System.out.println("The factorial of " + n + " is : " + factorial);
      Thread.sleep(100); 
    }
    Thread.sleep(5000);
    System.out.println("The factorial of " + n + " is : " + factorial);
  }
}