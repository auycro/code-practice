import java.util.*;

class Person {
	protected String firstName;
	protected String lastName;
	protected int idNumber;
	
	// Constructor
	Person(String firstName, String lastName, int identification){
		this.firstName = firstName;
		this.lastName = lastName;
		this.idNumber = identification;
	}
	
	// Print person data
	public void printPerson(){
		 System.out.println(
				"Name: " + lastName + ", " + firstName 
			+ 	"\nID: " + idNumber); 
	}
	 
}

class Student extends Person{
	private int[] testScores;

    /*	
    *   Class Constructor
    *   
    *   @param firstName - A string denoting the Person's first name.
    *   @param lastName - A string denoting the Person's last name.
    *   @param id - An integer denoting the Person's ID number.
    *   @param scores - An array of integers denoting the Person's test scores.
    */
    // Write your constructor here
    Student(String firstName, String lastName, int id, int[] scores){
        super(firstName,lastName,id);
        this.testScores = scores;
    }

    /*	
    *   Method Name: calculate
    *   @return A character denoting the grade.
    */
    // Write your method here
    char calculate(){
        double total = 0;
        for(int i=0; i<testScores.length; i++){
            total = total + testScores[i];
        }
        double average = total/testScores.length;
        //T < D < P < A < E < O
        if (average < 40){
            return 'T';
        }else if(average < 55){
            return 'D';
        }else if(average < 70){
            return 'P';
        }else if(average < 80){
            return 'A';
        }else if(average < 90){
            return 'E';
        }else{
            return 'O';
        }      
    }
}

class Solution {