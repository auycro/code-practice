function processData(input) {
  //Enter your code here
  var data = input.split('\n');
  //console.log(data);
  var data_size = data.shift();
  var phonebook = new Map();
  
  for(var i=0;i<data_size;i++){
      var contact = data.shift().split(' ');
      phonebook.set(contact[0],contact[1]);
  }
  //console.log(phonebook);    
  do {
      var name = data.shift();
      if (phonebook.has(name)){
          console.log("%s=%s",name,phonebook.get(name));
      } else {
          console.log('Not found');
      }
  } while (data.length > 0);

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
