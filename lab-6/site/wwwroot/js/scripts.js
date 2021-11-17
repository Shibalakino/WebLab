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

$(function toFind() {
    var availableTags = [
        "ActionScript",
        "AppleScript",
        "Asp",
        "BASIC",
        "C",
        "C++",
        "Clojure",
        "COBOL",
        "ColdFusion",
        "Erlang",
        "Fortran",
        "Groovy",
        "Haskell",
        "Java",
        "JavaScript",
        "Lisp",
        "Perl",
        "PHP",
        "Python",
        "Ruby",
        "Scala",
        "Scheme"
    ];
    $("#tags").autocomplete({
        source: availableTags
    });
});

