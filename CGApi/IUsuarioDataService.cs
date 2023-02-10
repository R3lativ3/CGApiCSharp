using System;
using CGApi.Models;
using System.Collections.Generic;

namespace CGApi
{
	public interface IUsuarioDataService
	{
		public List<Usuarios> GetAll(); 
		public Usuarios Get(int id);
		public void Add(Usuarios usuario);
		public void Update(Usuarios usuarios);
		public void Delete(int id);
    }
}

