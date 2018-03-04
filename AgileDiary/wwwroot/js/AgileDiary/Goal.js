$(document).ready(function () {
    $('#add-goal-button').on('click', createGoal);
});

function createGoal() {
    $('#add-item-error').hide();
    $.post('/Goal/CreateGoal', function () {
        window.location = '/Goal';
    });
}