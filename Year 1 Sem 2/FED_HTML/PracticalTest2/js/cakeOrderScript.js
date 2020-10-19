//limit date for collection
var now = new Date();
//for today date
today = now.toISOString().slice(0, 10);
document.getElementById("iDate").setAttribute("min", today);
//for a month later
now.setDate(now.getDate() + 7);
aWeekLater = now.toISOString().slice(0, 10);
document.getElementById("iDate").setAttribute("max", aWeekLater);

calculateTotal();

function calculateTotal() {
    var price = 0;
    var types = document.getElementById("cakeType");
    var quantity = document.getElementById("quantity").value;
    var size = 0;

    if (types.value == "Cheesecake") {
        price = 40;
    } else if (types.value == "Black Forest Cake") {
        price = 30;
    } else if (types.value == "Chocolate Cake") {
        price = 35;
    } else if (types.value == "Fruit Cake") {
        price = 38;
    } else {
        price = 0;
    }
    console.log(document.querySelector('input[name="size"]:checked').value);
    if (document.querySelector('input[type="radio"]:checked').value == "small") {
        size = 1;
    } else if (document.querySelector('input[type="radio"]:checked').value == "medium") {
        size = 1.5;
    } else {
        size = 2;
    }

    document.getElementById("totalPrice").innerHTML = "Total price for your order is $" + price * size * quantity;
}

function submitForm() {
    var name = document.getElementById("iName").value;
    var types = document.getElementById("cakeType").value;
    var date = document.getElementById("iDate").value;
    var time = document.getElementById("iTime").value;

    alert("Thank you for your order, " + name + ". You will receive your " + types + " at " + time + " on " + date);
}
