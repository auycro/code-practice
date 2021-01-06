function processData(input) {
  //Enter your code here
  var data = input.split("\n");
  
  var return_date = convertToDate(data[0]);
  var due_date = convertToDate(data[1]);
  
  var fine = calculateFine(return_date,due_date);
  console.log(fine);
}

function convertToDate(line){
  var data = line.split(" ");
  var date = new Date(Date.parse(`${data[1]}-${data[0]}-${data[2]}`));
  //console.log(date);
  return date;
}

function calculateFine(return_date,due_date){
  if (due_date >= return_date)
      return 0;
  
  if (return_date.getFullYear() - due_date.getFullYear() > 0)
      return 10000;
  
  var diff_time = return_date.getTime() - due_date.getTime(); 
  //console.log(diff_time);
  
  var diff_days = diff_time / (1000 * 60 * 60 * 24);
  //console.log('day:',diff_days);
  var diff_months = diff_time / (1000 * 60 * 60 * 24 * 30);
  //console.log('month:',diff_months);
  var diff_years = diff_time / (1000 * 60 * 60 * 24 * 30 * 12);
  //console.log('year:',diff_years);
  
  if (parseInt(diff_years, 10) > 0){
      return 10000;
  } else if(parseInt(diff_months, 10) > 0){
      var months = parseInt(diff_months, 10);
      return months * 500;
  } else {
      return diff_days * 15;
  }
  
  return -1;
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
