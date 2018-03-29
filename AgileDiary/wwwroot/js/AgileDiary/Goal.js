$(document).ready(function () {
    $('#add-goal-button').on('click', createGoal);
});

function createGoal() {
    $('#add-item-error').hide();
    var url = window.location.href;
    var sprintIdFromUrl = url.split('/');
    sprintIdFromUrl = sprintIdFromUrl[sprintIdFromUrl.length - 1];
    $.post('/Goal/' + sprintIdFromUrl, function (response) {
        window.location = '/Goal/' + response;
    });
}