function processData(input) {
  //Enter your code here
  var data = input.split('\n');
  //console.log(data);
  
  var data_size = parseInt(data[0]);    
  var contacts = data.slice(1,data_size+1);
  var queries = data.slice(data_size+1,data.length);
  
  var phonebook = new Map();
  
  for(var i=0;i<contacts.length;i++){
      var contact = contacts[i].split(' ');
      phonebook.set(contact[0],contact[1]);
  }
  //console.log(phonebook);

  for(var i=0;i<queries.length;i++){
      var name = queries[i]
      if (phonebook.has(name)){
          console.log("%s=%s",name,phonebook.get(name));
      } else {
          console.log('Not found');
      }
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
