// Stack.h (Pointer-based implementation)
#pragma once
#include <iostream>
using namespace std;

typedef int ItemType;

class Stack
{
private:
	struct Node
	{
		ItemType item;
		Node* next;
	};

	Node* topNode{ NULL };

public:
	//Default constructor
	Stack();
	//Destructor
	~Stack();

	//check if the stack is empty
	bool isEmpty();

	//push item on top of the stack
	bool push(ItemType item);

	//pop item from top of stack
	bool pop();

	//retrieve and pop item from top of stack
	bool pop(ItemType& item);

	//retrieve item from top of stack
	void getTop(ItemType& item);

	//display items in stack in order
	void displayInOrder();

	//display items in stack in order of insertion
	void displayInOrderOfInsertion();
};
