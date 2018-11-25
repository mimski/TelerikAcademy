# Text to Number
You are given a text and a number (M). This text can contain **digits, Latin letters (both capital and letter case) and any other symbols, except for '@'**. The number is used to the parsing of the text.
Your task is to go through all characters of the text and, starting from RESULT = 0, to perform the following operations:
* If the current character is '@', stop the program and print the RESULT
* If the current character is a digit (0-9), then multiply the RESULT by this digit
* If the current character is a letter, add its number from the Latin alphabet to RESULT. 'A' is with number 0
* If the current character is a symbol, that is different from the ones above, create module of the RESULT by the provided number (M)
### Input
The input data is given at the standard input. 
It consists of two lines:
* The first one contains the number M, that is used for the module of the result
* The second line contains the text

The input will be valid, in the specified format, within the constraints given below. There is no need to check the input data explicitly.
### Output
Print the result from the parsing (RESULT)
Constraints
* M will always be between 2000 and 10 000
* The length of the text will always be less than 100 000
* Allowed working time for your program: 0.5 seconds.
* Allowed memory: 16 MB.
## Example
### Input

```
2001
Hello .NET 5! My name is Peter 8-)@
```
### Output
```
518
```
### Description
```
RESULT = 0 + 7(H) = 7
RESULT = 7 + 4(e) = 11
RESULT = 11 + 11(l) = 22
RESULT = 22 + 11(l) = 33
RESULT = 33 + 14(o) = 47
RESULT = 47 % 2001( ) = 47
RESULT = 47 % 2001(.) = 47
RESULT = 47 + 13(N) = 60
RESULT = 60 + 4(E) = 64
RESULT = 64 + 19(T) = 83
RESULT = 83 % 2001( ) = 83
RESULT = 83 * 5(5) = 415
RESULT = 415 % 2001(!) = 415
RESULT = 415 % 2001( ) = 415
RESULT = 415 + 12(M) = 427
RESULT = 427 + 24(y) = 451
RESULT = 451 % 2001( ) = 451
RESULT = 451 + 13(n) = 464
RESULT = 464 + 0(a) = 464
RESULT = 464 + 12(m) = 476
RESULT = 476 + 4(e) = 480
RESULT = 480 % 2001( ) = 480
RESULT = 480 + 8(i) = 488
RESULT = 488 + 18(s) = 506
RESULT = 506 % 2001( ) = 506
RESULT = 506 + 15(P) = 521
RESULT = 521 + 4(e) = 525
RESULT = 525 + 19(t) = 544
RESULT = 544 + 4(e) = 548
RESULT = 548 + 17(r) = 565
RESULT = 565 % 2001( ) = 565
RESULT = 565 * 8(8) = 4520
RESULT = 4520 % 2001(-) = 518
RESULT = 518 % 2001()) = 518
```

___

