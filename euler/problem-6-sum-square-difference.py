def calculate(naturalNumberCount):
    sumOfSquares = 0
    for number in range(1,naturalNumberCount + 1):
        sumOfSquares += number * number
        
    sum = 0
    for number in range(1, naturalNumberCount + 1):
        sum += number 
    sum = sum * sum

    print sum - sumOfSquares

calculate(100)
