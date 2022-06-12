package main

import "fmt"

func enqueue(this *[]string, item string) {
	*this = append(*this, item)
}

func dequeue(this *[]string) string {
	item := (*this)[0]
	*this = (*this)[1:]
	return item
}

func main() {
	queue := []string{}
	enqueue(&queue, "a")
	enqueue(&queue, "b")
	enqueue(&queue, "c")
	fmt.Println(dequeue(&queue))
	fmt.Println(dequeue(&queue))
	fmt.Printf("%v\n", len(queue))
	enqueue(&queue, "d")
	enqueue(&queue, "e")
	fmt.Println(dequeue(&queue))
	fmt.Printf("%v\n", len(queue))

	// Output:
	// a
	// b
	// 1
	// c
	// 2
}
