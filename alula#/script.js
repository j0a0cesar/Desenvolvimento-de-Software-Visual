// Capturas de tags
const form= document.querySelector('form');
const inputPoke= document.getElementById('inputPoke');
const pokeImg = document.querySelector('img');
const pokeName = document.querySelector('p');


// Código da lógica
//assincrono
const fetchAPI = (pokemon) => {

    const result = fetch(`https://pokeapi.co/api/v2/pokemon/${pokemon}`)
        .then((res) => res.json())
        .then((data) => data);

    return result;
}
// Chamadas da função
form.addEventListener('submit', (event) => {
    event.preventDefault();

    console.log(fetchAPI(inputPoke.value));
})
