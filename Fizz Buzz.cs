public static IList<string> FizzBuzz(int n)
        {
            //Declaring a new IList<> as the return type of the function is Ilist we could have done it with Simple List<> too.
            //For More about List<> and IList Check this http://stackoverflow.com/questions/1367539/ilistint-vs-listint
            IList<string> FizzBuzz = new List<string>();

            //Declaring int i =1 to itterate from 1 to n (n is the number given in this function)
            for (int i = 1; i <= n; i++)
            {
                //Using modulus Operator to get the remainder and if it is 0 mean it is divisible completely by 3 and 5
                //For more about modulus operator check this https://www.tradingcode.net/csharp/operators/modulus-operator/
                if (i % 3 == 0 && i % 5 == 0)
                {
                    FizzBuzz.Add("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    FizzBuzz.Add("Fizz");
                }
                else if (i % 5 == 0)
                {
                    FizzBuzz.Add("Buzz");
                }
                //Adding the exact number to the string after converting it to string value
                else
                {
                    FizzBuzz.Add((i).ToString());
                }
            }
            return FizzBuzz;
        }