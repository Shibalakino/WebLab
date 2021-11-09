function Main() {
  let length = parseInt(prompt("Enter array size: "));
  let numbers = [];
  AddToArrRandom(numbers, length);

  let sumEvenIndexes = FindSumEvenIndexes(numbers);

  let multNegatives = FindMultNegatives(numbers);
  let maxAndIndexInPositives = FindMaxAndIndexInPositives(numbers);
  let minAndIndexInOddIndexes = FindMinAndIndexInOddInxedes(numbers);

  let numbers2 = [...numbers];
  numbers2.sort();
  const dataDiv = document.createElement("div");
  dataDiv.innerHTML =
    "the array:" +
    numbers +
    "<br>" +
    "sum of members on even indexes = " +
    sumEvenIndexes +
    "<br>" +
    "multiplication of negative members = " +
    multNegatives +
    "<br>" +
    "max member and its index in positives = " +
    maxAndIndexInPositives[0] +
    "    " +
    maxAndIndexInPositives[1] +
    "<br>" +
    "min member ans its position on odd indexes = " +
    minAndIndexInOddIndexes[0] +
    "    " +
    minAndIndexInOddIndexes[1] +
    "<br>" +
    "the sorted array:" +
    numbers2;
  document.body.append(dataDiv);
}

function AddToArrRandom(array, length) {
  for (let index = 0; index < length; index++) {
    array.push(Math.ceil(Math.random() * 10 - 4));
  }
}

function FindSumEvenIndexes(array) {
  let sum = 0;
  if (array != null) {
    for (let i = 0; i < array.length; i += 2) {
      sum += array[i];
    }
  }
  return sum;
}

function FindMultNegatives(array) {
  let mult = 1;
  if (array != null) {
    for (let i = 0; i < array.length; i++) {
      if (array[i] < 0) {
        mult *= array[i];
      }
    }
  }
  if (mult == 1) {
    mult = 0;
  }
  return mult;
}

function FindMaxAndIndexInPositives(array) {
  let max = 0;
  let iMax = -1;
  if (array != null && array[0] != null) {
    max = array[0];
    for (let i = 0, iPos = -1; i < array.length; i++) {
      if (array[i] > 0) {
        iPos++;
      }
      if (array[i] > max) {
        max = array[i];
        if (max > 0) {
          iMax = iPos;
        }
      }
    }
  }
  if (iMax == -1) {
    iMax = "unable to evaluate";
  }
  return [max, iMax];
}

function FindMinAndIndexInOddInxedes(array) {
  let min = 0;
  let iMin = -1;
  if (array != null && array[0] != null) {
    max = array[0];
    for (let i = 0, iOdd = -1; i < array.length; i++) {
      if (i % 2 != 0) {
        iOdd++;
      }
      if (array[i] < min) {
        min = array[i];
        if (i % 2 != 0) {
          iMin = iOdd;
        }
      }
    }
  }
  if (iMin == -1) {
    iMin = "unable to evaluate";
  }
  return [min, iMin];
}
