using DIO_Series.Interfaces;

namespace DIO_Series.Classes
{
    internal class SerieRepositorio : IRepositorio<Serie>
    {
		private List<Serie> listaSerie = new List<Serie>();
		
		
		 
		
		public void Atualiza(int id, Serie objeto)
		{

				ExisteId(id);
				listaSerie[id] = objeto;
		}

		public void Exclui(int id)
		{
			ExisteId(id);
			listaSerie[id].Excluir();
		}

		public void Insere(Serie objeto)
		{
			listaSerie.Add(objeto);
		}

		public List<Serie> Lista()
		{
			return listaSerie;
		}

		public int ProximoId()
		{
			return listaSerie.Count;
		}

		public Serie RetornaPorId(int id)
		{
			ExisteId(id);
			return listaSerie[id];
		}







		private void ExisteId(int id)
		{

			try
			{
                _ = listaSerie[id];
			}
			catch (ArgumentOutOfRangeException)
			{
                
				throw new ArgumentOutOfRangeException(" Id não encotrado tente novamente!!!");
			}

		}

	}
}
