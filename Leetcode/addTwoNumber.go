package main

import (
	"fmt"
	"strconv"
)

/**
 * Definition for singly-linked list.
 * type ListNode struct {
 *     Val int
 *     Next *ListNode
 * }
 */
type ListNode struct {
	Val  int
	Next *ListNode
}

/// Failed on Big Number
/**
func addTwoNumbersFailed(l1 *ListNode, l2 *ListNode) *ListNode {
	result := getVal(l1) + getVal(l2)
	//fmt.Println(result)
	return ItoListNode(result)
}

func getVal(l *ListNode) int {
	if l.Next != nil {
		product_str := strconv.Itoa(getVal(l.Next)) + strconv.Itoa(l.Val)
		//fmt.Printf("%v", product_str)
		product, _ := strconv.Atoi(product_str)
		return product
	}
	return l.Val
}

func ItoListNode(input int) *ListNode {
	product_str := strconv.Itoa(input)
	array := strings.Split(product_str, "")

	for i, j := 0, len(array)-1; i < j; i, j = i+1, j-1 {
		array[i], array[j] = array[j], array[i]
	}

	//fmt.Println(len(array))
	return arrayToListNode(array)
}

func arrayToListNode(array []string) *ListNode {
	if len(array) == 0 {
		return nil
	}
	val, _ := strconv.Atoi(array[0])
	listNode := &ListNode{
		Val:  val,
		Next: nil,
	}
	if len(array) == 1 {
		return listNode
	}
	listNode.Next = arrayToListNode(array[1:])
	return listNode
}
***/

var carry, sum = 0, 0

func addTwoNumbers(l1 *ListNode, l2 *ListNode) *ListNode {
	result := &ListNode{}
	//fmt.Printf("addTwoNumber1: %v %v %v\n", l1.Val, l2.Val, carry)

	// Calculate the sum
	sum = carry
	if l1 != nil {
		sum += l1.Val
		l1 = l1.Next
	}
	if l2 != nil {
		sum += l2.Val
		l2 = l2.Next
	}

	carry = sum / 10
	result.Val = sum % 10
	//fmt.Printf("addTwoNumber2: %v %v\n", result.Val, carry)

	// Calculate the next node
	if l1 != nil || l2 != nil {
		result.Next = addTwoNumbers(l1, l2)
	} else if carry > 0 {
		result.Next = &ListNode{Val: carry}
		carry = 0
	}

	return result
}

func addTwoNumbersOptimize(l1 *ListNode, l2 *ListNode) *ListNode {
	carry := 0
	head := &ListNode{Val: 0, Next: nil}
	current := head
	for l1 != nil || l2 != nil || carry != 0 {
		if l1 != nil {
			carry += l1.Val
			l1 = l1.Next
		}
		if l2 != nil {
			carry += l2.Val
			l2 = l2.Next
		}
		current.Next = &ListNode{
			Val:  carry % 10,
			Next: nil,
		}
		current = current.Next
		carry /= 10
	}

	return head.Next
}

func arrayToListNode(array []string) *ListNode {
	if len(array) == 0 {
		return nil
	}

	listNode := &ListNode{}
	listNode.Val, _ = strconv.Atoi(array[0])
	listNode.Next = arrayToListNode(array[1:])
	return listNode
}

func display(l *ListNode) {
	if l == nil {
		return
	}
	fmt.Printf("%v", l.Val)
	if l.Next != nil {
		fmt.Printf("->")
	}
	display(l.Next)
}

func main() {
	//l1 := arrayToListNode([]string{"2", "4", "3"})
	//l2 := arrayToListNode([]string{"5", "6", "4"})
	//display(l1)
	//fmt.Println()
	//display(l2)
	//fmt.Println()
	//l3 := addTwoNumbers(l1, l2)
	//fmt.Println()
	//display(l3)
	//fmt.Println("----")

	// l4 := arrayToListNode([]string{"1", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "1"})
	// l5 := addTwoNumbers(l4, l2)
	// display(l5)
	// fmt.Println("----")

	l6 := arrayToListNode([]string{"9", "9", "9", "9", "9"})
	l7 := arrayToListNode([]string{"9", "9"})
	l8 := addTwoNumbersOptimize(l6, l7)
	display(l8)
	fmt.Println("----")

	l9 := arrayToListNode([]string{"0"})
	l10 := arrayToListNode([]string{"1"})
	l11 := addTwoNumbersOptimize(l9, l10)
	display(l11)
}
