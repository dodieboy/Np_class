#include "Stack.h"

Stack::Stack() {}
Stack::~Stack() {}

bool Stack::isEmpty() {
	if (topNode == NULL) {
		return true;
	}
	return false;
}

bool Stack::push(ItemType item) {
	Node* tmp = new Node;
	tmp->item = item;
	tmp->next = topNode;
	topNode = tmp;
	return true;
}

bool Stack::pop() { 
	if (!isEmpty()) {
		Node* tmp = new Node;
		tmp = topNode->next;
		topNode = tmp;
		return true;
	}
	return false; 
}
bool Stack::pop(ItemType& item) {
	if (!isEmpty()) {
		item = topNode->item;
		Node* tmp = new Node;
		tmp = topNode->next;
		topNode = tmp;
		return true;
	}
	return false;
}
void Stack::getTop(ItemType& item) {
	if (!isEmpty()) {
		item = topNode->item;
	}
}
void Stack::displayInOrder() {
	if (!isEmpty()) {
		Node* tmp = topNode;
		while (tmp->next != NULL)
		{
			cout << tmp->item << endl;
			tmp = tmp->next;
		}
		cout << tmp->item << endl;
		delete tmp;
	}
	else {
		cout << "Stack is empty!" << endl;
	}
}
void Stack::displayInOrderOfInsertion() {
	if (!isEmpty()) {
		Stack newStack;
		Node* oldNode = topNode;
		while (oldNode != NULL)
		{
			newStack.push(oldNode->item);
			oldNode = oldNode->next;
		}
		newStack.displayInOrder();
		delete oldNode;
	}
	else {
		cout << "Stack is empty!" << endl;
	}
}