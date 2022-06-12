package main

import (
	"fmt"
	"strings"
)

func validateSquare(nums []string) bool {
	side := make(map[string]int)

	for _, v := range nums {
		if _, ok := side[v]; ok {
			side[v]++
		} else {
			side[v] = 1
		}

		if side[v] == 4 {
			return true
		}
	}

	return false
}

func main() {
	lines := []string{"6", "1 2 2 3 2 2"}
	n := lines[0]
	sides := strings.Split(lines[1], " ")

	fmt.Println(n)
	fmt.Printf("%v\n", sides)

	fmt.Printf("%v\n", validateSquare(sides))
}
