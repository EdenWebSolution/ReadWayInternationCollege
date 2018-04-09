var isSent = '@Viewbag.Sent';
$(function () {

    $('#btnSend-ContactUsMessage').click(function () {

        if ($('#Name').val().length > 0 && $('#EmailAddress').val().length > 0 && $('#Subject').val().length > 0 && $('#Message').val().length > 0) {

            // $('#Name').val(''); $('#EmailAddress').val(''); $('#Subject').val(''); $('#Message').val('');
        }
    });
});