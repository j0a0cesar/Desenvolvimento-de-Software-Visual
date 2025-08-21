var builder = WebApplication.CreateBuilder(args);
var app = builder.Build(); // vai subir a sua aplicação

app.MapGet("/", () => "Hello World!"); // o MapGet é metodp get 



//() => {}
//funçao anonima
// higher order function -> função de alta ordem
// lambda


//MapGet("xablau", () => {

//})

app.Run(); // vai pegar todos metodos e vai pegar e rodar a aplicação
