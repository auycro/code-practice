package main

import (
	"fmt"
	"strings"
)

func simplifyEmails(email string) string {
	domain := email[strings.Index(email, "@") : len(email)-1]
	localname := email[:strings.Index(email, "@")]
	//fmt.Printf("localname: %s\n", localname)

	//delete .
	localname = strings.Replace(localname, ".", "", -1)
	//fmt.Printf("localname: %s\n", localname)

	//ignore +
	localname = strings.Split(localname, "+")[0]
	//fmt.Printf("localname: %s\n", localname)

	return localname + domain
}

func numUniqueEmails(emails []string) int {
	valid_email := make(map[string]string)
	for _, email := range emails {
		simplify := simplifyEmails(email)
		//fmt.Printf("%s\n", simplify)
		valid_email[simplify] = email
	}
	//fmt.Printf("%v", valid_email)
	return len(valid_email)
}

func main() {
	//Test1
	fmt.Println(numUniqueEmails([]string{"test.email+alex@leetcode.com", "test.e.mail+bob.cathy@leetcode.com", "testemail+david@lee.tcode.com"}))
	//Test2
	fmt.Println(numUniqueEmails([]string{"a@leetcode.com", "b@leetcode.com", "c@leetcode.com"}))
	//Test3
	fmt.Println(numUniqueEmails([]string{"test.emailalex@leetcode.com", "test.e.mailbob.cathy@leetcode.com", "testemail+david@lee.tcode.com"}))
}
