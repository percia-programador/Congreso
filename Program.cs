
using System;

namespace Congreso
{
	class Program
	{
		public static void Main(string[] args)
		{
			int op;
			
			do{
				Console.WriteLine("1.Introducir participante.\n2. Mostrar Ponenetes.\n3. Mostrar oyentes. \n4. Buscar participante.\n5. Salir");	
				Console.WriteLine("Digita tu opcion : ");
				op = Convert.ToInt32(Console.ReadLine());
				
				switch(op){
					case 1:
						
						int opc;
						do{
						Console.WriteLine("1. Introducir Ponente. \n2. Introducir Oyente. \n3. Regresar");
						Console.WriteLine("Digita tu opcion : ");
						opc = Convert.ToInt32(Console.ReadLine());
						
						switch(opc){
							case 1:
								Console.WriteLine("LLamar al metodo IntroducirPonente");
								break;
							case 2:
								Console.WriteLine("LLamar al metodo IntroducirOyentes");
								break;
							case 3:
								Console.WriteLine("SALIR");
								break;
						}
						
						}while(opc != 3);
						
						break;
					case 2:
							Console.WriteLine("LLamar al metodo IntroducirParticipante");						
							
						break;
					case 3:
						
							Console.WriteLine("LLamar al metodo MostrarPonentes");
						
						break;
					case 4:
						
							Console.WriteLine("LLamar al metodo BuscarParticipante");
						
						break;
					case 5:
						
							Console.WriteLine("Salir de todo");	
						
						break;
				}
				
			}while(op != 5);
			
			
			Console.ReadKey();
		}
	}
}