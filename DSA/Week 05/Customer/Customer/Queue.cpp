#include "Queue.h"

Queue::Queue() {};
Queue::~Queue() {};

bool Queue::enqueue(ItemType item) {
	Node* tmp = new Node;
	tmp->item = item;
	tmp->next = NULL;

	if (isEmpty()) {
		frontNode = tmp;
		backNode = tmp;
		return true;
	}
	else
	{
		backNode->next = tmp;
		backNode = tmp;
		return true;
	}
	return false;
}

bool Queue::dequeue() {
	if (!isEmpty()) {
		frontNode = frontNode->next;
		return true;
	}
	return false;
}

bool Queue::dequeue(ItemType& item) {
	if (!isEmpty()) {
		getFront(item);
		frontNode = frontNode->next;
		return true;
	}
	return false;
}

void Queue::getFront(ItemType& item) {
	item = frontNode->item;
}

bool Queue::isEmpty() {
	if (frontNode == NULL) {
		return true;
	}
	return false;
}

void Queue::displayItems() {
}