package myHashSet

import "fmt"

type MyHashSet struct {
	set map[int]int
}

func Constructor() MyHashSet {
	hashSet := MyHashSet{
		set: make(map[int]int),
	}
	return hashSet
}

func (this *MyHashSet) Add(key int) {
	this.set[key] = 1
}

func (this *MyHashSet) Remove(key int) {
	delete(this.set, key)
}

func (this *MyHashSet) Contains(key int) bool {
	_, ok := this.set[key]
	return ok
}

func main() {
	/*
			["MyHashSet","add","add","contains","contains","add","contains","remove","contains"]
		  [[],[1],[2],[1],[3],[2],[2],[2],[2]]
	*/

	/**
	 * Your MyHashSet object will be instantiated and called as such:
	 * obj := Constructor();
	 * obj.Add(key);
	 * obj.Remove(key);
	 * param_3 := obj.Contains(key);
	 */

	test := Constructor()
	test.Add(1)
	fmt.Printf("%v", test.set)
	test.Add(2)
	test.Contains(1)
	test.Contains(3)
}
