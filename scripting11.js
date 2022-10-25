function myCalculate() {
    var Value = document.getElementById("salary").value;
    try {
        a = parseInt(Value);
        if (Number.isInteger(a)) {
            var inputValue = Value * 12;
            if (inputValue <= 600000) {
                document.getElementById("p1").innerHTML = "Montly taxation is: " + 0;
                document.getElementById("p2").innerHTML = "Monthly salary after tax is: " + inputValue / 12;
                document.getElementById("p3").innerHTML = "Yearly tax is:" + 0;
                document.getElementById("p4").innerHTML = "Yearly salary after tax is: " + inputValue;
            }
            else if (600000 < inputValue < 1200000) {
                var x = inputValue - 600000;
                var tax = x * (2.5 / 100);
                var year = inputValue - tax;
                document.getElementById("p1").innerHTML = "Montly taxation is: " + tax / 12;
                document.getElementById("p2").innerHTML = "Monthly salary after tax is: " + year / 12;
                document.getElementById("p3").innerHTML = "Yearly tax is:" + tax;
                document.getElementById("p4").innerHTML = "Yearly salary after tax is: " + (year);

            }
            else if (1200000 < inputValue < 2400000) {
                var x = inputValue - 1200000;
                var tax1 = x * (12.5 / 100);
                var tax = 15000 + tax1;
                var year = inputValue - tax;
                document.getElementById("p1").innerHTML = "Montly taxation is: " + tax / 12;
                document.getElementById("p2").innerHTML = "Monthly salary after tax is: " + year / 12;
                document.getElementById("p3").innerHTML = "Yearly tax is:" + tax;
                document.getElementById("p4").innerHTML = "Yearly salary after tax is: " + (year);

            }
            else if (2400000 < inputValue < 3600000) {
                var x = inputValue - 2400000;
                var tax1 = x * (20 / 100);
                var tax = 165000 + tax1;
                var year = inputValue - tax;
                document.getElementById("p1").innerHTML = "Montly taxation is: " + tax / 12;
                document.getElementById("p2").innerHTML = "Monthly salary after tax is: " + year / 12;
                document.getElementById("p3").innerHTML = "Yearly tax is:" + tax;
                document.getElementById("p4").innerHTML = "Yearly salary after tax is: " + (year);

            }
            else if (3600000 < inputValue < 6000000) {
                var x = inputValue - 3600000;
                var tax1 = x * (25 / 100);
                var tax = 405000 + tax1;
                var year = inputValue - tax;
                document.getElementById("p1").innerHTML = "Montly taxation is: " + tax / 12;
                document.getElementById("p2").innerHTML = "Monthly salary after tax is: " + year / 12;
                document.getElementById("p3").innerHTML = "Yearly tax is:" + tax;
                document.getElementById("p4").innerHTML = "Yearly salary after tax is: " + (year);

            }
            else if (6000000 < inputValue < 12000000) {
                var x = inputValue - 6000000;
                var tax1 = x * (32.5 / 100);
                var tax = 1005000 + tax1;
                var year = inputValue - tax;
                document.getElementById("p1").innerHTML = "Montly taxation is: " + tax / 12;
                document.getElementById("p2").innerHTML = "Monthly salary after tax is: " + year / 12;
                document.getElementById("p3").innerHTML = "Yearly tax is:" + tax;
                document.getElementById("p4").innerHTML = "Yearly salary after tax is: " + (year);

            }
            else if (inputValue > 12000000) {
                var x = inputValue - 12000000;
                var tax1 = x * (35 / 100);
                var tax = 29550000 + tax1;
                var year = inputValue - tax;
                document.getElementById("p1").innerHTML = "Montly taxation is: " + tax / 12;
                document.getElementById("p2").innerHTML = "Monthly salary after tax is: " + year / 12;
                document.getElementById("p3").innerHTML = "Yearly tax is:" + tax;
                document.getElementById("p4").innerHTML = "Yearly salary after tax is: " + (year);

            }


        }
        else {
            throw ("Please Enter number")
        }


    }
    catch (err) {
        alert("Input is either string, character or empty. Refresh and " + err);
        document.getElementById("p1").innerHTML = "Invalid Entry";


    }

}