public class Solution {
    public int FourSumCount(int[] A, int[] B, int[] C, int[] D)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            foreach (var a in A)
                foreach (var b in B)
                {
                    //Get all the possible values for a+b
                    int k = a + b;
                    int v;
                    //If the same a + b already exists then add 1 more to its existance
                    if (map.TryGetValue(k, out v))
                        map[k] = v + 1;
                    //If it does not exists then add that value (a+b) as a key to map and 1 in value as its first existance
                    else
                        map.Add(k, 1);
                }

            int result = 0;

            foreach (var c in C)
                foreach (var d in D)
                {
                    int v;
                    //As we have a+b in map so all check for all possible value of c+d
                    //And if A+B+C+D=0 mean A+B=-C-D so the key stored in map would be (-C -D)
                    //Get the existance of each key in v by (out v) and add it to result.
                    if (map.TryGetValue(-c -d, out v))
                        result += v;
                }

            return result;
        }
}