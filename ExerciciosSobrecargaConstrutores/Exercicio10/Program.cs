/*
Responda:

1) Defina sobrecarga de métodos e em seguida implemente uma classe onde é expresso um
exemplo.
    R: Sobrecarga de método é quando um mesmo método possui mais de uma formato, com parâmetros diferentes.
    Ex.:
            public class Notas
            {
                
                public void SalvarNotas(double n1)
                {
                    //...
                }

                public void SalvarNotas(double n1, double n2)
                {
                    //...
                }
                
                public void SalvarNotas(List<double> notas)
                {
                    //...
                }
            }
    
2) O que é um construtor?
    R: Um construtor é uma espécie de "método" da classe que é invocado quando o operador new é utilizado 
    durante a criação do objeto (instanciação da classe). Serve para inicializar o objeto com valores
    pre-determinados ou então com valores passados como argumentos para este.

3) O que é um construtor padrão? Quais as suas características?
    R: É o construtor gerado automaticamente quando nenhum outro é definido. Não recebe parâmetros.

*/