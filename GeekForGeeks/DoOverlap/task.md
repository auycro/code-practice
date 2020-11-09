Given two rectangles, find if the given two rectangles overlap or not.
Note that a rectangle can be represented by two coordinates, top left and bottom right. So mainly we are given following four coordinates.
l1: Top Left coordinate of first rectangle.
r1: Bottom Right coordinate of first rectangle.
l2: Top Left coordinate of second rectangle.
r2: Bottom Right coordinate of second rectangle.

rectanglesOverlap

We need to write a function bool doOverlap(l1, r1, l2, r2) that returns true if the two given rectangles overlap.


^ Y
|
|        l2_________
|         |        |
| l1______|__      |
|  |      |__|_____|r2
|  |         |       
|  |_________|r1
|                 
|--------------------- > X
