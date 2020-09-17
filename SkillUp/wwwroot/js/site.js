
    $("#v-pills-tasks-tab").on("click", function () {
        $.ajax({
            url: '/Tasks/LoadTasks',
            type: 'post',
            success: function (objOperations) {
                $("#v-pills-tasks").html(objOperations);
            }
        });
    });

