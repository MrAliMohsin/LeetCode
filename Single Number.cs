public int SingleNumber(int[] nums)
        {
			//We need to do it in time O(n) and memory 0(1)
			//So we can't use sort and find.
            //We will use XOR gate here. XOR Gate return 0 on A XOR A . Mean if both are same XOR will return 0
			// A XOR A =0 and A XOR B XOR A = B
            int xor = nums[0];
            for (int i = 1; i < nums.Length; i++)
                xor = xor ^ nums[i];
            return xor;
        }