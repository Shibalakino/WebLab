let skills = [
  [17, 18, 15, 16, 7, 14],
  [17, 14, 15, 15, 17, 12],
  [14, 16, 14, 12, 15, 19],
];

let spells = [
  ["Spell name 1", "Spell name 2"],
  ["Spell name 3", "Spell name 4", "Spell name 5"],
  ["Spell name 6", "Spell name 7"],
];

let stories = [
  "A story of a brave silly gnome",
  "A story of a master's guy",
  "Millionaire, philantrop, playboy",
];
const nameSection = document.getElementById("name");
const skillsSection = document.getElementById("skills");
const mainSection = document.getElementById("main-section");

const storySection = document.createElement("section");
storySection.id = "story";
storySection.className = "flex-item flex-container";
storySection.style.width = "70%";
storySection.style.margin = "0px";

const spellsSection = document.createElement("section");
spellsSection.id = "spells";
spellsSection.className = "flex-item flex-container";
spellsSection.style.width = "70%";
spellsSection.style.margin = "0px";

function OpenMain() {
  OpenMain(nameSection.innerText);
}
function OpenMain(name) {
  storySection.remove();
  spellsSection.remove();
  document.getElementsByTagName("main")[0].append(mainSection);
  switch (name) {
    case "Pupen Mazadupen":
      nameSection.innerText = "Pupen Mazadupen";
      document.getElementById("value-strength").innerText = skills[0][0];
      document.getElementById("value-dexterity").innerText = skills[0][1];
      document.getElementById("value-constitution").innerText = skills[0][2];
      document.getElementById("value-intelligence").innerText = skills[0][3];
      document.getElementById("value-wisdom").innerText = skills[0][4];
      document.getElementById("value-charisma").innerText = skills[0][5];
      break;
    case "Florence Landier":
      nameSection.innerText = "Florence Landier";
      document.getElementById("value-strength").innerText = skills[1][0];
      document.getElementById("value-dexterity").innerText = skills[1][1];
      document.getElementById("value-constitution").innerText = skills[1][2];
      document.getElementById("value-intelligence").innerText = skills[1][3];
      document.getElementById("value-wisdom").innerText = skills[1][4];
      document.getElementById("value-charisma").innerText = skills[1][5];
      break;
    case "Nole Ksum":
      nameSection.innerText = "Nole Ksum";
      document.getElementById("value-strength").innerText = skills[2][0];
      document.getElementById("value-dexterity").innerText = skills[2][1];
      document.getElementById("value-constitution").innerText = skills[2][2];
      document.getElementById("value-intelligence").innerText = skills[2][3];
      document.getElementById("value-wisdom").innerText = skills[2][4];
      document.getElementById("value-charisma").innerText = skills[2][5];
      break;
  }
}

function OpenSpells() {
  switch (nameSection.innerText) {
    case "Pupen Mazadupen":
      spellsSection.innerText = spells[0];
      break;
    case "Florence Landier":
      spellsSection.innerText = spells[1];
      break;
    case "Nole Ksum":
      spellsSection.innerText = spells[2];
      break;
  }
  storySection.remove();
  mainSection.remove();
  document.getElementsByTagName("main")[0].append(spellsSection);
}
function OpenStory() {
  switch (nameSection.innerText) {
    case "Pupen Mazadupen":
      storySection.innerText = stories[0];
      break;
    case "Florence Landier":
      storySection.innerText = stories[1];
      break;
    case "Nole Ksum":
      storySection.innerText = stories[2];
      break;
  }
  spellsSection.remove();
  mainSection.remove();
  document.getElementsByTagName("main")[0].append(storySection);
}
