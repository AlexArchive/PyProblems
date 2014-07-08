def isprime(input):
    if input <= 1: return False;
    for number in range(2, input):
        if (input % number == 0):
            return False
    return True;

def printprimefactorsof(input):
    for number in range(0, 2000000):
        if not (isprime(number)): continue
        something = (input % number == 0)
        if something:
            print str(number)
            result = input / number
            printprimefactorsof(result)
            break
    print highestPrime
        
printprimefactorsof(600851475143)
