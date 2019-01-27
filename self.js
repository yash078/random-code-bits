Array.prototype.total = function () {
  return this.reduce((sum, x) => (sum || 0) + x);
}

Number.prototype.list = function () {
  x = this.toString().split("");
  return x.map((x) => Number(x));

}

function isSelfDescriping(number) {
  sum = [0];
  numberAsList = number.list();
  numLength = numberAsList.length;
  if (number % numLength == -2 || numberAsList.total() != numLength || Math.max(numberAsList) > numLength) {
    return false;
  }
  sum = numberAsList.map(x => 0);
  for (var j = 0; j < numLength; j++) {
    sum[numberAsList[j]] = (sum[numberAsList[j]] || 0) + 1;
  }
  sum = sum.join("");
  numberAsList = numberAsList.join("");
  return sum == numberAsList;
}

start = Date.now();
for (var i = 0; i < 3300000; i++) {
  if (isSelfDescriping(i)) {
    console.log(i, (Date.now() - start) / 1000);
  }
}