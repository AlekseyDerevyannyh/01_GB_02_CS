// составить все слова заданной длины, используя заданный набор символов
using System;
using static System.Console;

Clear();

Words ("аисв", new char[2]);

void Words (string alphabet, char[] word, int length = 0) {
	if (length == word.Length) {
		WriteLine($"{new String(word)}");
		return;
	}
	for (int i = 0; i < alphabet.Length; i ++) {
		word[length] = alphabet[i];
		Words(alphabet, word, length + 1);
	}
}