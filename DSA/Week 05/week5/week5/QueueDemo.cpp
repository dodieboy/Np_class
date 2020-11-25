#include "Stack.h"
#include "Queue.h"

//bool isPalindrome(string input) {
//	int length = input.length();
//	for (int i = 0; i <= length / 2; i++) {
//		if (input[i] != input[length -1 - i]) {
//			return false;
//		}
//	}
//	return true;
//}

bool isPalindrome(string input) {
	int length = input.length();
	Stack a;
	Queue b;
	char x;
	char y;
	int tmp = 0;
	for (int i = 0; i < length; i++) {
		char currentChar = input[i];
		a.push(currentChar);
		b.enqueue(currentChar);
	}

	while (true)
	{
		if (tmp == length/2) {
			return true;
		}
		a.pop(x);
		b.dequeue(y);
		if (x != y) {
			return false;
		}
		tmp++;
	}
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

	q.dequeue();
	q.dequeue();
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

