using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Api3.Controllers
{
    public class TableController : ApiController
    {
        // GET: api/Person
        public IEnumerable<Table> Get()
        {
            using (Entities c = new Entities())
            {
                return c.Table.ToList();
            }
        }

        // GET: api/Person/5
        public Table Get(int id)
        {
            using (Entities c = new Entities())
            {
                return c.Table.Find(id);
            }
        }

        // POST: api/Person
        public void Post([FromBody]Table value)
        {
            try
            {
                using (Entities c = new Entities())
                {
                    c.Table.Add(value);
                    c.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw;
            }            
        }

        // PUT: api/Person/5
        public void Put(int id, [FromBody]Table value)
        {
            using (Entities c = new Entities())
            {
                var obj = c.Table.Find(id);
                obj.Nombre = value.Nombre;
                obj.Edad = value.Edad;
                obj.Activo = value.Activo;
                c.SaveChanges();
            }
        }

        // DELETE: api/Person/5
        public void Delete(int id)
        {
            using (Entities c = new Entities())
            {                
                c.Table.Remove(c.Table.Find(id));
                c.SaveChanges();
            }
        }
    }
}
