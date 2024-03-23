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

    internal class MovieList
    {
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

            return list;
        }
    }
}
