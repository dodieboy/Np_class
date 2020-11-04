#include "List.h"

using namespace std;

List::List(){}
List::~List(){}

bool List::add(ItemType item) {
    //Node *news = new Node;
    //news->item = item;
    //news->next = NULL;

    //if (size == 0)
    //{
    //    firstNode = news;
    //}
    //else
    //{
    //    Node *last = firstNode;
    //    while (last->next != NULL) {
    //        last = last->next;
    //    }
    //    last->next = news;
    //}
    //size++;
    //return true;
    return add(size, item);
}

bool List::add(int index, ItemType item) {
    if (index > size || index < 0) {
        return false;
    }
    else {
        Node *news = new Node;
        news->item = item;
        news->next = NULL;
        if (index == 0 && size == 0)
        {
            news->next = firstNode;
            firstNode = news;
        }
        else
        {
            Node *tmp = firstNode;
            for(int i = 0; i < index-1; i++) {
                    tmp = tmp->next;
            }
            news->next = tmp->next;
            tmp->next = news;
        }
        size++;
        return true;
    }
}

void List::remove(int index) {
    if (index < size && index >= 0) {
        Node* tmp = firstNode;
        if (index == 0) {
            firstNode = tmp->next;
        }
        else {
            for (int i = 0; i < index - 1; i++) {
                tmp = tmp->next;
            }
            tmp->next = tmp->next->next;
        }
        size--;
    }
}

void List::print() {
    Node *tmp = firstNode;
    cout << "==========================" << endl;
    for (int i = 0; i < size; i++) {
        cout << tmp->item << endl;
        tmp = tmp->next;
    }
    cout << "==========================" << endl;
}