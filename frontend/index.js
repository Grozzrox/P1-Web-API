const h1 = document.querySelector('h1');
const h2 = document.querySelector('h2');
const img = document.querySelector('img');

h1.addEventListener("click", function() {
    h1.innerHTML = "&#9829";
    h1.style.fontSize = "2.5rem";
    h2.style.display = "block";
    img.src = "./images/kanye.jpg";
});