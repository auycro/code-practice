using System;

//https://leetcode.com/problems/rectangle-area/description/

/******
sqr1 
  _________  (C,D)
  |       |
  |       |
  |_______|
(A,B)

sqr2
  _________  (G,H)
  |       |
  |       |
  |_______|
(E,F)

Overlap

^ Y
|    _________  (C,D)
|    |       |
|    |     __|_____ (G,H)
|    |____|__|     |
|  (A,B)  |        |
|         |________|
|      (E,F)
|--------------------- > X


*******/


public class Solution {
    public int ComputeArea(int A, int B, int C, int D, int E, int F, int G, int H) {
        int areaOfSqr1 = (C-A)*(D-B);
        int areaOfSqr2 = (E-G)*(F-H);
        
        int left = Math.Max(A, E);
        int right = Math.Min(G, C);
        int bottom = Math.Max(F, B);
        int top = Math.Min(D, H);
        
        int overlap = 0;
        if (right > left && top > bottom)
            overlap = (right - left) * (top - bottom);   
        
        return areaOfSqr1 + areaOfSqr2 - overlap;
    }
}