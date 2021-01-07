// AVL_Tree.h - AVL functions(Specification)
#pragma once
#include<iostream>
using namespace std;

#include "BinaryNode.h"

void balanceTree(BinaryNode*& t);

// AVL Tree functions
BinaryNode* balance(BinaryNode* t);
BinaryNode* rotateLeft(BinaryNode* node);
BinaryNode* rotateRight(BinaryNode* node);
BinaryNode* rotateLeftRight(BinaryNode* node);
BinaryNode* rotateRightLeft(BinaryNode* node);
int diff(BinaryNode* t);
int getHeight(BinaryNode* t);