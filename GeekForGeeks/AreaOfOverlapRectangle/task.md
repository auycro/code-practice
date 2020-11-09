Given two overlapping rectangles on a plane. We are given bottom left and top right points of the two rectangles. We need to find the total area of overlap block.
 
^ Y
|
|          _________r2
|         |        |
|   ______|__r1    |
|  |      |__|_____|
|  |     l2  |       
|  |_________|
|  l1               
|--------------------- > X


Examples: 

Input : Point l1 = {2, 2}, r1 = {5, 7};
        Point l2 = {3, 4}, r2 = {6, 9};
Output :Total Area = 24 

Input : Point l1 = {2, 1}, r1 = {5, 5};
        Point l2 = {3, 2}, r2 = {5, 7};
Output :Total Area = 16