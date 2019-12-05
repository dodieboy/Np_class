var height = 1.7;
var weight = 50;
cal();

document.getElementById("height").onchange = function() {
    height = parseDouble(document.getElementById("height").value);
    cal();
};
document.getElementById("weight").onchange = function() {
    weight = parseDouble(document.getElementById("weight").value);
    cal();
};
function cal() {
    var bmi = (weight / (height * height)).toFixed(2);
    var health = null;

    if (bmi < 18.5) {
        health = "Under weight";
    } else if (bmi < 23) {
        health = "Normal weight";
    } else if (bmi < 27.5) {
        health = "Over weight";
    } else if (bmi >= 27.5) {
        health = "Obese";
    } else {
        health = "...";
    }
    document.getElementById("output").innerHTML = "Your BMI is " + bmi + ". You are " + health;
}
