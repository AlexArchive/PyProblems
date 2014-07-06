for count in range(0, 101):
    if not(count % 5) and not(count % 3):
        print "FizzBuzz"
    elif not(count % 3):
        print "Fizz"
    elif not(count % 5):
        print "Buzz"
    else:
        print count
