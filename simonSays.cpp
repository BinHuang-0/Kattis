#include <iostream>

using namespace std;

int main(int argc, char *argv[]) {
    int lines;
    string command;
    string b;

    cin >> lines;
    getline(cin, command);

    for(int i = 0 ; i < lines; i++) {
        getline(cin, command);
        b = command.substr(0, 11);
        if(b.compare("Simon says ") == 0) {
            cout << command.substr(11) << endl;
        }
    }

    return 0;
}