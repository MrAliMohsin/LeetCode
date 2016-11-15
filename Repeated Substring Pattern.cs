public bool RepeatedSubstringPattern(string str)
        {
            if (str.Length <= 10000)
            {
                int x =0 , y=0;
                string substring;
                int half = str.Length / 2;
                int i = half;
                //I am starting from half of the string and then comparing so if a string is compostition of two substring
                //we do not need to iterate all values
                while (i >= 1)
                {
                    //A substring of length i will make the whole string only if 
                    //i (the length of substring) will divide the length of whole string completely
                    if (str.Length % i == 0)
                    {
                        //x is the number that how many times we have to add the substrings to make whole string
                        x = str.Length / i;
                        y = 1;
                        // Gives me substring of size i from 0 to i-1
                        substring = str.Substring(0, i);
                        //I have tried using string only but it was slow and it timed out during submition at leet code
                        //So I am using StringBuilder as it is fast
                        StringBuilder sb = new StringBuilder();
                        while (y <= x)
                        {
                            sb.Append(substring);
                            y++;
                        }
                        if (sb.ToString().Equals(str))
                            return true;
                    }
                    i--;
                }
                return false;
            }
            return false;
        }