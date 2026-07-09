using System.Collections.Generic;
class Collections{
    public void Run(){
        List<String> obj = new List<string>();
        obj.Add("Om");
        obj.Add("Gitesh");
        obj.Add("Sahil");


        foreach (string name in obj)
        {
            Console.WriteLine(name);
        }
    }
}



