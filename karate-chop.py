#http://codekata.com/kata/kata02-karate-chop/

def chop (int, array_of_int):
    count = 0;
    while count < len(array_of_int):
        if (array_of_int[count] == int):
            return count;
        count = count + 1
    return -1

print chop(5, [1, 3, 5]) #expected: 2
print chop(3, [1, 3, 5]) #expected: 1
print chop(3, []); #expected: -1

