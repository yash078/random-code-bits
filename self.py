def isSelfDescriptive(number):
    numberAsStr = str(number)
    numberAsStr = list(str(number))
    numberAsList = [int(x) for x in numberAsStr]
    numberLength = len(numberAsStr)
    if int(max(numberAsStr)) > numberLength or sum(numberAsList) != numberLength:
        return False
#     Sum = [0] * (numberLength)
#     for i in range(numberLength):
#         Sum[i] = numberAsStr.count(str(i))
#     # print(number, sum)
    # return int(''.join([str(x) for x in Sum])) == number
    return all(numberAsStr.count(str(i)) == int(ch) for i, ch in enumerate(numberAsStr))


# def isSelfDescriptive(n):
#     s = str(n)
#     return all(s.count(str(i)) == int(ch) for i, ch in enumerate(s))


for i in range(1000, 3300000):
    if isSelfDescriptive(i):
        print(i)
