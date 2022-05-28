package uniqueMorse

import "fmt"

func uniqueMorseRepresentations(words []string) int {
	morse_array := []string{".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.."}
	alphabet := "abcdefghijklmnopqrstuvwxyz"

	morseCode := make(map[string]string)
	for i, v := range morse_array {
		morseCode[string(alphabet[i])] = v
	}

	uniqueWords := make(map[string]bool)

	for _, word := range words {
		var morseWord string
		for _, letter := range word {
			morseWord += morseCode[string(letter)]
		}
		//fmt.Println(morseWord)
		uniqueWords[morseWord] = true
	}

	return len(uniqueWords)
}

func uniqueMorseRepresentations2(words []string) int {
	morse := []string{".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.."}
	m := make(map[string]struct{})
	for _, word := range words {
		var code string
		for _, c := range word {
			code += morse[c-'a']
		}
		m[code] = struct{}{}
	}
	return len(m)
}

func main() {
	words := []string{"gin", "zen", "gig", "msg"}
	fmt.Println(uniqueMorseRepresentations(words))
	fmt.Println(uniqueMorseRepresentations2(words))
}
