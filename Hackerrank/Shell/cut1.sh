#!bin/bash
while read INPUT
do
  echo $INPUT | cut -c3-1
done