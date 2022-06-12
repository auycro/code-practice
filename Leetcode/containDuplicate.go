package main

import (
	"fmt"
	"sort"
)

func containDuplicate(nums []int) bool {
	h := make(map[int]struct{})
	for _, v := range nums {
		if _, ok := h[v]; ok {
			return true
		}
		h[v] = struct{}{}
	}
	return false
}

func containDuplicateSort(nums []int) bool {
	sort.Ints(nums)
	for i := 0; i < len(nums)-1; i++ {
		if nums[i] == nums[i+1] {
			return true
		}
	}
	return false
}

func main() {
	testData1 := []int{1, 2, 3, 4, 5}
	testData2 := []int{1, 2, 3, 4, 5, 5}

	fmt.Println(containDuplicate(testData1))
	fmt.Println(containDuplicate(testData2))

	fmt.Println(containDuplicateSort(testData1))
	fmt.Println(containDuplicateSort(testData2))
}
