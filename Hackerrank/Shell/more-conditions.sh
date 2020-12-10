#!bin/bash
read INT_X
read INT_Y
read INT_Z
if  [ $INT_X == $INT_Y ] && [ $INT_X == $INT_Z ] && [ $INT_Y == $INT_Z ];
  then echo "EQUILATERAL"
elif [ $INT_X == $INT_Y ] || [ $INT_X == $INT_Z ] || [ $INT_Y == $INT_Z ];
  then echo "ISOSCELES"
else
  echo "SCALENE"
fi