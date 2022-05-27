//https://leetcode.com/problems/rectangle-overlap/submissions/

public class Solution {
    public bool IsRectangleOverlap(int[] rec1, int[] rec2) {
        int x1 = rec1[0];
        int y1 = rec1[1];
        int x2 = rec1[2];
        int y2 = rec1[3];
        
        int x3 = rec2[0];
        int y3 = rec2[1];
        int x4 = rec2[2];
        int y4 = rec2[3];
        
        /****
        [-1,0,1,1]
        [0,-1,0,1]
        ****/
        
        //validate rectanble
        if (x1 == x2 || y1 == y2 || x3 == x4 || y3 == y4)
          return false;
        
        if (x1 >= x4 || y1 >= y4)
          return false;
        
        if (x2 <= x3 || y2 <= y3)
          return false;
        
        return true;
    }
}

/****

^ Y
|
|           ___________ (x4,y4)
|          |           |
|   _______|__(x2,y2)  |
|  |(x3,y3)|__|________|
|  |          |       
|  |__________|
|  (x1,y1)               
|--------------------- > X


---not overlap pattern---
1
        [rec1] 
  [rec2]

2. 
         [rec2]
  [rec1]

3.

[-1,0,1,1]
[0,-1,0,1]

      1,1
  [rec1]   0,1
-1,0  [rec2]      
      0,-1

****/