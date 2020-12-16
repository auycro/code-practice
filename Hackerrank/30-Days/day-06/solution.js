const util = require('util'); 

function processText(text){
    var ch = text.split('');
    var even_ch = [];
    var odd_ch = [];
    for(var i=0;i<ch.length;i++){
        if (i%2==0){
            even_ch.push(ch[i]);
        } else {
            odd_ch.push(ch[i]);
        }
    }
    var result = util.format('%s %s', even_ch.join(""), odd_ch.join("")); 
    
    return result;
}

function processData(input) {
    //Enter your code here
    var data = input.split('\n');
    //console.log(data);
    for (var i=1;i<data.length;i++){
        console.log(processText(data[i]));
    }
} 

process.stdin.resume();
process.stdin.setEncoding("ascii");
_input = "";
process.stdin.on("data", function (input) {
    _input += input;
});

process.stdin.on("end", function () {
   processData(_input);
});
