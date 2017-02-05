#include <math.h>
#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#include <assert.h>
#include <limits.h>
#include <stdbool.h>

int main(){

    int size = 6;
    int op=4;

    int arr[6][6];
    for(int arr_i = 0; arr_i < 6; arr_i++){
       for(int arr_j = 0; arr_j < 6; arr_j++){
          
          scanf("%d",&arr[arr_i][arr_j]);
       }
    }

    /*
    int arr[6][6] = {
        {1, 1, 1, 0, 0, 0},
        {0, 1, 0, 0, 0, 0},
        {1, 1, 1, 0, 0, 0},
        {0, 0, 2, 4, 4, 0},
        {0, 0, 0, 2, 0, 0},
        {0, 0, 1, 2, 4, 0},
    };

    int arr[6][6] = {
        {-1, -1, 0, -9, -2, -2},
        {-2, -1, -6, -8, -2, -5},
        {-1, -1, -1, -2, -3, -4},
        {-1, -9, -2, -4, -4, -5},
        {-7, -3, -3, -2, -9, -9},
        {-1, -3, -1, -2, -4, -5}
    };

    printf("\n\n");
    
    for(int i=0; i<size; i++) {
        for(int j=0; j<size; j++) {
            printf("%d  ", arr[i][j]);
        }
        printf("\n");
    }

    printf("\n\n");
    */

    int first = 1;
    int max=0;
    int curr=0;
    for(int i=0; i<op; i++) {
        
        for(int j=0; j<op; j++) {
            curr += arr[i][j] + arr[i][j+1] + arr[i][j+2];
            curr += arr[i+1][j+1];
            curr += arr[i+2][j] + arr[i+2][j+1] + arr[i+2][j+2];

            if(first || curr > max) {
                max = curr;
                first = 0;
            }

            curr=0;
        }
    }

    printf("%d", max);

    return 0;
}
