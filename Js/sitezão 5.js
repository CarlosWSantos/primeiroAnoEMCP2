function typeWriter(elemento){
    const TextArray = elemento.innerHTML.split('');
    elemento.innerHTML = ("");
    TextArray.forEach((letra, i) => {
        setTimeout(() => {
    elemento.innerHTML += letra;
        }, 75 * i) 
    });
}


const titulo = document.querySelector('.Pisca');
typeWriter(titulo);
const audio = document.querySelector('audio')
    audio.play();
