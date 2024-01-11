namespace MiniChallenegeFivetoSeven.Services.reverseIntService;

    public class reverseIntService : IreverseIntService
     {
         public string reverse = "";

        public string ReverseInt(string userInput){

         bool isNum = Int32.TryParse(userInput, out int num1);

           if(isNum){
            for(int i = num1.ToString().Length - 1; i >= 0; i--)
             {
                reverse += num1.ToString()[i];
             }

             return $"The reverse of {num1} is : {reverse}";
           }

        else{
            return $"That is NOT a number Bucko";
            }
        }

    }
