// namespace TwistedFizzBuzz;
// public class Class1
// {

// }

namespace UtilityLibraries;

public class TwistedFizzBuzz
{

    public string token1 {get;set;}="Fizz";
    public string token2 {get;set;}="Buzz";
    public int divisor1 {get;set;}=3;
    public int divisor2 {get;set;}=5;
public TwistedFizzBuzz(){

}
    public TwistedFizzBuzz(string customtk1,string customtk2,int customdiv1,int customdiv2){
        token1=customtk1;
        token2=customtk2;
        divisor1=customdiv1;
        divisor2=customdiv2;
    }

    // public static bool StartsWithUpper(this string? str)
    // {
    //     if (string.IsNullOrWhiteSpace(str))
    //         return false;

    //     char ch = str[0];
    //     return char.IsUpper(ch);
    // }

    private string FizzBuzz(int i){
         if (i % divisor1 == 0 && i % divisor2 == 0)  
        {  
            return string.Format("{0}{1}",token1,token2);  
        }  
        else if (i % divisor1 == 0)  
        {  
           return string.Format("{0}",token1);  
        }  
        else if (i % divisor2 == 0)  
        {  
           return string.Format("{0}",token2);  
        }  
        else  
        {  
            return string.Format(i.ToString());  
        }  
    }

    public List<string> FizzBuzzForRange(int start,int end){
        List<string> result=new List<string>();
        for(int i=start;i<end;i++){
            result.Add(FizzBuzz(i));
        }
        return result;
    }

    public List<string> FizzBuzzForRange(int[] SET){
        List<string> result=new List<string>();
        foreach(int i in SET){
            result.Add(FizzBuzz(i));
        }
        return result;
    }
    
}