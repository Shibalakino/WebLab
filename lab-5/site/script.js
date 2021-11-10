babyAnimalImg = document.createElement("img");
babyAnimalImg.style.width = "100%";

function showBabyAnimal(number, animal) {
	let babyAnimalContainer;
	if (animal == "kitty") {
		babyAnimalImg.src = "img/kitties/" + number + ".jpg";
		babyAnimalContainer = document.getElementById("kitty-img");
	} else if (animal == "puppy") {
		babyAnimalImg.src = "img/puppies/" + number + ".jpg";
		babyAnimalContainer = document.getElementById("puppy-img");
	} else if (animal == "chick") {
		babyAnimalImg.src = "img/chicks/" + number + ".jpg";
		babyAnimalContainer = document.getElementById("chick-img");
	}
	babyAnimalImg.alt = babyAnimalImg.src;
	babyAnimalContainer.appendChild(babyAnimalImg);
}

function writeCurrentTime() {
	var today = new Date();
	var date =
		today.getDate() + "." + (today.getMonth() + 1) + "." + today.getFullYear();
	var time =
		today.getHours() + ":" + today.getMinutes() + ":" + today.getSeconds();
	var dateDiv = document.getElementById("date");
	var timeDiv = document.getElementById("time");
	dateDiv.innerText = date;
	timeDiv.innerText = time;
}

function updateDateTime() {
	setInterval(writeCurrentTime, 1000);
}
