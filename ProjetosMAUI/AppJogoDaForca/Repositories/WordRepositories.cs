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
            _words.Add(new Word("Nome", "Maria".ToUpper()));
            _words.Add(new Word("Vegetal", "Cenoura".ToUpper()));
            _words.Add(new Word("Fruta", "Abacate".ToUpper()));
            _words.Add(new Word("Animal", "Gato".ToUpper()));
            _words.Add(new Word("País", "Brasil".ToUpper()));
            _words.Add(new Word("Cor", "Azul".ToUpper()));
            _words.Add(new Word("Profissão", "Medico".ToUpper()));
            _words.Add(new Word("Esporte", "Futebol".ToUpper()));
            _words.Add(new Word("Comida", "Pizza".ToUpper()));
            _words.Add(new Word("Instrumento Musical", "Violino".ToUpper()));
            _words.Add(new Word("Sobremesa", "Sorvete".ToUpper()));
            _words.Add(new Word("Filme", "Matrix".ToUpper()));
            _words.Add(new Word("Idioma", "Ingles".ToUpper()));
            _words.Add(new Word("Cidade", "Paris".ToUpper()));
            _words.Add(new Word("Personagem de Desenho", "Mickey".ToUpper()));
            _words.Add(new Word("Marca de Carro", "Toyota".ToUpper()));
            _words.Add(new Word("Planta", "Rosa".ToUpper()));
            _words.Add(new Word("Bebida", "Cafe".ToUpper()));
            _words.Add(new Word("Profissão", "Advogado".ToUpper()));
            _words.Add(new Word("Planeta", "Marte".ToUpper()));
            _words.Add(new Word("Animal", "Elefante".ToUpper()));
            _words.Add(new Word("País", "Japao".ToUpper()));
            _words.Add(new Word("Cor", "Verde".ToUpper()));
            _words.Add(new Word("Esporte", "Basquete".ToUpper()));
            _words.Add(new Word("Comida", "Hamburger".ToUpper()));
            _words.Add(new Word("Instrumento Musical", "Piano".ToUpper()));
            _words.Add(new Word("Sobremesa", "Brigadeiro".ToUpper()));
            _words.Add(new Word("Filme", "Titanic".ToUpper()));
            _words.Add(new Word("Idioma", "Espanhol".ToUpper()));
            _words.Add(new Word("Cidade", "Nova York".ToUpper()));
            _words.Add(new Word("Personagem de Desenho", "Bob Esponja".ToUpper()));
            _words.Add(new Word("Marca de Carro", "Ford".ToUpper()));
            _words.Add(new Word("Planta", "Girassol".ToUpper()));
            _words.Add(new Word("Bebida", "Refrigerante".ToUpper()));
            _words.Add(new Word("Planeta", "Saturno".ToUpper()));
        }

        public Word GetRandomWord()
        {
            Random rand = new Random(); 
            var number = rand.Next(0, _words.Count);
            return _words[number];
        }
    }
}
