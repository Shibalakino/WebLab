function DoWork() {
  let len = parseInt(prompt("Enter array size: "));
  let numbers = [];
  FillArray(numbers, len);

  let minMaxEvenIndexes = FindMinMaxEvenIndexes(numbers);
  let minMaxOddIndexes = FindMinMaxOddIndexes(numbers);

  let numbers2 = [...numbers];
  SelectionSort(numbers2);
  const data = document.createElement("section");
  data.style.height = "50%";
  data.style.width = "50%";
  data.innerText =
    "initial array: " +
    numbers +
    "\n" +
    "min and max on even indexes:" +
    minMaxEvenIndexes[0] +
    " " +
    minMaxEvenIndexes[1] +
    "\n" +
    "min and max on odd indexes:" +
    minMaxOddIndexes[0] +
    " " +
    minMaxOddIndexes[1] +
    "\n" +
    "the sorted array:" +
    numbers2;
  document.body.append(data);
}

function FillArray(array, length) {
  for (let index = 0; index < length; index++) {
    array.push(Math.ceil(Math.random() * 10));
  }
}

function FindMinMaxEvenIndexes(arr) {
  let min = 10;
  let max = -1;
  for (let i = 0; i < arr.length; i += 2) {
    if (arr[i] < min) min = arr[i];
    if (arr[i] > max) max = arr[i];
  }
  return [min, max];
}

function FindMinMaxOddIndexes(arr) {
  let min = 10;
  let max = -1;
  for (let i = 1; i < arr.length; i += 2) {
    if (arr[i] < min) min = arr[i];
    if (arr[i] > max) max = arr[i];
  }
  return [min, max];
}

function SelectionSort(arr) {
  for (let i = 0; i < arr.length; i++) {
    let min = i;
    for (let j = i + 1; j < arr.length; j++) {
      if (arr[j] < arr[min]) {
        min = j;
      }
    }
    if (min != i) {
      let tmp = arr[i];
      arr[i] = arr[min];
      arr[min] = tmp;
    }
  }
  return arr;
}
