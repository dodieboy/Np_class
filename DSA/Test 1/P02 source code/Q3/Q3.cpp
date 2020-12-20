#include <iostream>
#include <string>
using namespace std;
int counter(int number, int count) {
	int a = number / pow(10,count);
	if (a != 0) {
		return counter(number, count+1);
	}
	else {
		return count;
	}
}
int count_digit(int number) {
	return counter(number, 1);
}
bool checkPalindrome(string newNum, int length, int i) {
	if (length == i) {
		return true;
	}
	else if (newNum[i] != newNum[length - 1 - i]) {
		return false;
	}
	else {
		checkPalindrome(newNum, length, i+1);
	}
}
bool isPalindrome(int num) {
		int length = count_digit(num);
		string newNum = to_string(num);
		return checkPalindrome(newNum, length, 0);

}

int main()
{
	int n;
	cout << "Enter a number: ";
	cin >> n;
	if (isPalindrome(n))
		cout << "Yes, " << n << " is a palindrome\n";
	else
		cout << "No, " << n << " is not a palindrome\n";
	return 0;
}


