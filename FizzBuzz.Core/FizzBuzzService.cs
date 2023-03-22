namespace FizzBuzz.Core;
public class FizzBuzzService
{
    public string Print(int number)
    {
        if( number%3==0 && number%5==0){
            return "FizzBuzz";
        }
        else if(IsDivisibleByThree(number)){
            return "Fizz";
        }
        else if(IsDivisibleByFive(number)){
            return "Buzz";
        }
        return (number.ToString());
    }
    private bool IsDivisibleByThree(int number)
{
    return number %3 ==0;
}
private bool IsDivisibleByFive(int number)
{
    return number %5 ==0;
}
}

