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



function main() {
    const n = parseInt(readLine(), 10);
    
    var binary = n.toString(2);
    var ch_array = Array.from(binary);
    
    var con = 0;
    var max = 0;
    ch_array.forEach(x=>{
        if(x=='1'){
            con++
        }else{
            con=0;
        }
        
        if(con>max){
            max=con;
        }
    });
    console.log(max);
}
