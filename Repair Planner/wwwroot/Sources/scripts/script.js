function CloseAddContainer() {
	let window = document.getElementById('adding-window');
	window.classList.add('disappear-window-animation');
	let container = document.getElementById('add-task-container');
	container.classList.add('dissolution-animation');
	setTimeout(Hide, 300, container);
	UpdateTaskList();
}

function UpdateTaskList() {
	if (document.getElementById('search-container') != null)
		return;

	let allItem = document.getElementById('all-section');
	if (!allItem.classList.contains('active-section')) {
		let past = document.getElementsByClassName('active-section');
		past.item(0).classList.remove('active-section');
		allItem.classList.add('active-section');
	}
	$.ajax({
		url: 'Home/UpdateTaskList',
		success: function (data) {
			$('#tasks').html(data);
		}
	});

	$.ajax({
		url: 'Home/UpdateStatistics',
		success: function (data) {
			$('#statistics-container').html(data);
		}
	});
}

function ShowAddWindow() {
	let window = document.getElementById('adding-window');
	window.classList.remove('disappear-window-animation');
	let cont = document.getElementById('add-task-container');
	cont.classList.remove('dissolution-animation');
	cont.style.display = 'flex';
}

function ShowTask(taskId) {
	$.ajax({
		url: 'Home/ShowTask?taskId=' + taskId,
		success: function (data) {
			$('#ajax-view-task').html(data);
		}
	});
}

function CloseTaskView() {
	let window = document.getElementById('view-task-window');
	window.classList.add('disappear-window-animation');
	let container = document.getElementById('view-task-container');
	container.classList.add('dissolution-animation');
	setTimeout(Hide, 300, container);
	UpdateTaskList();
}

function Hide(container) {
	container.style.display = 'none';
}

let isAddingStage = false;

function ShowAddStageForm(taskId) {
	let plusButton = document.getElementById('plus-stage');
	if (!isAddingStage) {
		plusButton.style.transition = '0.5s';
		plusButton.style.transform = 'rotate(45deg)';
		isAddingStage = true;
		$.ajax({
			url: 'Home/ShowAddStageForm?taskId='+taskId,
			success: function (data) {
				$('#add-stage-form').html(data);
			}
		});
	} else {
		let form = document.getElementById('add-stage-form');
		form.classList.add('disappear-window-animation');			
		setTimeout(HideStageForm, 100);
		setTimeout(RemoveDisappearing, 200, form);
		plusButton.style.transform = 'rotate(0deg)';
		isAddingStage = false;
	}
}

function HideStageForm() {	
	$.ajax({
		url: 'Home/HideAddStageForm',
		success: function (data) {
			$('#add-stage-form').html(data);
		}
	});	
}

function RemoveDisappearing(form) {
	form.classList.remove('disappear-window-animation');
}

document.addEventListener("DOMContentLoaded", Beginning);

function Beginning() {
	UpdateTaskList();
}

function EnableSection(sectionName) {
	let item = document.getElementById(sectionName + '-section');
	if (item.classList.contains('active-section'))
		return;
	let past = document.getElementsByClassName('active-section');
	past.item(0).classList.remove('active-section');
	item.classList.add('active-section');
	$.ajax({
		url: 'Home/GetTaskList?type=' + sectionName,
		success: function (data) {
			$('#tasks').html(data);
		}
	});
}

function ShowRegistrationForm() {
	$.ajax({
		url: 'Home/GetOrgSignUpForm',
		success: function (data) {
			$('#org-signUp-window').html(data);
		}
	});
}

function ShowInputCodeForm() {
	$.ajax({
		url: 'Home/GetInputCodeForm',
		success: function (data) {
			$('#org-signUp-window').html(data);
		}
	});
}

function CreateRequestCode() {
	$.ajax({
			url: 'Home/CreateRequestCode',
			success: function (data) {
				$('#ajax-container').html(data);
			}
		});
}

function CloseWindow(windowName) {
	let window = document.getElementById(windowName);
	window.classList.add('disappear-window-animation');
	let container = document.getElementById(windowName + '-container');
	container.classList.add('dissolution-animation');
	setTimeout(Hide, 300, container);
}

function Hide(container) {
	container.style.display = 'none';
}

function Search() {
	let request = document.getElementById('search-field').value;
	let activeSection = document.getElementsByClassName('active-section').item(0).id;
	$.ajax({
		url: 'Home/Search?request=' + request + '&listName=' + activeSection,
		success: function (data) {
			$('#tasks').html(data);
		}
	});
}