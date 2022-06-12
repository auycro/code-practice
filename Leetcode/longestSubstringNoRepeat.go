package main

import "fmt"

func lengthOfLongestSubstring(s string) int {
	var max int
	var start int

	var hash = make(map[string]int)
	for i := 0; i < len(s); i++ {
		if _, ok := hash[string(s[i])]; ok {
			if start <= hash[string(s[i])] {
				start = hash[string(s[i])] + 1
			}
		}
		hash[string(s[i])] = i
		currentSize := i - start + 1
		if currentSize > max {
			max = i - start + 1
		}
		//fmt.Printf("%v\n", hash)
	}
	return max
}

func main() {
	fmt.Println(lengthOfLongestSubstring("abcabcbb"))
	fmt.Println(lengthOfLongestSubstring("bbbbbb"))
	fmt.Println(lengthOfLongestSubstring("pwwkew"))
}
