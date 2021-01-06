function processData(input) {
  //Enter your code here
  var data = input.split("\n");
  //printPrime(data[1]);
  for (var i=1;i<data.length;i++){
    //console.log(data[i]);
    printPrime(data[i]);
  }
} 

function printPrime(input) {
  if (input == 1){
      console.log("Not prime");
      return;
  }
  
  var limit = Math.ceil(Math.sqrt(input));
  //console.log('limit:'+limit);
  for(var i=2;i <= limit; i++){
      if (input != i && input % i == 0){
          console.log("Not prime");
          return;
      }
  }
  console.log("Prime");
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
