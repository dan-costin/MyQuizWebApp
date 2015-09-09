function signUpUser() {
    var myJSONData = '';
    $.ajax({
        // Assuming an endpoint here that responds to GETs with a date.
        url: '/Controllers/LoginController/GetName',
        success: function () {
            $('#date').val(date);
        }
    });
    location.href = "HomeWebForm.aspx";
}