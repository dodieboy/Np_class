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