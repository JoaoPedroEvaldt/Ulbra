const taskInput = document.getElementById('taskInput');
const addButton = document.getElementById('addButton');
const pendingTasks = document.getElementById('pendingTasks');
const completedTasks = document.getElementById('completedTasks');

// Função para criar um novo elemento de tarefa
function createTaskElement(taskText) {
  const taskElement = document.createElement('li');
  taskElement.innerText = taskText;
  taskElement.classList.add('task');

  const actionsContainer = document.createElement('div');
  actionsContainer.classList.add('actions');

  const completeButton = document.createElement('button');
  completeButton.innerText = 'Concluir';
  completeButton.addEventListener('click', completeTask);

  const deleteButton = document.createElement('button');
  deleteButton.innerText = 'Excluir';
  deleteButton.addEventListener('click', deleteTask);

  actionsContainer.appendChild(completeButton);
  actionsContainer.appendChild(deleteButton);

  taskElement.appendChild(actionsContainer);

  return taskElement;
}

// Função para adicionar uma nova tarefa à lista de tarefas pendentes
function addTask() {
  const taskText = taskInput.value;
  if (taskText.trim() === '') {
    return;
  }

  const taskElement = createTaskElement(taskText);
  pendingTasks.appendChild(taskElement);

  taskInput.value = '';
}

// Função para marcar uma tarefa como concluída
function completeTask(event) {
  const taskElement = event.target.parentElement.parentElement;
  taskElement.classList.add('completed');
  taskElement.querySelector('.actions').remove();
  completedTasks.appendChild(taskElement);
}

// Função para excluir uma tarefa
function deleteTask(event) {
  const taskElement = event.target.parentElement.parentElement;
  taskElement.remove();
}

// Adicionando o evento de clique ao botão de adicionar tarefa
addButton.addEventListener('click', addTask);
