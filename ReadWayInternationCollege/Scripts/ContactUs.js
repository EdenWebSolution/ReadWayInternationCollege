$(document).ready(function () {
    $("#ContactUsForm").submit(function (event) {
        if (!$("#ContactUsForm").valid()) { return; }
        $('#secondaryLoader').removeAttr('hidden');
        $('#message').hide();

        var dataString;
        event.preventDefault();
        event.stopImmediatePropagation();
        var action = $("#ContactUsForm").attr("action");
        dataString = new FormData($("#ContactUsForm").get(0));
        contentType = false;
        processData = false;
        $.ajax({
            type: "POST",
            url: action,
            data: dataString,
            dataType: "json",
            contentType: contentType,
            processData: processData,
            success: function (result) {

                onAjaxRequestSuccess(result);
            },
            error: function (jqXHR, textStatus, errorThrown) {
                $('#secondaryLoader').hide();
                $('#message').show();
                toastr.error("Something went wrong, please try refreshing the page", "Fail");
            }
        });
    });
});
var onAjaxRequestSuccess = function (result) {
    var status = result.status;
    if (status == 0) {
        toastr.success(result.message, result.subject);
        $('#Name').val('');
        $('#EmailAddress').val('');
        $('#Subject').val('');
        $('#Message').val('');
        $('#secondaryLoader').hide();
        $('#message').show();
    }

    if (status == 1) {
        toastr.error(result.message, result.subject);
    }
}  