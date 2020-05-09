# SumOfFactorialDigits
Calculate all digits of given factorial

## How it works

The main idea behind the algorithm it's to calculate using the last digit. We  will  incress the list with all digits of factorial. This is list starts with 1, because it's the starting point. When we end on iteration on all digits and we still have a rest, we need to add to list.

First, we iterate over all numbers between 1 and the expected factorial number.  

Look at the code:

```c
int rest = 0;
for(int i = 0; i < currentDigitSize; ++i)
{
    int result = rest + digits[i] * iCurrentFactorial;

    digits[i] = result % 10;
    rest = result / 10;
}

```

We update every digit on list with the rest mod of 10 and saving the left number.

Imagine the loop with `iCurrentFactorial` being `5`. The `digits.Count` will be `1` and `digits[0]` = `6`.   
`Result` will be `24`.   
The `digits[0]` will be replaced with mod of ten: 4   
The `rest` with 2.   

We have a `rest` different from 0 so, at this point, we add to the list. On next iteration (if exists), we calculate over all the digits again.
