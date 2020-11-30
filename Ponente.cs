
using System;

namespace Congreso
{
	
	public class Ponente
	{
		//Acontinuacion los atributos
		
		private string tituloPonencia;
		private string tematica;
		
		
		//Acontinuacion las propiedades
		
		
		public string TituloPonencia{
			
			get{
				return tituloPonencia;
			}
			set{
				tituloPonencia = value;
			}
			
		}
		
		
		public string Tematica{
			
			get{
				return tematica;
			}
			set{
				tematica = value;
			}
			
		}
		
		public Ponente()
		{
		}
	}
}
