$(document).ready(function () {
    $('#add-sprint-button').on('click', createSprint);
});

function createSprint() {
    $('#add-item-error').hide();
    var newTitle = $('#add-item-title').val();
    $.post('/Sprint/CreateSprint', { title: newTitle }, function () {
        window.location = '/Sprint';
    });
}