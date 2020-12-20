// PQueue.h - Specification of PQueue ADT (Pointer-based)
#pragma once
#include <iostream>   		
using namespace std;  	

typedef string ItemType;
typedef int PriorityType;
struct Node
{
	ItemType item;		// to store data
	PriorityType priority; // to store the priority
	Node* next;		   // to point to next node
};

class PQueue
{
  private:
	Node* frontNode;		// to point to the front node

  public:
	PQueue();
	~PQueue();

	// enqueue item at back of the queue
	bool enqueue(ItemType item, PriorityType p);

	// check if the queue is empty
	bool isEmpty();

	// display the items in the queue
	void print();
};

