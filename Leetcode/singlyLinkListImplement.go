package main

import "fmt"

type ListNode struct {
	Val  int
	Next *ListNode
}

func main() {
	node1 := &ListNode{
		Val:  1,
		Next: nil,
	}

	node2 := &ListNode{
		Val:  2,
		Next: nil,
	}

	node3 := &ListNode{
		Val:  3,
		Next: nil,
	}

	node1.Next = node2
	node2.Next = node3

	prettyPrint(node1)
}

func prettyPrint(node *ListNode) {
	for node != nil {
		fmt.Printf("%v", node.Val)
		if node.Next != nil {
			fmt.Printf("->")
		}
		node = node.Next
	}
	fmt.Printf("\n")
}
