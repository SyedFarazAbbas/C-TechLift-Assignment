function myName() {
    var firstName = document.getElementById("fName").value;
    var lastName = document.getElementById("lName").value;
    if (document.getElementById("s1").value == "1") {
        var Name = firstName + " " + lastName;
    }

    else {
        var Name = lastName + " " + firstName;
    }

    document.getElementById("s").innerHTML ="formated name: "+ Name;
}