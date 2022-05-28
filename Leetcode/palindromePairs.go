package palindromePairs

import "fmt"

func isPalindrome(s string) bool {
	for i := 0; i < len(s)/2; i++ {
		if s[i] != s[len(s)-1-i] {
			return false
		}
	}
	return true
}

func palindromePairs(words []string) [][]int {
	var result [][]int
	for i, word := range words {
		for j, w := range words {
			if i == j {
				continue
			}
			if isPalindrome(word + w) {
				result = append(result, []int{i, j})
			}
		}
	}
	return result
}

func main() {
	fmt.Printf("%v", palindromePairs([]string{"abcd", "dcba", "lls", "s", "sssll"}))
	fmt.Println("Failed on palindromePairs-testcase.txt (Time limit exceeded)")
}
