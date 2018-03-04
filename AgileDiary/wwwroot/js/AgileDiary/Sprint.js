$(document).ready(function () {
    $('#add-sprint-button').on('click', createSprint);
});

function createSprint() {
    $('#add-item-error').hide();
    $.post('/Sprint/CreateSprint', function (response) {
        window.location = '/Sprint/' + response;
    });
}