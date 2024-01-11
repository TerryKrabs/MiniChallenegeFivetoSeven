namespace MiniChallenegeFivetoSeven.Services.OddOrEvenService;

    public class OddOrEvenService : IOddOrEvenService
    {
        public string OddOrEven(string num){

        bool success = Int32.TryParse(num, out int numbah);
 
        if(!success){
            return $"{num} is not a number ya fricking goober";
        }

        else if(numbah % 2 == 0){
             return $"{numbah} is an even number!";
        }

        else {
            return $"{numbah} is an odd number!";;
        }
    }       
    }
