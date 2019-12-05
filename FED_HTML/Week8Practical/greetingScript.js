var name = prompt("Enter your name:");
var d = Date();
if (d.getHours < 12) {
    alert("Good morning, " + name + "!");
    document.getElementById("h1").innerHTML = "Good morning, " + name + "!";
} else {
    alert("Good afternoon, " + name + "!");
    document.getElementById("h1").innerHTML = "Good afternoon, " + name + "!";
}
