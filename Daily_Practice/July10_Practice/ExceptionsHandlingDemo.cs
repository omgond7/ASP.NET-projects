//Om Prashant Gond IT SSGMCE July 10
using System;

class ExceptionHandelingDemo{
    static void checkAge(int age){
        if(age < 18){
            throw new InvalidAgeException("Not eligible for the class test");
        }
        else{
            Console.Write("Can attempt placement dirve");
        }
    }
    public void Run(){
        try{
            int a = 50;
            int b = 0;
            int c = a/b;
            Console.WriteLine("Result: "+c);
        }
        catch(DivideByZeroException e){
            Console.WriteLine("Error: " + e.Message);
        }
        catch(Exception e){
            Console.WriteLine("Error: " + e.Message);
        }
        finally{
            Console.WriteLine("Execution done");
        }
        
        try{
            checkAge(20);
        }
        catch(Exception e){
            Console.WriteLine("Error: " + e.Message);
        }
    }
}