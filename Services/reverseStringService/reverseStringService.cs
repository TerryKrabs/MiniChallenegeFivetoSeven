namespace MiniChallenegeFivetoSeven.Services.reverseStringService;

    public class reverseStringService : IreverseStringService
    {
          public string reverseWord = "";

         public string ReverseString(string userInput){

        
            for(int i = userInput.Length - 1; i >= 0; i--)
             {
                reverseWord += userInput[i];
             }

             return $"The reverse of {userInput} is : {reverseWord}";
           

        
        }
    }
