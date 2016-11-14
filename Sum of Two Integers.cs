public int GetSum(int a, int b) {
	
	//base case if b is 0 at starting or if a & b is zero while calling it recursively
         
	if (b == 0)
                return a;

	//a ^ b will give you sum of a and b but it will not deal carry mean 
	//4 ^ 3 will be 7 but 7 ^ 7 = 4 as it will ignore carry 1
	//We can use bitwise AND for carry here a & b will give us the carry
	// The << Operator shift bits left and fill with zero on the right.
         
	return GetSum(a ^ b, (a & b) << 1);
}
