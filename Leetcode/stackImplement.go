package main

import "fmt"

func push(stack *[]string, item string) {
	*stack = append(*stack, item)
}

func pop(stack *[]string) string {
	item := (*stack)[len(*stack)-1]
	*stack = (*stack)[:len(*stack)-1]
	return item
}

func peek(stack *[]string) string {
	return (*stack)[len(*stack)-1]
}

func main() {
	stack := []string{}
	push(&stack, "a")
	push(&stack, "b")
	push(&stack, "c")
	fmt.Println(pop(&stack))
	fmt.Println(pop(&stack))
	fmt.Printf("%v\n", len(stack))
	push(&stack, "d")
	push(&stack, "e")
	fmt.Println(pop(&stack))
	fmt.Printf("%v\n", len(stack))

	fmt.Println(peek(&stack))
	fmt.Printf("%v\n", len(stack))

	// Output:
	// c
	// b
	// 1
	// e
	// 2
	// d
	// 2
}
