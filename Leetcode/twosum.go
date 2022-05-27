package twosum

import "fmt"

//BRUTE
func twoSum(nums []int, target int) []int {
	//fmt.Println(target)
	result := []int{}
	for i := 0; i < len(nums)-1; i++ {
		for j := i + 1; j < len(nums); j++ {
			if nums[i]+nums[j] == target {
				result = []int{i, j}
			}
		}
	}

	return result
}

//Hash
func twoSumHash(nums []int, target int) []int {
	m := make(map[int]int)
	for i, val := range nums {
		m[val] = i
	}

	for i, _ := range nums {
		complement := target - nums[i]
		if idx, ok := m[complement]; ok {
			if idx != i {
				return []int{i, idx}
			}
		}
	}

	return nil
}

//Use Pointer
func twoSumPointer(numbers []int, target int) []int {
	l := 0
	r := len(numbers) - 1

	for l < r {
		sum := target - (numbers[l] + numbers[r])
		switch {
		case sum == 0:
			return []int{l, r}
		case sum > 0:
			l++
		case sum < 0:
			r--
		}
	}

	return nil
}

func main() {
	fmt.Printf("twoSum: %v\n", twoSum([]int{1, 4, 5, 5, 7, 10}, 10))

	fmt.Printf("twoSumHash: %v\n", twoSumHash([]int{1, 4, 5, 5, 7, 10}, 10))

	fmt.Printf("twoSumPointer: %v\n", twoSumPointer([]int{1, 4, 5, 5, 7, 10}, 10))
}
