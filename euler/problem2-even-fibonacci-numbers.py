sequence = [0, 1]
sum = 0

while True:
    result = sequence[0] + sequence[1]
    if result > 4000000:
        break
    if (result % 2 == 0):
        sum += result;
    sequence[0] = sequence[1]
    sequence[1] = result
print sum
