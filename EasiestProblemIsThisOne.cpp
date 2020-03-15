#include <iostream>

using namespace std;

int main(int argc, char *argv[]) {
    int N;
    int n;
    int digRoot = 0;
    int p;
    int pRoot = 0;

    cin >> N;
    while(N != 0) {
        n = N;
        digRoot = 0;
        while(n > 0) {
            digRoot += n % 10;
            n = n / 10;
        }

        for(int i = 11; i <= 100000 && pRoot != digRoot; i++) {
            p = i * N;
            pRoot = 0;

            while(p > 0) {
                pRoot += p % 10;
                p = p / 10;
            }
            if(pRoot == digRoot)
                cout << i << endl;
        }


        cin >> N;
    }

    return 0;
}