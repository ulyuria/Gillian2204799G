﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Gillian2204799G.Server.Data;
using Gillian2204799G.Shared.Domain;
using Gillian2204799G.Server.IRepository;

namespace Gillian2204799G.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelsController : ControllerBase
    {
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        public ModelsController(IUnitOfWork unitOfWork)
        {
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/Models
        [HttpGet]
        //public async Task<ActionResult<IEnumerable<Model>>> GetModels()
        public async Task<IActionResult> GetModels()
        {
            var Models = await _unitOfWork.Models.GetAll();
            return Ok(Models);
        }

        // GET: api/Models/5
        [HttpGet("{id}")]
        public async Task<ActionResult> GetModel(int id)
        {
            var Model = await _unitOfWork.Models.Get(q => q.Id == id);

            if (Model == null)
            {
                return NotFound();
            }

            return Ok(Model);
        }

        // PUT: api/Models/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutModel(int id, Model Model)
        {
            if (id != Model.Id)
            {
                return BadRequest();
            }

            //_context.Entry(Model).State = EntityState.Modified;
            _unitOfWork.Models.Update(Model);

            try
            {
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await ModelExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Models
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Model>> PostModel(Model Model)
        {
            await _unitOfWork.Models.Insert(Model);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetModel", new { id = Model.Id }, Model);
        }

        // DELETE: api/Models/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteModel(int id)
        {
            var Model = await _unitOfWork.Models.Get(q => q.Id == id);
            if (Model == null)
            {
                return NotFound();
            }

            await _unitOfWork.Models.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //private bool ModelExists(int id)
        private async Task<bool> ModelExists(int id)
        {
            //return (_context.Models?.Any(e => e.Id == id)).GetValueOrDefault();
            var Model = await _unitOfWork.Models.Get(q => q.Id == id);
            return Model != null;
        }
    }
}
