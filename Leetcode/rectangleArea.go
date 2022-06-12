package main

import "fmt"

func main() {
	fmt.Printf("%v\n", computeArea(-3, 0, 3, 4, 0, -1, 9, 2))
	fmt.Printf("%v\n", computeArea(-2, -2, 2, 2, 3, 3, 4, 4))
}

func computeArea(ax1 int, ay1 int, ax2 int, ay2 int, bx1 int, by1 int, bx2 int, by2 int) int {
	areaA := (ax2 - ax1) * (ay2 - ay1)
	areaB := (bx2 - bx1) * (by2 - by1)
	x1 := max(ax1, bx1)
	y1 := max(ay1, by1)
	x2 := min(ax2, bx2)
	y2 := min(ay2, by2)
	if x1 >= x2 || y1 >= y2 {
		return areaA + areaB
	}
	return areaA + areaB - (x2-x1)*(y2-y1)
}

func max(a1, b1 int) int {
	if a1 > b1 {
		return a1
	}
	return b1
}

func min(a2, b2 int) int {
	if a2 < b2 {
		return a2
	}
	return b2
}
