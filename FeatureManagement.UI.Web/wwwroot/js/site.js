// Write your Javascript code.
$(document).ready(function () {
    var submit = document.getElementById('add-btn');
    submit.addEventListener('click', function (e) {
        $.ajax({
            url: 'http://localhost:8290/api/values',
            method: 'GET',
            accepts: 'application/json',
            success: function (data) {
                alert(data);
            },
            error: function (err) {
                if (err) {
                    alert(err);
                }
            }
        });        
    });
});