#!bin/bash
for I in {1..99}
do
  REMAINDER=$(( $I % 2));
  #echo $REMAINDER;
  if [ $REMAINDER -eq 1 ]
  then
    echo $I
  fi
done