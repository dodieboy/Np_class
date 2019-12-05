document.getElementById("jc").onchange = function() {
    var inputs = document.getElementById("jc").value;
    var point;
    if (inputs == "ACJC") {
        point = 8;
    } else if (inputs == "AJC") {
        point = 11;
    } else if (inputs == "CJC") {
        point = 10;
    } else if (inputs == "EJC") {
        point = 9;
    } else if (inputs == "HCI") {
        point = 4;
    } else if (inputs == "NJC") {
        point = 7;
    } else if (inputs == "NYJC") {
        point = 7;
    } else if (inputs == "SAJC") {
        point = 10;
    } else if (inputs == "TJC") {
        point = 9;
    } else if (inputs == "VJC") {
        point = 7;
    }
    document.getElementById("outputs").innerHTML = "Entry Point for " + inputs + " is " + point;
};
