function CloseWindow(windowName) {
    let window = document.getElementById(windowName);
    window.classList.add('disappear-window-animation');
    let container = document.getElementById(windowName+'-container');
    container.classList.add('dissolution-animation');
    setTimeout(Hide, 300, container);
}

function Hide(container) {
    container.style.display = 'none';
}

function CheckField(field) {
    let inputValue;
    switch (field) {
        case 'email':
            inputValue = document.getElementById('email-input').value;
            break;
        case 'password':
            inputValue = document.getElementById('password-input').value;
            CheckField('confirmPassword');
            break;
        case 'confirmPassword':
            inputValue = document.getElementById('password-input').value + '~' + document.getElementById('confirmPassword-input').value;
            break;
        case 'logIn':
            inputValue = document.getElementById('logIn-input').value;
            break;
        case 'phoneNumber':
            inputValue = document.getElementById('phoneNumber-input').value;
            break;
    }
    CheckingResult(field, inputValue);
}

function CheckingResult(field, value) {
    $.ajax({
        url: '/Account/CheckField?field=' + field + '&value=' + value,
        success: function (data) {
            $('#'+field+'-mark').html(data);
        }
    });
    setTimeout(SwitchButton, 300);
}

function SwitchButton() {
    let checkedItems = document.getElementsByClassName('False');
    document.getElementById('sign-up-button').disabled = false;
    if (checkedItems.length != 0)
        document.getElementById('sign-up-button').disabled = true;
}

function ShowRestorePasswordWindow() {
    $.ajax({
        url: '/Account/RestorePasswordShow',
        success: function (data) {
            $('#ajax-container').html(data);
        }
    });
}

function ShowTip(tipContent) {
    let tip = document.getElementById('tip');
    if (tipContent != 'no changes')
        tip.textContent = tipContent;
    tip.style.display = 'block';
    tip.style.left = (event.pageX+15)+'px';
    tip.style.top = (event.pageY+15)+'px';
}

function HideTip(){
    let tip = document.getElementById('tip');
    tip.style.display = 'none';
}