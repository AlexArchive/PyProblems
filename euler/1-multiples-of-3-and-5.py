sum = 0;
for number in range(1, 1000):
    if not (number % 3):
        sum += number
    elif not (number % 5):
        sum += number
print sum
