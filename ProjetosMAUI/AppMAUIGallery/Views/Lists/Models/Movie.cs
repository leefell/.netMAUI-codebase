using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMAUIGallery.Views.Lists.Models
{
    internal class Movie
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public TimeSpan Duration { get; set; }
        public short LaunchYear { get; set; }

        public override string ToString()
        {
            return $"{Id} - {Name} - {LaunchYear}";
        }
    }

    internal class GroupMovie : List<Movie>
    {
        public string CompanyName { get; set; }
    }

    internal class MovieList
    {
        public static List<GroupMovie> GetGroupList()
        {
            var firstGroup = new GroupMovie() { CompanyName = "Primeiro Grupo" };
            var secondGroup = new GroupMovie() { CompanyName = "Segundo Grupo" };
            var thirdGroup = new GroupMovie() { CompanyName = "Terceiro grupo" };
            var fourthGroup = new GroupMovie() { CompanyName = "Quarto Grupo" };

            firstGroup.Add(new Movie()
            {
                Id = 1,
                Name = "Como treinar seu Dragão",
                Description = "Soluço é um jovem viking que não tem capacidade para lutar contra os dragões, como é a tradição local. Sua vida muda quando ele ajuda um dragão que lhe mostra toda a verdade. Juntos, eles tentam provar que dragões e humanos podem ser amigos.",
                LaunchYear = 2010,
                Duration = new TimeSpan(1, 38, 0)
            });
            firstGroup.Add(new Movie()
            {
                Id = 2,
                Name = "The Batman",
                Description = "Após dois anos espreitando as ruas como Batman, Bruce Wayne se encontra nas profundezas mais sombrias de Gotham City. Com poucos aliados confiáveis, o vigilante solitário se estabelece como a personificação da vingança para a população.",
                LaunchYear = 2022,
                Duration = new TimeSpan(2, 56, 0)
            });
            firstGroup.Add(new Movie()
            {
                Id = 3,
                Name = "Deadpool 2",
                Description = "O supersoldado Cable vem do futuro com a missão de assassinar o jovem mutante Russel e o mercenário Deadpool precisa aprender o que é ser herói de verdade para salvá-lo. Para isso, ele recruta seu velho amigo Colossus e forma o novo grupo X-Force, sempre com o apoio do fiel escudeiro Dopinder.",
                LaunchYear = 2018,
                Duration = new TimeSpan(2, 00, 0)
            });
            firstGroup.Add(new Movie()
            {
                Id = 4,
                Name = "Fight Club",
                Description = "Um homem descontente com a sociedade moderna forma um clube de luta subterrâneo onde os homens podem lutar sem restrições. Mas à medida que o clube cresce, ele se envolve em algo muito maior e mais perigoso.",
                LaunchYear = 1999,
                Duration = new TimeSpan(2, 19, 0)
            });
            firstGroup.Add(new Movie()
            {
                Id = 5,
                Name = "Interestelar",
                Description = "Um grupo de exploradores viaja através de um buraco de minhoca no espaço em busca de um novo planeta para a humanidade, enquanto enfrentam desafios físicos e temporais que desafiam a compreensão humana.",
                LaunchYear = 2014,
                Duration = new TimeSpan(2, 49, 0)
            });

       
            secondGroup.Add(new Movie()
            {
                Id = 6,
                Name = "Batman The Dark Knight",
                Description = "O Cavaleiro das Trevas enfrenta um novo e desafiador inimigo, o Coringa, que espalha caos e terror em Gotham City. Enquanto isso, Batman também deve lidar com dilemas éticos e morais sobre seu papel como vigilante.",
                LaunchYear = 2008,
                Duration = new TimeSpan(2, 32, 0)
            });
            secondGroup.Add(new Movie()
            {
                Id = 7,
                Name = "The Social Network",
                Description = "Um drama que narra a ascensão do Facebook, desde sua criação em um dormitório de faculdade até se tornar uma das maiores redes sociais do mundo, enquanto explora os conflitos e disputas legais entre os fundadores.",
                LaunchYear = 2010,
                Duration = new TimeSpan(2, 0, 0)
            });
            secondGroup.Add(new Movie()
            {
                Id = 8,
                Name = "Spider-Man: Into the Spider-Verse",
                Description = "O jovem Miles Morales descobre que há mais de um Homem-Aranha no multiverso quando ele encontra o Peter Parker de uma realidade alternativa. Juntos, eles devem unir forças com outros Homens-Aranha para impedir uma ameaça que pode destruir todas as realidades.",
                LaunchYear = 2018,
                Duration = new TimeSpan(1, 57, 0)
            });
            secondGroup.Add(new Movie()
            {
                Id = 9,
                Name = "Iron Man",
                Description = "Tony Stark, um industrialista bilionário e gênio inventor, é sequestrado por terroristas e forçado a construir uma arma devastadora. Em vez disso, ele constrói uma armadura de alta tecnologia para escapar do cativeiro. Determinado a usar sua invenção para o bem, ele se torna o super-herói conhecido como Homem de Ferro.",
                LaunchYear = 2008,
                Duration = new TimeSpan(2, 6, 0)
            });
            secondGroup.Add(new Movie()
            {
                Id = 10,
                Name = "Homem-Aranha",
                Description = "Peter Parker, um tímido estudante, é mordido por uma aranha geneticamente modificada e ganha poderes aracnídeos. Ele decide usar suas habilidades para combater o crime como o super-herói Homem-Aranha, enquanto enfrenta desafios pessoais e luta contra vilões perigosos.",
                LaunchYear = 2002,
                Duration = new TimeSpan(2, 1, 0)
            });


            thirdGroup.Add(new Movie()
            {
                Id = 11,
                Name = "O Rei Leão",
                Description = "Um jovem leão chamado Simba foge após a morte de seu pai, o rei Mufasa, com medo de assumir o trono. Ele precisa enfrentar seu passado e seu tio malévolo Scar para retomar seu lugar como o verdadeiro rei da Pedra do Reino.",
                LaunchYear = 1994,
                Duration = new TimeSpan(1, 28, 0)
            });
            thirdGroup.Add(new Movie()
            {
                Id = 12,
                Name = "Toy Story",
                Description = "Um filme de animação da Pixar que segue a história de brinquedos que ganham vida quando seus donos não estão por perto. Woody, o cowboy de pano, e Buzz Lightyear, o astronauta do espaço, enfrentam aventuras juntos enquanto aprendem sobre amizade e lealdade.",
                LaunchYear = 1995,
                Duration = new TimeSpan(1, 21, 0)
            });
            thirdGroup.Add(new Movie()
            {
                Id = 13,
                Name = "O Senhor dos Anéis: A Sociedade do Anel",
                Description = "Na Terra Média, um hobbit chamado Frodo Baggins recebe a tarefa de destruir um anel mágico que pode conceder poder absoluto ao seu possuidor. Ele parte em uma jornada épica com uma comunidade diversificada de companheiros para realizar essa perigosa missão.",
                LaunchYear = 2001,
                Duration = new TimeSpan(2, 58, 0)
            });
            thirdGroup.Add(new Movie()
            {
                Id = 14,
                Name = "Piratas do Caribe: A Maldição do Pérola Negra",
                Description = "O Capitão Jack Sparrow se envolve em uma aventura cheia de ação e pirataria quando embarca em uma missão para resgatar Elizabeth Swann, filha do governador, e recuperar o lendário Pérola Negra, enfrentando ameaças sobrenaturais e um rival astuto.",
                LaunchYear = 2003,
                Duration = new TimeSpan(2, 23, 0)
            });
            thirdGroup.Add(new Movie()
            {
                Id = 15,
                Name = "O Poderoso Chefão",
                Description = "Um épico sobre a família Corleone, liderada pelo patriarca Don Vito Corleone, e seu envolvimento no submundo do crime organizado, destacando os conflitos internos e externos que ameaçam sua estabilidade.",
                LaunchYear = 1972,
                Duration = new TimeSpan(2, 55, 0)
            });


            fourthGroup.Add(new Movie()
            {
                Id = 16,
                Name = "Titanic",
                Description = "Um romance épico que narra a trágica história do naufrágio do RMS Titanic, enquanto segue o relacionamento proibido entre um passageiro de primeira classe e um jovem artista pobre.",
                LaunchYear = 1997,
                Duration = new TimeSpan(3, 14, 0)
            });
            fourthGroup.Add(new Movie()
            {
                Id = 17,
                Name = "Harry Potter e a Pedra Filosofal",
                Description = "O primeiro filme da série Harry Potter, onde um jovem bruxo descobre que é o filho órfão de dois bruxos poderosos e é matriculado na Escola de Magia e Bruxaria de Hogwarts, onde enfrenta desafios e descobre segredos sobre seu passado.",
                LaunchYear = 2001,
                Duration = new TimeSpan(2, 32, 0)
            });
            fourthGroup.Add(new Movie()
            {
                Id = 18,
                Name = "Avatar",
                Description = "Um fuzileiro paraplégico é enviado para o planeta Pandora em uma missão de exploração, mas acaba se envolvendo em um conflito entre os habitantes nativos do planeta, os Na'vi, e a corporação humana que deseja explorar seus recursos naturais.",
                LaunchYear = 2009,
                Duration = new TimeSpan(2, 42, 0)
            });
            fourthGroup.Add(new Movie()
            {
                Id = 19,
                Name = "O Senhor dos Anéis: O Retorno do Rei",
                Description = "O terceiro filme da trilogia O Senhor dos Anéis, onde a sociedade divide-se para enfrentar Sauron e seu exército em uma batalha épica pela Terra Média, enquanto Frodo e Sam se aproximam do Monte da Perdição para destruir o Um Anel.",
                LaunchYear = 2003,
                Duration = new TimeSpan(3, 21, 0)
            });
            fourthGroup.Add(new Movie()
            {
                Id = 20,
                Name = "Jurassic Park",
                Description = "Um bilionário cria um parque de diversões com dinossauros clonados, mas as coisas saem do controle quando uma falha de segurança permite que os dinossauros escapem e ameacem a vida dos visitantes.",
                LaunchYear = 1993,
                Duration = new TimeSpan(2, 7, 0)
            });

            List<GroupMovie> listaGrupos = new List<GroupMovie>()
            {
                firstGroup,
                secondGroup,
                thirdGroup,
                fourthGroup
            };

            return listaGrupos;
        }
        public static List<Movie> GetList()
        {
            List<Movie> list = new List<Movie>();
            list.Add(new Movie() { 
                Id = 1, 
                Name = "Como treinar seu Dragão", 
                Description = "Soluço é um jovem viking que não tem capacidade para lutar contra os dragões, como é a tradição local. Sua vida muda quando ele ajuda um dragão que lhe mostra toda a verdade. Juntos, eles tentam provar que dragões e humanos podem ser amigos.", 
                LaunchYear = 2010,
                Duration = new TimeSpan(1,38,0)
            });
            list.Add(new Movie()
            {
                Id = 2,
                Name = "The Batman",
                Description = "Após dois anos espreitando as ruas como Batman, Bruce Wayne se encontra nas profundezas mais sombrias de Gotham City. Com poucos aliados confiáveis, o vigilante solitário se estabelece como a personificação da vingança para a população.",
                LaunchYear = 2022,
                Duration = new TimeSpan(2, 56, 0)
            });
            list.Add(new Movie()
            {
                Id = 3,
                Name = "Deadpool 2",
                Description = "O supersoldado Cable vem do futuro com a missão de assassinar o jovem mutante Russel e o mercenário Deadpool precisa aprender o que é ser herói de verdade para salvá-lo. Para isso, ele recruta seu velho amigo Colossus e forma o novo grupo X-Force, sempre com o apoio do fiel escudeiro Dopinder.",
                LaunchYear = 2018,
                Duration = new TimeSpan(2, 00, 0)
            });
            list.Add(new Movie()
            {
                Id = 4,
                Name = "Fight Club",
                Description = "Um homem descontente com a sociedade moderna forma um clube de luta subterrâneo onde os homens podem lutar sem restrições. Mas à medida que o clube cresce, ele se envolve em algo muito maior e mais perigoso.",
                LaunchYear = 1999,
                Duration = new TimeSpan(2, 19, 0)
            });
            list.Add(new Movie()
            {
                Id = 5,
                Name = "Interestelar",
                Description = "Um grupo de exploradores viaja através de um buraco de minhoca no espaço em busca de um novo planeta para a humanidade, enquanto enfrentam desafios físicos e temporais que desafiam a compreensão humana.",
                LaunchYear = 2014,
                Duration = new TimeSpan(2, 49, 0)
            });
            list.Add(new Movie()
            {
                Id = 6,
                Name = "Batman The Dark Knight",
                Description = "O Cavaleiro das Trevas enfrenta um novo e desafiador inimigo, o Coringa, que espalha caos e terror em Gotham City. Enquanto isso, Batman também deve lidar com dilemas éticos e morais sobre seu papel como vigilante.",
                LaunchYear = 2008,
                Duration = new TimeSpan(2, 32, 0)
            });
            list.Add(new Movie()
            {
                Id = 7,
                Name = "The Social Network",
                Description = "Um drama que narra a ascensão do Facebook, desde sua criação em um dormitório de faculdade até se tornar uma das maiores redes sociais do mundo, enquanto explora os conflitos e disputas legais entre os fundadores.",
                LaunchYear = 2010,
                Duration = new TimeSpan(2, 0, 0)
            });
            list.Add(new Movie()
            {
                Id = 8,
                Name = "Spider-Man: Into the Spider-Verse",
                Description = "O jovem Miles Morales descobre que há mais de um Homem-Aranha no multiverso quando ele encontra o Peter Parker de uma realidade alternativa. Juntos, eles devem unir forças com outros Homens-Aranha para impedir uma ameaça que pode destruir todas as realidades.",
                LaunchYear = 2018,
                Duration = new TimeSpan(1, 57, 0)
            });
            list.Add(new Movie()
            {
                Id = 9,
                Name = "Iron Man",
                Description = "Tony Stark, um industrialista bilionário e gênio inventor, é sequestrado por terroristas e forçado a construir uma arma devastadora. Em vez disso, ele constrói uma armadura de alta tecnologia para escapar do cativeiro. Determinado a usar sua invenção para o bem, ele se torna o super-herói conhecido como Homem de Ferro.",
                LaunchYear = 2008,
                Duration = new TimeSpan(2, 6, 0)
            });
            list.Add(new Movie()
            {
                Id = 10,
                Name = "Homem-Aranha",
                Description = "Peter Parker, um tímido estudante, é mordido por uma aranha geneticamente modificada e ganha poderes aracnídeos. Ele decide usar suas habilidades para combater o crime como o super-herói Homem-Aranha, enquanto enfrenta desafios pessoais e luta contra vilões perigosos.",
                LaunchYear = 2002,
                Duration = new TimeSpan(2, 1, 0)
            });
            list.Add(new Movie()
            {
                Id = 11,
                Name = "O Rei Leão",
                Description = "Um jovem leão chamado Simba foge após a morte de seu pai, o rei Mufasa, com medo de assumir o trono. Ele precisa enfrentar seu passado e seu tio malévolo Scar para retomar seu lugar como o verdadeiro rei da Pedra do Reino.",
                LaunchYear = 1994,
                Duration = new TimeSpan(1, 28, 0)
            });
            list.Add(new Movie()
            {
                Id = 12,
                Name = "Toy Story",
                Description = "Um filme de animação da Pixar que segue a história de brinquedos que ganham vida quando seus donos não estão por perto. Woody, o cowboy de pano, e Buzz Lightyear, o astronauta do espaço, enfrentam aventuras juntos enquanto aprendem sobre amizade e lealdade.",
                LaunchYear = 1995,
                Duration = new TimeSpan(1, 21, 0)
            });
            list.Add(new Movie()
            {
                Id = 13,
                Name = "O Senhor dos Anéis: A Sociedade do Anel",
                Description = "Na Terra Média, um hobbit chamado Frodo Baggins recebe a tarefa de destruir um anel mágico que pode conceder poder absoluto ao seu possuidor. Ele parte em uma jornada épica com uma comunidade diversificada de companheiros para realizar essa perigosa missão.",
                LaunchYear = 2001,
                Duration = new TimeSpan(2, 58, 0)
            });
            list.Add(new Movie()
            {
                Id = 14,
                Name = "Piratas do Caribe: A Maldição do Pérola Negra",
                Description = "O Capitão Jack Sparrow se envolve em uma aventura cheia de ação e pirataria quando embarca em uma missão para resgatar Elizabeth Swann, filha do governador, e recuperar o lendário Pérola Negra, enfrentando ameaças sobrenaturais e um rival astuto.",
                LaunchYear = 2003,
                Duration = new TimeSpan(2, 23, 0)
            });
            list.Add(new Movie()
            {
                Id = 15,
                Name = "O Poderoso Chefão",
                Description = "Um épico sobre a família Corleone, liderada pelo patriarca Don Vito Corleone, e seu envolvimento no submundo do crime organizado, destacando os conflitos internos e externos que ameaçam sua estabilidade.",
                LaunchYear = 1972,
                Duration = new TimeSpan(2, 55, 0)
            });
            list.Add(new Movie()
            {
                Id = 16,
                Name = "Titanic",
                Description = "Um romance épico que narra a trágica história do naufrágio do RMS Titanic, enquanto segue o relacionamento proibido entre um passageiro de primeira classe e um jovem artista pobre.",
                LaunchYear = 1997,
                Duration = new TimeSpan(3, 14, 0)
            });
            list.Add(new Movie()
            {
                Id = 17,
                Name = "Harry Potter e a Pedra Filosofal",
                Description = "O primeiro filme da série Harry Potter, onde um jovem bruxo descobre que é o filho órfão de dois bruxos poderosos e é matriculado na Escola de Magia e Bruxaria de Hogwarts, onde enfrenta desafios e descobre segredos sobre seu passado.",
                LaunchYear = 2001,
                Duration = new TimeSpan(2, 32, 0)
            });
            list.Add(new Movie()
            {
                Id = 18,
                Name = "Avatar",
                Description = "Um fuzileiro paraplégico é enviado para o planeta Pandora em uma missão de exploração, mas acaba se envolvendo em um conflito entre os habitantes nativos do planeta, os Na'vi, e a corporação humana que deseja explorar seus recursos naturais.",
                LaunchYear = 2009,
                Duration = new TimeSpan(2, 42, 0)
            });
            list.Add(new Movie()
            {
                Id = 19,
                Name = "O Senhor dos Anéis: O Retorno do Rei",
                Description = "O terceiro filme da trilogia O Senhor dos Anéis, onde a sociedade divide-se para enfrentar Sauron e seu exército em uma batalha épica pela Terra Média, enquanto Frodo e Sam se aproximam do Monte da Perdição para destruir o Um Anel.",
                LaunchYear = 2003,
                Duration = new TimeSpan(3, 21, 0)
            });
            list.Add(new Movie()
            {
                Id = 20,
                Name = "Jurassic Park",
                Description = "Um bilionário cria um parque de diversões com dinossauros clonados, mas as coisas saem do controle quando uma falha de segurança permite que os dinossauros escapem e ameacem a vida dos visitantes.",
                LaunchYear = 1993,
                Duration = new TimeSpan(2, 7, 0)
            });
            return list;
        }
    }
}
