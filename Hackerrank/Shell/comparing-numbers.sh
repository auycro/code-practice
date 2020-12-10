#!bin/bash
read VAL1
read VAL2

if [ $VAL1 -gt $VAL2  ]
  then echo "X is greater than Y"
elif [ $VAL1 -eq $VAL2 ] 
  then echo "X is equal to Y"
elif [ $VAL1 -lt $VAL2 ]
  then echo "X is less than Y"
fi
