#!bin/bash
read INPUT;
COND=`echo "$INPUT" | tr '[:lower:]' '[:upper:]'`
case $COND in
  Y)
    echo "YES"
    ;;
  N)
    echo "NO"
    ;;
esac
