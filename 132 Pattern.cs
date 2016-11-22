public bool Find132pattern(int[] nums)
        {
            //Check if array is empty or has less than 3 members and return false if it does
            if (nums.Length < 3 || nums == null)
                    return false;
            //For checking 132 pattern declaring 1 as one and 3 as three    
            int one=nums[0], three;
            for (int i = 0; i < nums.Length; i++)
            {
                //If found another next element less than one then declare it one
                 if(nums[i]<one)
                    one = nums[i];
                //If found another element greater than one whose index is also larger than IndexOf(one)
                //Declare it as three
                else if(nums[i]>one)
                {
                    three = nums[i];
                    int j = i+1;
                    //As we have found our one and three 13_ so we need to find if a 2 exists
                    //Starting from next Element i.e j = i+1 itterate whole array to check if found an element which is 
                    //Greater then one but smaller than three
                    while(j<nums.Length)
                    {
                        
                        if(nums[j]<three && nums[j]>one)
                        {
                            //Return true of 2 is found and completed the 132 pattern
                            return true; 
                        }
                        j++;
                    }
                }

                    
            }
            return false;
        }