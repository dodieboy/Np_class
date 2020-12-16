#include<string>
#include<iostream>
using namespace std;

static int comparisons = 0;

int search(int dataArray[], int arraySize, int target) {
	for (int i = 0; i < arraySize; i++) {
		comparisons++;
		if (dataArray[i] == target)
			return i;
	}
	comparisons++;
	return -1;
}

int binarySearch(int dataArray[], int arraySize, int target) {
	int first = 0;
	int last = arraySize - 1;
	while (first <= last)
	{
		comparisons++;
		int mid = (first + last) / 2;
		if (dataArray[mid] == target)
			return mid;
		else {
			if (dataArray[mid] > target)
				last = mid - 1;
			else
				first = mid + 1;
		}
		
	}
	return -1;
}

int search(int dataArray[], int arraySize, int start, int target) {
	comparisons++;
	if (dataArray[start] == target)
		return start;
	else if (arraySize == start)
		return -1;
	else
		search(dataArray, arraySize, start + 1, target);
}

int binarySearch(int dataArray[], int first, int last, int target) {
	if (first <= last)
	{
		comparisons++;
		int mid = (first + last) / 2;
		if (dataArray[mid] == target)
			return mid;
		else {
			if (dataArray[mid] > target)
				binarySearch(dataArray, first, mid - 1, target);
			else
				binarySearch(dataArray, mid + 1, last, target);
		}
	}
	else
		return -1;
}

int main() {
	int dataArray[1000];
	for (int i = 1; i < 1001; i++)
		dataArray[i - 1] = i * 2;
	int input;
	while (true) //got lazy to re-run the programe everytime for Q7
	{
		cout << "Enter search value: ";
		cin >> input;
		//sequential search (sorted)
		comparisons = 0;
		cout << "Sequential Search: ";
		if (search(dataArray, 1000, input) != -1)
			cout << "Found";
		else
			cout << "Not found";
		cout << " - No. of comparisons: " << comparisons << endl;

		//binary search (sorted)
		comparisons = 0;
		cout << "Binary Search: ";
		if (binarySearch(dataArray, 1000, input) != -1)
			cout << "Found";
		else
			cout << "Not found";
		cout << " - No. of comparisons: " << comparisons << endl;

		//Recursive sequential search (sorted)
		comparisons = 0;
		cout << "Recursive sequential Search: ";
		if (search(dataArray, 1000, 0, input) != -1)
			cout << "Found";
		else
			cout << "Not found";
		cout << " - No. of comparisons: " << comparisons << endl;

		//Recursive binary search (sorted)
		comparisons = 0;
		cout << "Recursive binary Search: ";
		if (binarySearch(dataArray, 0, 999, input) != -1)
			cout << "Found";
		else
			cout << "Not found";
		cout << " - No. of comparisons: " << comparisons << endl;

		cout << "========================================================================" << endl;
	}
}