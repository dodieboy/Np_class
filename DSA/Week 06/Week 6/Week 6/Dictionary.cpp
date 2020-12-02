#include "Dictionary.h"

Dictionary::Dictionary() {
	size = 0;
	Node* tmp = new Node();
	tmp->item = "";
	tmp->key = "";
	tmp->next = NULL;
	for (int i = 0; i < MAX_SIZE; i++) {
		items[i] = tmp;
	}
};
Dictionary::~Dictionary() {};

int charvalue(char c) {
	if (!isdigit(c)) {
		if (isupper(c)) {
			return (int)c - (int)'A';
		}
		else
		{
			return (int)c - (int)'a' + 26;
		}
	}
	return -1;
}

int Dictionary::hash(KeyType key) {
	int t = charvalue(key[0]);
	for (int i = 1; unsigned(i) < key.size(); i++) {
		if (charvalue(key[i]) < 0) {
			continue;
		}
		t = t * 52 + charvalue(key[i]);
		t %= MAX_SIZE;
	}
	return t;
}

bool Dictionary::add(KeyType Key, ItemType newItem) {
	int index = hash(Key);
	if (!(index > MAX_SIZE)) {
		Node* tmp = new Node();
		tmp->item = newItem;
		tmp->key = Key;
		tmp->next = NULL;
		if (items[index]->item == "")
			items[index] = tmp;
		else
		{
			Node* tmp2 = items[index];
			bool loop = true;
			while (loop)
			{
				if (tmp2->next == NULL)
					loop = false;
				else
					tmp2 = tmp2->next;
			}
			tmp2->next = tmp;
		}
		size++;
		return true;
	}
	return false;
}

void Dictionary::remove(KeyType key) {
	if (!isEmpty()) {
		int index = hash(key);
		Node* tmp = items[index];
		Node* tmp1 = items[index];
		bool loop = true;
		if (tmp1->key == key) {
			Node* tmp2 = tmp1;
			items[index] = tmp1->next;
			delete tmp2;
			size--;
			cout << "Item removed" << endl;
			return;
		}
		tmp1 = tmp->next;
		while (loop)
		{
			if (tmp1->key == key) {
				Node* tmp2 = tmp1;
				tmp->next = tmp1->next;
				delete tmp2;
				size--;
				cout << "Item removed" << endl;
				break;
			}
			else if (tmp1->next == NULL) {
				break;
			}
			else {
				tmp = tmp->next;
				tmp1 = tmp1->next;
			}
		}
	}
	else
		cout << "Item not remove (Item not found)" <<endl;
}

ItemType Dictionary::get(KeyType key) {
	int index = hash(key);
	Node* tmp = items[index];
	while (true)
	{
		if (tmp->key == key) {
			return tmp->item;
		}
		else if (tmp->next == NULL) {
			return "";
		}
		else 
			tmp = tmp->next;
		
	}
}

bool Dictionary::isEmpty() {
	if (size == 0)
		return true;
	return false;
}

int Dictionary::getLength() {
	return size;
}

void Dictionary::print() {
	for (int i = 0; i < MAX_SIZE; i++) {
		Node* tmp = items[i];
		while (true)
		{
			if (tmp->item != "") {
				cout << tmp->key << " | " << tmp->item <<endl;
				if (tmp->next != NULL)
					tmp = tmp->next;
				else
					break;
			}
			else
				break;
		}
		
	}
}