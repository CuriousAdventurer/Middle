using System;

public class Program
{
    public static void Main()
    {
        
        string[] originalArray = { "it's", "my", "life", "baby", "lalala", "ha" };
     
        
        string[] newArray = FilterArray(originalArray);

        
        Console.WriteLine("Новый массив строк с длиной <= 3:");
        foreach (string str in newArray)
        {
            Console.WriteLine(str);
        }
    }

    public static string[] FilterArray(string[] originalArray)
    {
        int count = 0;
      
        for (int i = 0; i < originalArray.Length; i++)
        {
            if (originalArray[i].Length <= 3)
            {
                count++;
            }
        }

        
        string[] newArray = new string[count];
        int index = 0;

     
        for (int i = 0; i < originalArray.Length; i++)
        {
            if (originalArray[i].Length <= 3)
            {
                newArray[index] = originalArray[i];
                index++;
            }
        }

        return newArray;
    }
}
