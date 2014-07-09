def ispalindrome(input):
    return str(input) == str(input)[::-1]

largestPalindrome = 0
for number in range(100, 1000):
    for number2 in range(100, 1000):
        result = number * number2;
        if ispalindrome(result):
            if (result > largestPalindrome):
                largestPalindrome = result;
                
print "largest palindrome:  " + str(largestPalindrome)