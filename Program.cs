using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edka.Sa05
{
    internal class Program
    {
        public static List<Disciplina> disciplinas = new List<Disciplina>
    {
        new Disciplina{Nome="Neurociência e Aprendizagem",DataInicial=new DateTime(2022,08,08),DataFinal= new (2022,09,12)},
        new Disciplina{Nome="Habilidades Socio Emocionais",DataInicial=new DateTime(2022,08,10),DataFinal= new (2022,08,24)},
        new Disciplina{Nome="Felicidade",DataInicial=new DateTime(2022,08,31),DataFinal=new(2022,09,14)},
        new Disciplina{Nome="Teoria do desenvolvimento humano e da aprendizagem",DataInicial=new DateTime(2022,08,19),DataFinal=new(2022,09,24)},
        new Disciplina{Nome="Planejamento Pedagogico",DataInicial=new DateTime(2022,08,27),DataFinal=new(2022,10,23)},
        new Disciplina{Nome="Educação inclusiva e Cidadania",DataInicial=new DateTime(2022,09,21),DataFinal=new(2022,11,09)},
        new Disciplina{Nome="Gestão da Sala de Aula",DataInicial=new DateTime(2022,11,16),DataFinal=new(2022,12,30)},
        new Disciplina{Nome="Met.Dinâmicas e inovativas",DataInicial=new DateTime(2022,10,31),DataFinal=new(2022,11,14)},
        new Disciplina{Nome="Projeto Integrador",DataInicial=new DateTime(2022,11,21),DataFinal=new(2022,12,05)},
        new Disciplina{Nome="Avaliação Por Competências",DataInicial=new DateTime(2023,01,01),DataFinal=new(2022,09,12)},
        new Disciplina{Nome="Apreindizagem Por Competências",DataInicial=new DateTime(2023,01,02),DataFinal=new(2023,01,03)},
        new Disciplina{Nome="Pratica Docente à Distância",DataInicial=new DateTime(2023,01,02),DataFinal=new(2023,01,03)},
        new Disciplina{Nome="Legislação e diretrizes da Educação Profissional e tecnologica",DataInicial=new DateTime(2023,01,04),DataFinal=new(2023,01,05)},
        new Disciplina{Nome="Ambientes de Aprendizagem Inovativos",DataInicial=new DateTime(2023,01,05),DataFinal=new(2024,01,06)}
    };


        static void Main(string[] args)
        {
            var OrdemIncio = from d in disciplinas
                             orderby d.DataFinal ascending
                             select d;
            foreach (var d in OrdemIncio)
            {
                Console.WriteLine(d);
            }
            Console.ReadKey();


        }
    
        
        }
    } 
