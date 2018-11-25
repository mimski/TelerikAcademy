# Three Numbers
You are given 3 integer number A, B and C. Find:
* The biggest number among them
* The smallest number among them
* The arithmetic mean of the three numbers

The arithmetic mean is the sum of a collection of numbers divided by the number of numbers in the collection. The result should be rounded with 2 digits after the decimal point.

### Input
The input data should be read from the console.
The number A will be given on the first console line.
The number B will be given on the second console line.
The number C will be given on the third console line.
The input data will always be valid and in the format described. There is no need to check it explicitly.

### Output
The output data should be printed on the console.
On the first output line print the biggest number among A, B and C.
On the second output line print the smallest number among A, B and C.
On the third output line print the arithmetic mean of the number A, B and C with precision 2 digits after the decimal point (Hint: use the formatting string {0:F2} for outputting the answer)

### Constraints
* A, B and C will be integer numbers between -200 000 000 and 200 000 000, inclusive.
* Allowed working time for your program: 0.1 seconds. Allowed memory: 16 MB.

### Examples
#### Example input
```
1
2
3
```
#### Example output
```
3
1
2.00	
```
___
#### Example input
```
-2
-2
2
```
#### Example output
```
2
-2
-0.67
```	
Here the exact arithmetic mean is -0.6666666666…  but when rounded to the second digit after the decimal point we come up with -0.67
