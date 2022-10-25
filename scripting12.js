function chec() {
    var count = 0;
    var n = document.getElementById("naam").value;
    var pp = document.getElementById("p").value;
    
    const a = ["faraz", 123, "abbas", 321, "ibi", 456];
    for (var i = 0; i < a.length; i++)

    {
        if (a[i] == n){
            if (a[i + 1] == pp);

            {
                window.open("https://www.w3schools.com");
                break;
                
                
            }

        }

        count+= 1; 
        if (count == 3) {
            alert("Incorrect Password or email");
        }

    }
}