process.stdin.resume();
process.stdin.setEncoding('ascii');

var input_stdin = "";
var input_stdin_array = "";
var input_currentline = 0;

process.stdin.on('data', function (data) {
    input_stdin += data;
});

process.stdin.on('end', function () {
    input_stdin_array = input_stdin.split("\n");
    main();    
});

function readLine() {
    return input_stdin_array[input_currentline++];
}

function Person(initialAge){
    var age = 0;
    // Add some more code to run some checks on initialAge
    constructor(initialAge)
    {
        if(initialAge<0){
            console.log('Age is not valid, setting age to 0.');
            age = 0;
        }
        age = initialAge;
    }
    
    this.amIOld=function(){
    // Do some computations in here and print out the correct statement to the console
        var text = "You are ";
        if (age < 13){
            text = text + "young.";
        }else if(age < 18){
            text = text + "a teenager.";
        }else{
            text = text + "old.";
        }
        console.log(text);   
    };
    
    this.yearPasses=function(){
        // Increment the age of the person in here
        age++;
    };
}

function main() {

var T=parseInt(readLine());
for(i=0;i<T;i++){
    var age=parseInt(readLine());
    var p=new Person(age);
    p.amIOld();
    for(j=0;j<3;j++){
        p.yearPasses();
        
    }
    p.amIOld();
    console.log("");   
    }
}

