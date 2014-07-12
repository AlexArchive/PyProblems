def isprime(input):
    if input <= 1: return False;
    for number in range(2, input):
        if (input % number == 0):
            return False
    return True;

count = 0
iterations = 0
while count != 10001:
    iterations += 1
    if isprime(iterations): count += 1
print iterations
