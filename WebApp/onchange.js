
document.getElementById("drpUserSelect").addEventListener("change", ChangeDDL);
function ChangeDDL() {
    var drpUserSelect = document.getElementById("drpUserSelect").value;
    if (drpUserSelect == "Faculty") {
        document.getElementById("h2Program").innerHTML = "Office Address";
        document.getElementById("h2Credit").innerHTML = "Office Phone";
    }
    else {
        document.getElementById("h2Program").innerHTML = "Student Program";
        document.getElementById("h2Credit").innerHTML = "Credit Hours";
    }
    
    
}