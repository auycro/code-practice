'use strict';

process.stdin.resume();
process.stdin.setEncoding('utf-8');

let inputString = '';
let currentLine = 0;

process.stdin.on('data', inputStdin => {
    inputString += inputStdin;
});

process.stdin.on('end', _ => {
    inputString = inputString.replace(/\s*$/, '')
        .split('\n')
        .map(str => str.replace(/\s*$/, ''));

    main();
});

function readLine() {
    return inputString[currentLine++];
}

function calHourglass(arr,i,j){
    if (i+2 > arr.length-1)
        return Number.MIN_SAFE_INTEGER;
        
    if (j+2 > arr[i].length-1)
        return Number.MIN_SAFE_INTEGER;
/*
hourglass
 [i][j]    [i][j+1] [i][j+2]
          [i+1][j+1]
 [i+2][j] [i+2][j+2] [i][j+2]
*/

    var sum = 0;
    sum += arr[i][j] + arr[i][j+1] + arr[i][j+2];
    sum += arr[i+1][j+1];
    sum += arr[i+2][j] + arr[i+2][j+1] + arr[i+2][j+2];        
        
    return sum;
}

function maxHourglass(arr){
    var max = Number.MIN_SAFE_INTEGER;
    for (var i=0;i<arr.length;i++){
        for (var j=0;j<arr[i].length;j++){
            var sum = calHourglass(arr,i,j);
            if (sum > max){
                max = sum;
            }
        }
    } 
    console.log(max);
}

function main() {
    let arr = Array(6);

    for (let i = 0; i < 6; i++) {
        arr[i] = readLine().split(' ').map(arrTemp => parseInt(arrTemp, 10));
    }

    //console.log(arr);
    maxHourglass(arr);
}
