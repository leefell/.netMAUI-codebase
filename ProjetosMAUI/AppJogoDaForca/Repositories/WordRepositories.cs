using AppJogoDaForca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppJogoDaForca.Repositories
{
    // guarda a lista de palavras 
    internal class WordRepositories
    {
        private List<Word> _words;
        public WordRepositories()
        {
            _words = new List<Word>();
            _words.Add(new Word("Nome", "Maria"));
            _words.Add(new Word("Vegetal", "Cenoura"));
            _words.Add(new Word("Fruta", "Abacate"));
            _words.Add(new Word("Animal", "Gato"));
            _words.Add(new Word("País", "Brasil"));
            _words.Add(new Word("Cor", "Azul"));
            _words.Add(new Word("Profissão", "Medico"));
            _words.Add(new Word("Esporte", "Futebol"));
            _words.Add(new Word("Comida", "Pizza"));
            _words.Add(new Word("Instrumento Musical", "Violino"));
            _words.Add(new Word("Sobremesa", "Sorvete"));
            _words.Add(new Word("Filme", "Matrix"));
            _words.Add(new Word("Idioma", "Ingles"));
            _words.Add(new Word("Cidade", "Paris"));
            _words.Add(new Word("Personagem de Desenho", "Mickey"));
            _words.Add(new Word("Marca de Carro", "Toyota"));
            _words.Add(new Word("Planta", "Rosa"));
            _words.Add(new Word("Bebida", "Cafe"));
            _words.Add(new Word("Profissão", "Advogado"));
            _words.Add(new Word("Planeta", "Marte"));
            _words.Add(new Word("Animal", "Elefante"));
            _words.Add(new Word("País", "Japao"));
            _words.Add(new Word("Cor", "Verde"));
            _words.Add(new Word("Esporte", "Basquete"));
            _words.Add(new Word("Comida", "Hamburger"));
            _words.Add(new Word("Instrumento Musical", "Piano"));
            _words.Add(new Word("Sobremesa", "Brigadeiro"));
            _words.Add(new Word("Filme", "Titanic"));
            _words.Add(new Word("Idioma", "Espanhol"));
            _words.Add(new Word("Cidade", "Nova York"));
            _words.Add(new Word("Personagem de Desenho", "Bob Esponja"));
            _words.Add(new Word("Marca de Carro", "Ford"));
            _words.Add(new Word("Planta", "Girassol"));
            _words.Add(new Word("Bebida", "Refrigerante"));
            _words.Add(new Word("Planeta", "Saturno"));

        }

        public Word GetRandomWord()
        {
            Random rand = new Random(); 
            var number = rand.Next(0, _words.Count);
            return _words[number];
        }
    }
}
