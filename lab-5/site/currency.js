const currencyObj = {
	USD: "долар США",
	UAH: "гривня",
	RUR: "рубль",
	EUR: "євро",
	BTC: "біткоїн",
};
$.getJSON(
	"https://api.privatbank.ua/p24api/pubinfo?json&exchange&coursid=5",
	function (result) {
		console.log(result);
		$.each(result, function (i, field) {
			console.log("field", field);
			var tr =
				"<td>" +
				currencyObj[field.base_ccy] +
				"</td><td>" +
				currencyObj[field.ccy] +
				"</td><td>" +
				field.buy +
				"</td><td>" +
				field.sale +
				"</td>";
			$("#currency-table tbody").append("<tr>" + tr + "</tr>");
		});
	},
);
