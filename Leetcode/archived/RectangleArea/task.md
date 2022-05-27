Given two rectangles, find if the given two rectangles overlap or not.
Note that a rectangle can be represented by two coordinates, top left and bottom right. So mainly we are given following four coordinates.

l1: Bottom Left coordinate of first rectangle. (A,B)
r1: Top Right coordinate of first rectangle. (C,D)
l2: Bottom Left coordinate of second rectangle.  (E,F)
r2: Top Right coordinate of second rectangle.  (G,H)

rectanglesOverlap.png

We need to write a function int ComputeArea(A,B,C,D,E,F,G,H).


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