//limit date for collection
var now = new Date();
//for today date
today = now.toISOString().slice(0, 10);
document.getElementById("date").setAttribute("min", today);
//for date 2 week later
now.setMonth(now.getMonth() + 1);
aWeekLater = now.toISOString().slice(0, 10);
document.getElementById("date").setAttribute("max", aWeekLater);

//form
var item = [["Black bean purses", 3.95], ["Southwestern Napoleons", 7.95], ["Coconut-Corn Chowder", 3.95], ["Jerk Rotisserie Chicken", 12.95], ["Thai Shrimp Kebabs", 12.95], ["Pasta Puttanesca", 12.95]]
price_cal()


function price_cal() {
    document.getElementById("outputs").innerHTML = "You order " + document.getElementById("quantity").value + " " + item[document.getElementById("item").value][0] + ". Price = $" + item[document.getElementById("item").value][1] + " x " + document.getElementById("quantity").value + " = $" + (item[document.getElementById("item").value][1] * document.getElementById("quantity").value).toFixed(2) + "<br />Collection Date: " + document.getElementById("date").value;
}

function submits() {
    document.getElementById("complete_order").innerHTML = "Thank you for your order, " + document.getElementById("name").value
}