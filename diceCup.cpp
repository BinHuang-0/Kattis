#include <iostream>

using namespace std;

int main(int argc, char *argv[]) {
    int tally[41];
    int d1, d2;
    int mostLikely = 0;

    cin >> d1;
    cin >> d2;

    //set array to 0
    for(int i = 1; i <= d1; i++) {
        for(int k = 1; k <= d2; k++) {
            tally[i+k] = 0;
        }
    }

    //populate table
    for(int i = 1; i <= d1; i++) {
        for(int k = 1; k <= d2; k++) {
            tally[i+k]++;
        }
    }

    //count how many times a number appears
    for(int i = 2; i <= d1 + d2; i++) {
        if(tally[i] > mostLikely)
            mostLikely = tally[i];
    }

    for(int i = 2; i <= d1 + d2; i++) {
        if(tally[i] == mostLikely)
            cout << i << endl;
    }

    return 0;
}