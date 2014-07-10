def calculate(input):
    index = 0
    while True:
        index += input
        for number2 in range(1, input + 1):
            if index % number2 != 0:
                break
            elif number2 == input:
                return index

print "result: " + str(calculate(20))