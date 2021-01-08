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

function processData(n, k){
    var max = Number.MIN_SAFE_INTEGER;
    for(var i=1;i<=n-1;i++){
        for(var j=i+1;j<=n;j++){
            var temp = i&j;
            if(temp < k && max < temp)
                max = temp;
        }
    }
    console.log(max);
}

function main() {
    const t = parseInt(readLine(), 10);

    for (let tItr = 0; tItr < t; tItr++) {
        const nk = readLine().split(' ');

        const n = parseInt(nk[0], 10);

        const k = parseInt(nk[1], 10);
        
        processData(n, k);
    }
}