### Input
```
2222
Starwars 4, 5 and 6 are better that 1, 2 and 3@
```
### Output
```
1332
```	
### Description
```
RESULT = 0 + 18(S) = 18
RESULT = 18 + 19(t) = 37
RESULT = 37 + 0(a) = 37
RESULT = 37 + 17(r) = 54
RESULT = 54 + 22(w) = 76
RESULT = 76 + 0(a) = 76
RESULT = 76 + 17(r) = 93
RESULT = 93 + 18(s) = 111
RESULT = 111 % 2222( ) = 111
RESULT = 111 * 4(4) = 444
RESULT = 444 % 2222(,) = 444
RESULT = 444 % 2222( ) = 444
RESULT = 444 * 5(5) = 2220
RESULT = 2220 % 2222( ) = 2220
RESULT = 2220 + 0(a) = 2220
RESULT = 2220 + 13(n) = 2233
RESULT = 2233 + 3(d) = 2236
RESULT = 2236 % 2222( ) = 14
RESULT = 14 * 6(6) = 84
RESULT = 84 % 2222( ) = 84
RESULT = 84 + 0(a) = 84
RESULT = 84 + 17(r) = 101
RESULT = 101 + 4(e) = 105
RESULT = 105 % 2222( ) = 105
RESULT = 105 + 1(b) = 106
RESULT = 106 + 4(e) = 110
RESULT = 110 + 19(t) = 129
RESULT = 129 + 19(t) = 148
RESULT = 148 + 4(e) = 152
RESULT = 152 + 17(r) = 169
RESULT = 169 % 2222( ) = 169
RESULT = 169 + 19(t) = 188
RESULT = 188 + 7(h) = 195
RESULT = 195 + 0(a) = 195
RESULT = 195 + 19(t) = 214
RESULT = 214 % 2222( ) = 214
RESULT = 214 * 1(1) = 214
RESULT = 214 % 2222(,) = 214
RESULT = 214 % 2222( ) = 214
RESULT = 214 * 2(2) = 428
RESULT = 428 % 2222( ) = 428
RESULT = 428 + 0(a) = 428
RESULT = 428 + 13(n) = 441
RESULT = 441 + 3(d) = 444
RESULT = 444 % 2222( ) = 444
RESULT = 444 * 3(3) = 1332
```

___

### Input
```
9999
My nickname, when I was 25, was Pencho8473848399 ;-)@
```
### Output
```
2943
```
### Description
```
RESULT = 0 + 12(M) = 12
RESULT = 12 + 24(y) = 36
RESULT = 36 % 9999( ) = 36
RESULT = 36 + 13(n) = 49
RESULT = 49 + 8(i) = 57
RESULT = 57 + 2(c) = 59
RESULT = 59 + 10(k) = 69
RESULT = 69 + 13(n) = 82
RESULT = 82 + 0(a) = 82
RESULT = 82 + 12(m) = 94
RESULT = 94 + 4(e) = 98
RESULT = 98 % 9999(,) = 98
RESULT = 98 % 9999( ) = 98
RESULT = 98 + 22(w) = 120
RESULT = 120 + 7(h) = 127
RESULT = 127 + 4(e) = 131
RESULT = 131 + 13(n) = 144
RESULT = 144 % 9999( ) = 144
RESULT = 144 + 8(I) = 152
RESULT = 152 % 9999( ) = 152
RESULT = 152 + 22(w) = 174
RESULT = 174 + 0(a) = 174
RESULT = 174 + 18(s) = 192
RESULT = 192 % 9999( ) = 192
RESULT = 192 * 2(2) = 384
RESULT = 384 * 5(5) = 1920
RESULT = 1920 % 9999(,) = 1920
RESULT = 1920 % 9999( ) = 1920
RESULT = 1920 + 22(w) = 1942
RESULT = 1942 + 0(a) = 1942
RESULT = 1942 + 18(s) = 1960
RESULT = 1960 % 9999( ) = 1960
RESULT = 1960 + 15(P) = 1975
RESULT = 1975 + 4(e) = 1979
RESULT = 1979 + 13(n) = 1992
RESULT = 1992 + 2(c) = 1994
RESULT = 1994 + 7(h) = 2001
RESULT = 2001 + 14(o) = 2015
RESULT = 2015 * 8(8) = 16120
RESULT = 16120 * 4(4) = 64480
RESULT = 64480 * 7(7) = 451360
RESULT = 451360 * 3(3) = 1354080
RESULT = 1354080 * 8(8) = 10832640
RESULT = 10832640 * 4(4) = 43330560
RESULT = 43330560 * 8(8) = 346644480
RESULT = 346644480 * 3(3) = 1039933440
RESULT = 1039933440 * 9(9) = 9359400960
RESULT = 9359400960 * 9(9) = 84234608640
RESULT = 84234608640 % 9999( ) = 2943
RESULT = 2943 % 9999(;) = 2943
RESULT = 2943 % 9999(-) = 2943
RESULT = 2943 % 9999()) = 2943
```
