#include <iostream>
#include <string>
#include "Stack.h"
int main()
{
    Stack back_stack;
    string temp;
    ItemType x;
    while (temp != "0")
    {
        cout << "[1] Visit URL\n[2] Back\n[0] Exit\nYour Choice: ";
        cin >> temp;
        if (temp == "0")
            break;
        else if (temp == "1"){
            cout << "Enter url link: ";
            cin >> x;
            back_stack.push(x);
        }
        else if (temp == "2") {
            back_stack.pop();
            back_stack.getTop(x);
            cout << "Going back to " << x << endl;
        }
    }
    return 0;
}
