// Toggle navigation menu visibility
function toggleMenu() {
    const nav = document.querySelector('nav ul');
    nav.classList.toggle('visible');
}

// Smooth scrolling for navigation links
document.querySelectorAll('nav a').forEach(link => {
    link.addEventListener('click', function (e) {
        e.preventDefault();
        const targetId = this.getAttribute('href').substring(1);
        const targetElement = document.getElementById(targetId);
        targetElement.scrollIntoView({ behavior: 'smooth' });
    });
});

// Form validation
const form = document.querySelector('#contact form');
form.addEventListener('submit', function (e) {
    const name = document.getElementById('name');
    const email = document.getElementById('email');
    const message = document.getElementById('message');

    if (!name.value || !email.value || !message.value) {
        e.preventDefault();
        alert('Please fill in all fields before submitting.');
    }
});
