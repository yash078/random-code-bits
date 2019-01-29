def isSelfDescriptive(number):
    numberAsList = [int(x) for x in list(str(number))]
    numberLength = len(numberAsList)
    if max(numberAsList) > numberLength or sum(numberAsList) != numberLength:
        return False
    return all(numberAsList.count(i) == ch for i, ch in enumerate(numberAsList))

for i in range(1000, 3300000):
    if isSelfDescriptive(i):
        print(i)
