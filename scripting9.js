function counnter() {
    var t = document.getElementById("text").value;
    var totalCharacter = 0;
    for (var i = 0; i < t.length; i++) {
        if (t[i] != " ") {
            totalCharacter += 1;
        }

    }
    document.getElementById("info").innerHTML = "Total number of Characters are: "+totalCharacter;
}

