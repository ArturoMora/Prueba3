using CapaDatos.contexto;
using CapaDatos.modelos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class EmpresasController : ApiController
    {
        contexto conexion;
        public EmpresasController()
        {
            conexion = new contexto();
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetAll()
        {
            try
            {
                var empresas = await conexion.Empresa.AsNoTracking().ToListAsync();
                return Ok(empresas);

            }catch(Exception e)
            {
                return InternalServerError(e);
            }
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetById(int id)
        {
            try
            {
                var empresa = await conexion.Empresa.Where(x => x.empresaId == id).AsNoTracking().FirstOrDefaultAsync();
                return Ok(empresa);

            }catch(Exception e)
            {
                return InternalServerError(e);
            }
        }

        [HttpPost]
        public async Task<IHttpActionResult> Create([FromBody] Empresa model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest("Error al intentar crear el registro");
                }
                conexion.Empresa.Add(model);
                await conexion.SaveChangesAsync();
                return Ok("Registro creado exitosamente!");
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }

        [HttpPut]
        public async Task<IHttpActionResult> Update(Empresa model)
        {
            try
            {
                var entidad = await conexion.Empresa.Where(x => x.empresaId == model.empresaId).FirstOrDefaultAsync();
                if (entidad != null)
                {
                    conexion.Entry(entidad).CurrentValues.SetValues(model);
                    await conexion.SaveChangesAsync();
                    return Ok("Registro actualizado correctamente!");
                }
                else
                {
                    return BadRequest("El registro no existe en la base de datoss");
                }


            }catch(Exception e)
            {
                return InternalServerError(e);
            }
        }

        public async Task<IHttpActionResult> Delete(int id)
        {
            try
            {
                var entidad = await conexion.Empresa.Where(x => x.empresaId == id).FirstOrDefaultAsync();
                if (entidad != null)
                {
                    conexion.Empresa.Remove(entidad);
                    await conexion.SaveChangesAsync();
                    return Ok("Registro eliminado exitosamente");
                }
                else
                {
                    return BadRequest("El registro no existe en la base de datos");
                }
            }catch(Exception e)
            {
                return InternalServerError(e);
            }
        }
    }
}
