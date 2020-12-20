// PQueue.cpp - Implementation of PQueue ADT (Pointer-based)
#include "PQueue.h"

PQueue::PQueue()
{
	frontNode = NULL;
}

PQueue::~PQueue() { }

bool PQueue::enqueue(ItemType item, PriorityType p)
{
	Node* tmp = new Node;
	tmp->item = item;
	tmp->priority = p;
	tmp->next = NULL;
	if (frontNode == NULL) {
		frontNode = tmp;
	}
	else {
		Node* loopNode = frontNode;
		while (true)
		{
			if (loopNode->priority < p) {
				tmp->next = loopNode;
				loopNode = tmp;
				return true;
			}
			else if (loopNode->next == NULL) {
				loopNode->next = tmp;
				return true;
			}
			else {
				loopNode = loopNode->next;
			}
		}
	}
	return true;
}

bool PQueue::isEmpty() { return frontNode == NULL; }

void PQueue::print()
{
	Node* temp = frontNode;
	while (temp != NULL)
	{
		cout << "Item: " << temp->item << " Priority : " << temp->priority << endl;
		temp = temp->next;
	}
		
}

