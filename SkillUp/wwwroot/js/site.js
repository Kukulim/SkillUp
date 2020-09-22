$("#v-pills-tasks-tab").on("click", function () {
    $.ajax({
        url: '/Tasks/LoadTasks',
        type: 'post',
        success: function (objOperations) {
            $("#v-pills-tasks").html(objOperations);
        }
    });
});

$("body").delegate("#taskDetailsBtn", "click", function (e) {
    $("#taskDetails").removeClass("d-none");
    $.ajax({
        url: '/Tasks/LoadSingleTask?taskId=' + $(e.target).attr("data"),
        type: 'post',
        success: function (objOperations) {
            $("#taskDetails").html(objOperations);
        }
    });
});

$("body").delegate("#taskExitBtn", "click", function (e) {
    $("#taskDetails").addClass("d-none");
});