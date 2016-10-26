using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace JogoTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variáveis
            //Variáveis de escolhas

            string resposta;
            Boolean avancar = false;
            Boolean gameOver = false;
            string genero = "";

            //Variáveis do personagem

            string nome;
            string nomeMenos;
            string invertidoNome = "";
            int tamanhoNome;
            string arma = "";
            int vida = 10;

            //Variáveis dos itens

            string item;
            int curativo = 0;
            int ouro = 0;

            //Variáveis dos outros personagens

            string vilao = "";
            string vilaoCompleto = "";

            //Capítulo 1 - Apresentação do Doutor X, o garoto misterioso e o Rei de Laveidem 

            //"Qual o seu NOME"

            do
            {
                Console.Clear();
				Console.WriteLine("Olá! Seja bem-vindo ao jogo!\n");
				Console.WriteLine("\nCriado por Kevin e Renato\n");
                Console.WriteLine("Qual o seu nome?\n");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n\t[Digite o seu NOME]\n");
                Console.ResetColor();
                nome = Console.ReadLine();
                if (nome == "")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("*ERRO - insira um nome válido!*");
                    Console.ResetColor();
                    Console.ReadLine();
                }
            } while (nome == "");
            do
            {
                Console.Clear();
                Console.WriteLine("Você é homem ou mulher?\n\n1 - Homem\n2 - Mulher\n");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n\t[Digite 1 ou 2]");
                Console.ResetColor();
                genero = Console.ReadLine();
                if (genero == "1")
                {
                    genero = "o";
                    avancar = true;
                }
                else if (genero == "2")
                {
                    genero = "a";
                    avancar = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n*ERRO - insira um comando válido!*");
                    Console.ResetColor();
                    Console.ReadLine();
                }
            } while (avancar == false);
            resposta = "0";
            avancar = false;            
            //Nome Invertido e Nome do Vilão
            tamanhoNome = nome.Length;
            invertidoNome = Convert.ToString(nome[tamanhoNome - 1]);
            invertidoNome = invertidoNome.ToUpper();
            vilao = invertidoNome.Substring(0, 1);
            vilao = vilao + ". Mir";
            nomeMenos = nome.ToLower();
            for (int x = 2; x <= tamanhoNome; x++)
            {
                invertidoNome += nomeMenos[tamanhoNome - x];
            }
            vilaoCompleto = invertidoNome + " Mir";
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(nome + ", deixe-me apresentar. Sou o Doutor X, um médico e também um pesquisador."
                + "\nVocê está no Reino de Laveidem.\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\t[Aperte ENTER para continuar]");
            Console.ResetColor();
            Console.ReadLine();
            Console.Clear();
            //"Como está se sentindo?"
            do {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Doutor X: Como está se sentindo?\n");
                Console.ResetColor();
                Console.WriteLine("\n1-Estou bem.\n2-Não estou me sentindo bem.\n3-Normal, eu acho...\n");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n\t[Digite 1, 2 ou 3]");
                Console.ResetColor();
                resposta = Console.ReadLine();
                if (resposta == "1")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Doutor X: Que ótimo!");
                    Console.ResetColor();
                    vida += 1;
                    avancar = true;
                    
                } else if (resposta == "2")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Doutor X: Vai dar tudo certo, pode ficar tranquil"+genero+"!");
                    Console.ResetColor();
                    vida -= 1;
                    avancar = true;
                    
                } else if (resposta == "3")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Doutor X: Isso é bom, significa que você está bem.");
                    Console.ResetColor();
                    avancar = true;
                    
                } else {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("*ERRO - insira um nome válido!*");
                    Console.ResetColor();
                    Console.ReadLine();
                }
            } while (avancar == false);
            resposta = "0";
            avancar = false;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\t[Aperte ENTER para continuar]");
            Console.ResetColor();
            Console.ResetColor();
            Console.ReadLine();
            Console.Clear();
            //"Escolha uma arma:"
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Doutor X: Enfim, eu sei que tem muitas perguntas"
                    + ", mas não temos muito tempo.\nPor isso, escolha uma arma:\n");
                Console.ResetColor();
                Console.WriteLine("\n1-Espada de Fogo (representa os seres humanos, a coragem e a força)"
                    +"\n2-Cetro Gélido (representa os seres sobrenaturais, a inteligência)"
                    +"\n3-Arco da Floresta (representa a natureza, o equilíbrio)\n");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n\t[Digite 1, 2 ou 3]");
                Console.ResetColor();
                resposta = Console.ReadLine();
                if (resposta == "1")
                {
                    Console.Clear();
                    arma = "Espada de Fogo";
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Doutor X: A " + arma + " é muito poderosa, ótima escolha!");
                    Console.ResetColor();
                    avancar = true;
                }
                else if (resposta == "2")
                {
                    Console.Clear();
                    arma = "Cetro Gélido";
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Doutor X: O " + arma + " exige um pouco de prática, mas é bem forte.");
                    Console.ResetColor();
                    avancar = true;
                }
                else if (resposta == "3")
                {
                    Console.Clear();
                    arma = "Arco da Floresta";
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Doutor X: O "+arma+" é uma arma muito versátil.");
                    Console.ResetColor();
                    vida += 1;
                    avancar = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("*ERRO - insira um nome válido!*");
                    Console.ResetColor();
                    Console.ReadKey();                    
                }                
            } while (avancar == false);
            resposta = "0";
            avancar = false;
            Console.WriteLine("[- Uma luz forte emana da sua arma (" + arma + "). -]\n");
                            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\t[Aperte ENTER para continuar]");
            Console.ResetColor();
            Console.ReadLine();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Doutor X: Esse brilho... !\n");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\t[Aperte ENTER para continuar]");
            Console.ResetColor();
            Console.ReadLine();
            Console.Clear();
            //Curativo
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Doutor X: " + nome + ". Pegue também este curativo!\n");
            Console.ResetColor();
            Console.WriteLine("[- Você ganhou um curativo! -]\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\t[Aperte ENTER para continuar]");
            Console.ResetColor();
            Console.ReadLine();
            Console.Clear();
            curativo += 1;
            item = "ajuda";
            item += ", curativo";
            //Garoto mascarado            
            Console.WriteLine("[- Um garoto mascarado aparece e rouba as armas restantes do Doutor X -]"
                +"\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\t[Aperte ENTER para continuar]");
            Console.ResetColor();
            Console.ReadLine();
            Console.Clear();
            //Batalha no laboratório (1ª batalha)
            do
            {
                Console.Clear();
                Console.WriteLine("1-Lutar/Item (" + item + ") \n2-Correr\n");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n\t[Digite 1 ou 2]");
                Console.ResetColor();
                resposta = Console.ReadLine();
                if (resposta == "1")
                {
                    resposta = "0";
                    Console.Clear();
                    Console.WriteLine("\n[Digite 1 para atacar ou o nome do item para usar o item ("+item+")]");
                    resposta = Console.ReadLine();
                    if (resposta == "ajuda" || resposta == "AJUDA" || resposta == "Ajuda")
                    {
                        Console.Clear();
                        Console.WriteLine("Ajuda: Digite o número 1 ou escreva o nome do item para usá-lo."
                            + "\n");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n\t[Aperte ENTER para continuar]");
                        Console.ResetColor();
                        Console.ReadLine();
                    }
                    if ((resposta == "curativo" || resposta == "CURATIVO" || resposta == "Curativo") && curativo == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("[- Você usou o curativo e recuperou um pouco da sua vida. -]\n");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n\t[Aperte ENTER para continuar]");
                        Console.ResetColor();
                        curativo -= 1;
                        item = item.Replace(", curativo", "");
                        vida += 1;
                        Console.ReadLine();
                    }
                    if (resposta == "1")
                    {
                        Console.Clear();
                        Console.WriteLine("[- Você atacou o garoto mascarado, mas ele foge, por sorte "
                            +"uma das armas caiu. -]\nDoutor X: Obrigado " + nome + "!\n"
                            +"Graças a você consegui recuperar uma de minhas armas.");
                        avancar = true;                      
                    }
                }
                else if (resposta == "2")
                {
                    Console.Clear();
                    Console.WriteLine("[- Você não conseguiu fugir e levou um golpe de raspão. -]");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Doutor X: " + nome + ", você está bem?\n");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n\t[Aperte ENTER para continuar]");
                    Console.ResetColor();
                    vida -= 1;
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("[- Enquanto você tentava fugir você perdeu o curativo. -]");
                    curativo -= 1;
                    item = item.Replace(", curativo", "");
                    avancar = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("*ERRO - insira um nome válido!*");
                    Console.ResetColor();
                    Console.ReadLine();
                }

            } while (avancar == false);
            resposta = "0";
            avancar = false;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\t[Aperte ENTER para continuar]");
            Console.ResetColor();
            Console.ReadLine();
            Console.Clear();
            //Rei de Laveidem
            Console.WriteLine("[- A porta do laboratório se abre e alguém aparece. -]"
                +"\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\t[Aperte ENTER para continuar]");
            Console.ResetColor();
            Console.ReadLine();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Doutor X: Vossa majestade!\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\t[Aperte ENTER para continuar]");
            Console.ResetColor();
            Console.ReadLine();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Rei: Doutor, vim o mais rápido que pude. É verdade?!\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\t[Aperte ENTER para continuar]");
            Console.ResetColor();
            Console.ReadLine();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Doutor X: No início eu não tinha certeza, mas "+genero+" "+nome+" é "+genero
                +" escolhid"+genero+". Percebi isso depois de ver a arma brilhar.\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\t[Aperte ENTER para continuar]");
            Console.ResetColor();
            Console.ReadLine();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Rei: "+nome+", deixe-me apresentar. Sou o Rei de Laveidem."
                +"\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\t[Aperte ENTER para continuar]");
            Console.ResetColor();
            Console.ReadLine();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Rei: " + nome + ", há uma profecia que dizia que um grande mal "
                    + "estava por vir e que quando este mal chegasse um herói de outro mundo apareceria para"
                    + " abrir o tesouro sagrado e trazer a paz ao Reino de Laveidem."
                    + "\nEste herói é você! Você é "+genero+" únic"+genero+" que pode abrir o tesouro sagrado."
                    + " O tesouro está na Central Oito.\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\t[Aperte ENTER para continuar]");
            Console.ResetColor();
            Console.ReadLine();            
            Console.Clear();
            //"Você aceita esta missão?
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Você aceita esta missão?\n");
                Console.ResetColor();
                Console.WriteLine("\n1 -Sim, claro!\n2-Aceito...");
                resposta = Console.ReadLine();

                if (resposta == "1")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Rei: Excelente!");
                    Console.ResetColor();
                    vida += 1;
                    avancar = true;

                }
                else if (resposta == "2")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Rei: Ótimo!");
                    Console.ResetColor();
                    vida -= 1;
                    avancar = true;

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("*ERRO - insira um nome válido!*");
                    Console.ResetColor();
                    Console.ReadLine();
                }
            } while (avancar == false);
            resposta = "0";
            avancar = false;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\t[Aperte ENTER para continuar]");
            Console.ResetColor();
            Console.ReadLine();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Rei: Pegue esse pote de ouro para te ajudar.\n");
            Console.ResetColor();
            Console.WriteLine("[- Você ganha um pote de ouro! -]");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\t[Aperte ENTER para continuar]");
            Console.ResetColor();
            item += ", ouro";
            ouro += 1;
            Console.ReadLine();
            Console.Clear();
            //Assistente
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Doutor X: "+nome+", a Central Oito é bem próxima daqui, "
                +"a minha assistente vai te mostrar o caminho.");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\t[Aperte ENTER para continuar]");
            Console.ResetColor();
            Console.ReadLine();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Assistente X: " + nome + ", prazer! Sou a Assistente do Doutor X");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\t[Aperte ENTER para continuar]");
            Console.ResetColor();
            Console.ReadLine();
            Console.Clear();

            //Capítulo 2 - Central Oito
            //Começo da jornada
            Console.WriteLine("[- Você se despede do Doutor X e do Rei e sua jornada começa...  -]"
                +"\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\t[Aperte ENTER para continuar]");
            Console.ResetColor();
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("[- Durante o caminho a Assistente do Doutor X conta mais sobre a Central "
                + "Oito -]\n");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Assistente X: "+nome+" , a Central Oito é um centro comercial daqui de "
                +"Laveidem onde se concentram muitos pescadores.\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\t[Aperte ENTER para continuar]");
            Console.ResetColor();
            Console.ReadLine();
            //Senhor pedindo esmola
            Console.Clear();
            Console.WriteLine("[- Após chegar logo na entrada da Central você vê um senhor pedindo esmolas. -]");
            Console.ReadLine();
            do
            {
                Console.Clear();
                Console.WriteLine("[- Doar 1 moeda do pote? -]\n\n1-Sim\n2-Não\n");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n\t[Digite 1 ou 2]");
                resposta = Console.ReadLine();

                if (resposta == "1")
                {
                    Console.Clear();
                    Console.WriteLine("[- No momento em que você vai pegar uma moeda do seu pote de ouro"
                        +" o senhor rouba o seu pote e sai correndo. -]\n[- Rapidamente ele some da sua vista. -]");
                    ouro -= 1;
                    item = item.Replace(", ouro", "");
                    avancar = true;

                }
                else if (resposta == "2")
                {
                    Console.Clear();
                    Console.WriteLine("[- Você não dá nenhuma esmola, logo em seguida aparecem dois guardas"
                        +" que colocam algemas e levam o senhor para um lugar chamado 'Oceano das Águas-Vivas'. -]");
                    ouro -= 1;
                    avancar = true;
                    item = item.Replace(", ouro", "");

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("*ERRO - insira um nome válido!*");
                    Console.ResetColor();
                    Console.ReadLine();
                }
            } while (avancar == false);
            resposta = "0";
            avancar = false;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Assistente X: "+nome+", melhor tomarmos mais cuidado a partir de agora."+
                " Aqui está mais perigoso do que eu lembrava. \nAssistente X: "+nome+", você parece cansad"
                +genero+". -]\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\t[Aperte ENTER para continuar]");
            Console.ResetColor();
            Console.ReadLine();            
            Console.Clear();
            vida -= 1;
            //Identidade do garoto misterioso revelada
            do
            {
                Console.Clear();
                Console.WriteLine("Assistente X: Você está bem?\n[- A sua arma (" + arma + ") brilha e parece"
                    + " apontar para um dos caminhos: -]\n\n1-Oceano das Águas-Vivas\n2-Barcos abandonados\n");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n\t[Digite 1 ou 2]");
                Console.ResetColor();
                resposta = Console.ReadLine();                
                if (resposta == "1" || resposta == "2")
                {                    
                    Console.Clear();
                    Console.WriteLine("[- O garoto mascarado aparece! -]\n");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Garoto mascarado: Espera!"
                        +"\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n\t[Aperte ENTER para continuar]");
                    Console.ResetColor();
                    Console.ReadLine();
                    resposta = "0";
                    Console.Clear();
                    Console.WriteLine("\n[Digite 1 para atacar, 2 para correr ou o nome do item para usar o item (" 
                        + item + ")]");
                    resposta = Console.ReadLine();
                        if (resposta == "ajuda" || resposta == "AJUDA" || resposta == "Ajuda")
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Assistente X: Esse garoto é familiar...");
                        Console.ResetColor();
                        Console.ReadKey();
                    }
                    if ((resposta == "curativo" || resposta == "CURATIVO" || resposta == "Curativo") && curativo == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("[- Você usou o curativo e recuperou um pouco da sua vida. -]");
                        curativo -= 1;
                        item = item.Replace(", curativo", "");
                        vida += 1;
                    }
                    if ((resposta == "ouro"|| resposta == "OURO"|| resposta == "Ouro") && ouro == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("[- Você percebe que o pote de ouro não é útil neste momento, "
                            +"mas já é tarde... O pote de ouro sai rolando e cai no Oceano. -]");
                        ouro -= 1;
                        item = item.Replace(", ouro", "");
                    }                    
                    if(resposta == "1")
                    {
                        Console.Clear();
                        Console.WriteLine("[- O garoto parecia querer falar alguma coisa, mas você acerta um golpe"
                            +" certeiro em sua barriga e o garoto desmaia. -]\n");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n\t[Aperte ENTER para continuar]");
                        Console.ResetColor();
                        vida -= 3;
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("[- Você vasculha os seus pertences e acha uma chave e "
                            +"em seguida tira a máscara dele e... (!) -]\n");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n\t[Aperte ENTER para continuar]");
                        Console.ResetColor();
                        Console.ReadLine();
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Assistente X: "+nome+"! É o Ney, paciente do Doutor X!\n");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n\t[Aperte ENTER para continuar]");
                        Console.ResetColor();
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("[- Com muita dificuldade e tossindo muito o Ney diz: -]\n");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Ney: Pessoal, calma. A culpa é toda minha por fazer isso tudo escondido"
                            +". To-em cuidado com o "
                            +vilao+", ele é per-rigoso! No fi-im eu consegui a chave do tesou-...");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n\t[Aperte ENTER para continuar]");
                        Console.ResetColor();
                        Console.ReadLine();
                        Console.Clear();
                        avancar = true;
                    }
                    else if (resposta == "2")
                    {
                        Console.Clear();
                        Console.WriteLine("[- O garoto tira a máscara e diz: -]\n");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Garoto mascarado: "+nome+"!"
                            +" Espera! Sou eu, o Ney!\nAssistente X: Ney! O que está fazendo aqui? "
                            +"Você ainda está aos cuidados do Doutor X!\n");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n\t[Aperte ENTER para continuar]");
                        Console.ResetColor();
                        Console.ReadLine();
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Ney: Eu sei, mas eu consegui a chave do tesouro, olhem!"
                            + " Estava perto de um ri- (!)\n");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n\t[Aperte ENTER para continuar]");
                        Console.ResetColor();
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("[- Um buraco aparece nas costas do Ney. A pessoa que fez isso"
                            +"se aproxima. -]\n");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n\t[Aperte ENTER para continuar]");
                        Console.ResetColor();
                        Console.ReadLine();
                        avancar = true;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("*ERRO - insira um nome válido!*");
                    Console.ResetColor();
                    Console.ReadLine();
                }
            } while (avancar == false);
            resposta = "0";
            avancar = false;
            Console.Clear();
            //1ª aparição do vilão
            Console.WriteLine("[- " + vilao + " aparece! E sua cabeça dói. -]\n");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(nome + ", venha para o meu castelo no Cemitério de Ocidem, você quer o tesouro"
                + ", certo?\n");
            Console.ResetColor();
            Console.WriteLine("[- "+vilao+" some. -]\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\t[Aperte ENTER para continuar]");
            Console.ResetColor();
            vida -= 2;
            Console.ReadLine();
            if (vida <= 3)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(nome+" estamos ficando sem tempo, vamos nos apressar!"
                    +"\n");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n\t[Aperte ENTER para continuar]");
                Console.ResetColor();
                Console.ReadLine();
            }
            //Capítulo 3 - Batalha Final
            //Indo para o Cemitério
            Console.Clear();
            Console.WriteLine("[- Durante o trajeto da Central Oito para o Cemitério você vê várias pessoas"
                + " machucadas e no decorrer do percurso cadáveres e esqueletos... -]\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\t[Aperte ENTER para continuar]");
            Console.ResetColor();
            Console.ReadLine(); 
            do
            {
                Console.Clear();
                Console.WriteLine("[- Você chega em frente ao castelo e:\n\n1-Toca a campainha\n2-Olha ao seu "
                    + "redor para se certificar que não há nada errado -]\n");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n\t[Digite 1 ou 2]");
                Console.ResetColor();
                resposta = Console.ReadLine();

                if (resposta == "1")
                {

                    Console.Clear();
                    Console.WriteLine("[- Você toca a campainha, as portas se abrem. "
                        + "Ao entrar no castelo rapidamente as portas se fecham e " + vilao + " aparece e diz: -]\n");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine(vilao + ": Bem vindo ao meu castelo!\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n\t[Aperte ENTER para continuar]");
                    Console.ResetColor();
                    avancar = true;

                }
                else if (resposta == "2")
                {
                    Console.Clear();
                    Console.WriteLine("[- No momento em que você resolve olhar ao seu redor "+vilao+" aparece"
                        + " e te empurra para dentro do castelo -]\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n\t[Aperte ENTER para continuar]");
                    Console.ResetColor();
                    vida -= 2;
                    avancar = true;

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("*ERRO - insira um nome válido!*");
                    Console.ResetColor();
                    Console.ReadLine();
                }
            } while (avancar == false);
            resposta = "0";
            avancar = false;
            if (vida <= 0)
            {
                gameOver = true;
            }
            if (gameOver == true)
            {
                Console.Clear();
                Console.WriteLine("[- Você começa a passar mal e desmaia. -]\n\t[FIM DE JOGO]");
                Console.ReadLine();
            }
            else if (gameOver == false)
            {
                //A luta final começa!
                do
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("" + vilao + ": " + nome + ", você é tão ingênu" + genero + " por acreditar naquele"
                        + " Rei e Doutor fajutos, esse mundo não tem salvação, Laveidem morrerá!\n\n");
                    Console.ResetColor();
                    Console.WriteLine("1-Eu acredito no Doutor X! Eu irei salvar este mundo!\n2-Talvez...\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n\t[Digite 1 ou 2]");
                    Console.ResetColor();
                    resposta = Console.ReadLine();

                    if (resposta == "1")
                    {

                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("" + vilao + ": Tome isso!\n");
                        Console.ResetColor();
                        Console.WriteLine("[- " + vilao + " atira uma flecha flamejante "
                            + "em sua direção. -]\n");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Assistente X: Cuidado!\n[- A Assistente X te salva. -]");
                        Console.ResetColor();
                        avancar = true;

                    }
                    else if (resposta == "2")
                    {
                        resposta = "0";
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("" + vilao + ": " + nome + ", então se junte a mim!");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("\n\n1-Se juntar ao " + vilao + ".\n2-Não se juntar ao " + vilao + ".\n");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n\t[Digite 1 ou 2]");
                        Console.ResetColor();
                        avancar = true;
                        resposta = Console.ReadLine();
                        if (resposta == "1")
                        {
                            Console.Clear();
                            Console.WriteLine("[- " + vilao + " ri. -]");
                            gameOver = true;
                        }
                        if (resposta == "2")
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("" + vilao + ": Tome isso!\n");
                            Console.ResetColor();
                            Console.WriteLine("[- O " + vilao + " atira uma flecha flamejante "
                            + "em sua direção. -]\n");
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("Assistente X: Cuidado!\n");
                            Console.ResetColor();
                            Console.WriteLine("[- A Assistente X te salva. -]");
                            avancar = true;
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("*ERRO - insira um nome válido!*");
                        Console.ResetColor();
                        Console.ReadLine();
                    }
                } while (avancar == false);
                resposta = "0";
                avancar = false;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n\t[Aperte ENTER para continuar]");
                Console.ResetColor();
                Console.ReadLine();
                //Explicações e Clímax
                if (gameOver == true)
                {
                    Console.Clear();
                    Console.WriteLine("[- " + vilao + " faz um ritual e alma dele se junta a sua. -]"
                        + "\n[- Laveidem é destruída. -]\n[FIM DE JOGO]");
                    Console.ReadKey();
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("" + vilao + ": " + nome + ", meu nome verdadeiro é " + vilaoCompleto + ". E"
                        + " você sabia que se eu morrer você também morre? Na verdade eu sou seu alter ego."
                        + " Mesmo assim você ainda quer me derrotar? Hahahaha!\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n\t[Aperte ENTER para continuar]");
                    Console.ResetColor();
                    Console.ReadLine();
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("[- A sua arma (" + arma + ") está brilhando novamente! -]"
                            + "\n");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n\t[Aperte ENTER para continuar]");
                        Console.ResetColor();
                        Console.ReadLine();
                        if (arma == "Espada de Fogo")
                        {
                            Console.Clear();
                            Console.WriteLine("[Você adquire o ataque 'Corte de Luz!']");
                            arma = "Corte de Luz";
                            avancar = true;
                        }
                        else if (arma == "Cetro Gélido")
                        {
                            Console.Clear();
                            Console.WriteLine("[Você adquire o ataque 'Disparo do Zero Absoluto!']");
                            arma = "Disparo do Zero Absoluto";
                            avancar = true;
                        }
                        else if (arma == "Arco da Floresta")
                        {
                            Console.Clear();
                            Console.WriteLine("[Você adquire o ataque 'Flecha do destino!']");
                            arma = "Flecha do destino";
                            avancar = true;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("*ERRO - insira um nome válido!*");
                            Console.ResetColor();
                            Console.ReadLine();
                        }
                    } while (avancar == false);
                    resposta = "0";
                    avancar = false;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n\t[Aperte ENTER para continuar]");
                    Console.ResetColor();
                    Console.ReadLine();
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("[- Desferir o ataque " + arma + "? -]\n\n1-Sim\n2-Não\n");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n\t[Digite 1 ou 2]");
                        Console.ResetColor();
                        resposta = Console.ReadLine();

                        if (resposta == "1")
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine(vilaoCompleto + ": Nãoooooooooooo!!!!!!!!!!!\n");
                            Console.ResetColor();
                            Console.WriteLine("[- Uma explosão acontece e"
                                + vilaoCompleto + " desaparece em meio às cinzas. -]");
                            avancar = true;

                        }
                        else if (resposta == "2")
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine(vilaoCompleto + ": Hahaha você acreditou mesmo na história do 'você "
                                + "sabia que se eu morrer você também morre?' o meu verdadeiro objetivo é acabar "
                                + "com você e este mundo.\n");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\n\t[Aperte ENTER para continuar]");
                            Console.ResetColor();
                            Console.ReadLine();
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine(vilaoCompleto + ": Extinção Suprema!!!\n");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\n\t[Aperte ENTER para continuar]");
                            Console.ResetColor();
                            Console.ReadLine();
                            gameOver = true;
                            avancar = true;

                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("*ERRO - insira um nome válido!*");
                            Console.ResetColor();
                            Console.ReadLine();
                        }
                    } while (avancar == false);
                    resposta = "0";
                    avancar = false;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n\t[Aperte ENTER para continuar]");
                    Console.ResetColor();
                    if (gameOver == true)
                    {
                        Console.Clear();
                        Console.WriteLine("[- Tudo o que existia em Laveidem desaparece. -]\n[FIM DE JOGO]");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("[- Você venceu! -]\n[Aperte qualquer tecla para ver o final da história]");
                        Console.ReadKey();
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Doutor Xavier: "+nome+ ", como está se sentindo? [...]");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n\t[Aperte ENTER para continuar]");
                        Console.ResetColor();
                        Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Ney: Ei, você é nov"+genero+" aqui no hospital? Vamos brincar?"
                            + "\n\n\t[Aperte ENTER para continuar]");
                        Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Enfermeira : " + nome + ", parece que você já fez amizade com o Ney.");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n\t[Aperte ENTER para continuar]");
                        Console.ResetColor();
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("[- Alguns meses se passam -]\n" + nome + ": Pai! Mãe! ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("\nPai e Mãe: " +nome+"! Temos ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n\t[Aperte ENTER para continuar]");
                        Console.ResetColor();
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("[- Algumas semanas se passam. -]\n");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Enfermeira : " + nome + ", me chamou? Ahh,"
                            +" o Ney? Ele está na sala 8.\n");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n\t[Aperte ENTER para continuar]");
                        Console.ResetColor();
                        Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Ney : " + nome + "! É, eu não estou muito bem... cof cof Que bom que você conse"
                            + "guiu um doador!\n");
                        Console.ResetColor();
                        Console.WriteLine("[- Depois de alguns dias o Ney morre. -]");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n\t[Aperte ENTER para continuar]");
                        Console.ResetColor();
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("[- Dia da cirurgia. -]\n[- Algumas horas se passam. -]");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n\t[Aperte ENTER para continuar]");
                        Console.ResetColor();
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("[- A cirurgia foi um sucesso. -]");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n\t[Aperte ENTER para continuar]");
                        Console.ResetColor();
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine(vilaoCompleto+ "\n\n\t[Aperte ENTER para continuar]");
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine(vilaoCompleto + " \nRim d"+genero+" "+nome+" \n");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n\t[Aperte ENTER para continuar]");
                        Console.ResetColor();
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine(vilaoCompleto + " \nRim d" + genero + " " + nome + " \n\n[FIM]");
                        Console.ReadLine();
                    }
                }
            }
                        
            Console.ReadKey();
            
        }    
    }
}