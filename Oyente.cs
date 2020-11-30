
using System;

namespace Congreso
{

	public class Oyente
	{
		//Acontinuacion los atributos
		
		private string gradoAcademico;
		
		//Acontinuacion las propiedades
		
		public string GradoAcademico{
			
			get{
				return gradoAcademico;
			}
			set{
				gradoAcademico = value;
			}
			
		}
		
		public Oyente()
		{
		}
	}
}
