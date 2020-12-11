#!bin/bash
while read INPUT
#filename='testdata-cut2.txt'
#while IFS= read INPUT
do
  #SUB2=`echo $INPUT | cut -c2-1`
  #SUB7=`echo $INPUT | cut -c7-1`
  #echo $SUB2 $SUB7
  echo $INPUT | cut -c2,7
done
#done < $filename