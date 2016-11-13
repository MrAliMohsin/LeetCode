public class Solution {
    public bool CanWinNim(int n) {
        if (n%4 !=0)
        return true;
        else 
        return false;
    }
}
/*This is a straightforward code that uses the concept of winning-losing positions. A position is losing if from that position, if you took any number of allowed stones [1,2,3] you would go only to winning positions and a position is considered winning if there's at least one move that can lead you to a losing position.

Initially all the available moves [1,2,3] are winning positions, then we can easily derive the following:

1 W

2 W

3 W

4 L (1,2,3 lead to W)

5 W (1 leads to L)

6 W (2 leads to L)

7 W (3 leads to L)

8 L

9 W

10 W

..

So we can see that only multiple of 4s are losing positions for the first player, while all other numbers are winning.*/

//Explanation regards to https://discuss.leetcode.com/topic/30682/1-liner-java-solution-with-nim-game-explanation/2