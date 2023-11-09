using _12;

internal class Program
{
    private static void Main(string[] args)
    {   
        char opção;
        int i=0;
        Gado[] gados= new Gado[100];
        int abate=0;
        
        
        do
        {
            Console.WriteLine("a) Ler dados do Gado\nb) Destinar gados para o abate\nc) Quantidade total de leite semanal\nd) quantidade total de alimentos consumidos semanalmente\ne) total de leite após o abate\nf) quantidade total de alimento após o abate\ng) Quantidade de gado no abate\nh) Fechar Menu");
            Console.WriteLine("Escolha uma opção: ");
            opção=Convert.ToChar(Console.ReadLine());
            if(opção>='A' && opção<='G')
            {
                opção=Convert.ToChar(opção-'A'+'a');
            }

            if(opção=='a')
            {
                gados[i]= new Gado();
                Console.WriteLine("Informe o código do gado: ");
                gados[i].Cod=Console.ReadLine();

                Console.WriteLine("Informe a quantidade de leite que o gado de código \"{0}\" produz: ",gados[i].Cod);
                gados[i].Leite=Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Informe a quantidade de alimento que o gado de código \"{0}\" consome: ",gados[i].Cod);
                gados[i].Quantalimento=Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Informe a data de nascimento do gado de código \"{0}\"",gados[i].Cod);
                Console.Write("Mês: ");
                gados[i].Mes=Convert.ToInt32(Console.ReadLine());
                Console.Write("Ano: ");
                gados[i].Ano=Convert.ToInt32(Console.ReadLine());

                i++;    



            }
            else if(opção=='b')
            {
                for(int j=0;j<i;j++)
                {
                    if(2023-gados[j].Ano>=5|| gados[j].Leite<40)
                    {
                        gados[j].Abate='S';
                        abate++;
                    }
                    else if(gados[j].Leite>=50 && gados[j].Leite<70 && gados[j].Quantalimento>50)
                    {
                        gados[j].Abate='S';
                        abate++;

                    }
                    else
                    {
                     gados[j].Abate='N';
                    }

                    if(gados[j].Abate=='S')
                    {
                        Console.WriteLine("O gado de código \"{0}\" será abatido",gados[j].Cod);
                    }
                    else
                    {
                        Console.WriteLine("O gado de código \"{0}\" NÃO será abatido",gados[j].Cod);
                    }
                  
                }
                Console.ReadKey();
                
            }
            else if(opção=='c')
            {
                double total=0;

                for(int j=0;j<i;j++)
                {
                    total+= gados[j].Leite;

                }
                Console.WriteLine("A produção total de leite é: "+total);
                Console.ReadKey();
            }
            else if(opção=='d')
            {
                double totalComida=0;
                for(int j=0;j<i;j++)
                {
                    totalComida+= gados[j].Quantalimento;
                }
                Console.WriteLine("O consumo total de Alimento é: "+totalComida);
                Console.ReadKey();
            }
            else if(opção=='e')
            {
                double totalLeiteAbate=0;

                 for(int j=0;j<i;j++)
                {
                    totalLeiteAbate+= gados[j].Leite;

                }
                for(int j=0;j<i;j++)
                {
                    if(gados[j].Abate=='S')
                    {
                        totalLeiteAbate-=gados[j].Leite;
                    }
                    
                }
                Console.WriteLine("O total de Leite que passará a ser  produzido após o abate é: "+totalLeiteAbate);
                Console.ReadKey();
            }
            else if(opção=='f')
            {
                double totalComidaAbate=0;
                for(int j=0;j<i;j++)
                {
                    totalComidaAbate+= gados[j].Quantalimento;
                }
                for(int j=0;j<i;j++)
                {
                    
                    if(gados[j].Abate=='S')
                    {
                        totalComidaAbate-=gados[j].Quantalimento;
                        

                    }
                }
                Console.WriteLine("O total de Alimento que passará a ser consumido após o abate é: "+totalComidaAbate);
                Console.ReadKey();

            }
            else if(opção=='g')
            {
                abate=0;
                for(int j=0;j<i;j++)
                {
                    
                    if(gados[j].Abate=='S')
                    {
                        abate++;

                    }
                }
                
                Console.WriteLine("A quantidade de gados para o abate é: "+abate);
                Console.ReadKey();
                
            }
            Console.Clear();

        }while(opção >='a' && opção<='g');
        Console.WriteLine("Programa encerrado!!!");





    }
}