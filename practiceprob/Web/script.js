// Select elements from DOM
const form = document.querySelector('#todo-form');
const input = document.querySelector('#todo-input');
const ul = document.querySelector('#todo-list');

// Add submit event listener
form.addEventListener('submit', function(event) {
    event.preventDefault(); // Prevent page refresh

    const task = input.value.trim(); // Get input value

    if (task !== '') {
        const li = document.createElement('li'); // Create new list item
        li.textContent = task; // Set text content
        ul.appendChild(li); // Add to list
        input.value = ''; // Clear input field
    }
});
// Counter Logic
const incrementBtn = document.querySelector('#increment');
const decrementBtn = document.querySelector('#decrement');
const countDisplay = document.querySelector('#count');

let count = 0;

// Increment
incrementBtn.addEventListener('click', function() {
    count++;
    countDisplay.textContent = count;
});

// Decrement
decrementBtn.addEventListener('click', function() {
    count--;
    countDisplay.textContent = count;
});