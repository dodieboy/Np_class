#include "Stack.h"

int demo() {
	Stack s;
	s.push("3");
	s.push("4");

	ItemType top;
	s.getTop(top);
	cout << top << " is at the top" << endl;

	s.displayInOrderOfInsertion();
	s.pop();
	s.displayInOrderOfInsertion();
	return 0;
}