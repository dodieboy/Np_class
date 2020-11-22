#include "Stack.h"
#include "Queue.h"

bool isPalindrome(string input) {
	int length = input.length();
	for (int i = 0; i <= length / 2; i++) {
		if (input[i] != input[length -1 - i]) {
			return false;
		}
	}
	return true;
}

int main() {
	Queue q;
	q.enqueue('a');
	q.enqueue('b');
	q.enqueue('c');
	char print;
	q.getFront(print);
	cout << print << endl;
	q.displayItems();
	q.dequeue();
	q.displayItems();

	string input;
	cout << "Please enter a palindrome: ";
	cin >> input;
	if (isPalindrome(input)) {
		cout << "It is a palindrome!!!" << endl;
	}
	else {
		cout << "It is not a palindrome!!!" << endl;
	}
}

