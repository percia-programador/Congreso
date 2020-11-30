
using System;

namespace Congreso
{
	
	public class Participante
	{
		
		//Acontinuacion los atributos
		
		private string nombre;
		private string sexo;
		private string paisResidencia;
		private string telefono;
		private string email;
		
		
		
		//Acontinuacion las propiedades
		
		public string Nombre{
			
			get{
				return nombre;
			}
			set{
				nombre = value;
			}
			
		}
		
		public string Sexo{
			
			get{
				return sexo;
			}
			set{
				sexo = value;
			}
			
		}
			
		public string PaisResidencia{
			
			get{
				return paisResidencia;
			}
			set{
				paisResidencia = value;
			}
			
		}
				
		public string Telefono{
			
			get{
				return telefono;
			}
			set{
				telefono = value;
			}
			
		}
					
		public string Email{
			
			get{
				return email;
			}
			set{
				email = value;
			}
			
		}
		
		
		
		
		
		
		
		public Participante()
		{
		}
	}
}
