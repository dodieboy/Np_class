//limit date for deliver
var now = new Date();
//for today date
today = now.toISOString().slice(0, 10);
document.getElementById("date").setAttribute("min", today);
//for date a week later
now.setDate(now.getDate() + 7);
aWeekLater = now.toISOString().slice(0, 10);
document.getElementById("date").setAttribute("max", aWeekLater);

//cal total order price
var addonPrice = 0;
var sizePrice = 0;
var toppingPrice = 0;
var quantity = 1;
document.getElementById("quantity").onchange = function() {
    quantity = parseInt(document.getElementById("quantity").value);
    totalPrice();
};
document.getElementById("addon").onchange = function() {
    addonPrice = 0;
    for (i = 0; i < document.querySelectorAll('option[id="addons"]:checked').length; i++) {
        if (document.querySelectorAll('option[id="addons"]:checked')[i].value == "Buffalo Wings") {
            addonPrice += 5;
        } else if (document.querySelectorAll('option[id="addons"]:checked')[i].value == "Garlic Bread") {
            addonPrice += 3;
        }
    }
    totalPrice();
};
function sizeChange(size) {
    if (size.value == "small") {
        sizePrice = 22;
    } else if (size.value == "medium") {
        sizePrice = 28;
    } else {
        sizePrice = 35;
    }
    totalPrice();
}
function toppingChange(topping) {
    toppingPrice = document.querySelectorAll('input[id="topping"]:checked').length * 2;
    totalPrice();
}
function totalPrice() {
    document.getElementById("outputs").innerHTML = "Total price for your order is $" + ((sizePrice + toppingPrice) * quantity + addonPrice);
}
