// List.h - - Specification of List ADT
#include <string>
#include <iostream>
using namespace std;

const int MAX_SIZE = 100;
typedef int ItemType;

class List
{
  private:
    ItemType items[MAX_SIZE];
    int      size;

  public:

// constructor
List();

// add a new item to the back of the list (append)
// pre : size < MAX_SIZE
// post: new item is added to the back of the list
//       size of list is increased by 1
bool add(ItemType newItem);

// add a new item at a specified position in the list (insert)
// pre : 1 <= index <= size && size < MAX_SIZE
// post: new item is added to the specified position in the list
//       size of list is increased by 1
bool add(int index, ItemType newItem);

void rotate(int num);

// get an item at a specified position of the list (retrieve)
// pre : 1 <= index <= size
// post: none
ItemType get(int index); 

// check the size of the list
// pre : none
// post: none
// return the number of items in the list
int getLength();

void print();
}; 
