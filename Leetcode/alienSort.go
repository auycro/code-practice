package alienSort

import (
	"fmt"
	"strings"
)

func isAlienSorted(words []string, order string) bool {
	split := strings.Split(order, "")
	//fmt.Printf("%v", split)
	sortOrder := make(map[string]int)
	for i, val := range split {
		sortOrder[val] = i
	}
	//fmt.Printf("%v", sortOrder)
	for i := 0; i < len(words)-1; i++ {
		//fmt.Printf("%s %s", words[i], words[i+1])
		if !isSorted(words[i], words[i+1], sortOrder) {
			return false
		}
	}

	return true
}

func isSorted(s1, s2 string, sortOrder map[string]int) bool {
	for i := 0; i < len(s1); i++ {
		//fmt.Printf("%s %s\n", string(s1[i]), string(s2[i]))
		if i >= len(s2) {
			return false
		}

		if sortOrder[string(s1[i])] > sortOrder[string(s2[i])] {
			return false
		}

		if sortOrder[string(s1[i])] < sortOrder[string(s2[i])] {
			return true
		}

		if sortOrder[string(s1[i])] == sortOrder[string(s2[i])] {
			continue
		}
	}
	return true
}

func main() {
	fmt.Printf("\nResult1: %v\n", isAlienSorted([]string{"hello", "hello", "leetcode"}, "hlabcdefgijkmnopqrstuvwxyz"))
	fmt.Printf("\nResult2: %v\n", isAlienSorted([]string{"word", "world", "row"}, "worldabcefghijkmnpqstuvxyz"))
	fmt.Printf("\nResult3: %v\n", isAlienSorted([]string{"apple", "app"}, "hlabcdefgijkmnopqrstuvwxyz"))
}
