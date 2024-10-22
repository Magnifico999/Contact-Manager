using System.Collections;
using AutoMapper;
using Contact.Api.DTO;
using Contact.Api.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Contact.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   // [Authorize]
    public class ContactController : ControllerBase
    {
        private readonly BlzDbContactContext _dbContactContext;
        private readonly IMapper _mapper;
        private readonly ILogger<ContactController> _logger;

        public ContactController(ILogger<ContactController> logger, IMapper mapper, BlzDbContactContext dbContactContext)
        {
            _logger = logger;
            _mapper = mapper;
            _dbContactContext = dbContactContext;
        }


        [HttpGet]
        [Route("GetContacts")]
        //[Authorize(Roles = "Admin")]
        public async Task<ActionResult<IEnumerable<ContactDto>>> GetContacts()
        {
            List<ContactDto> contactlist = new List<ContactDto>();
            try
            {
                var list = await _dbContactContext.Contacts.ToListAsync();
                if (list == null || list.Count == 0)
                {
                    _logger.LogError($"Record Not found: {nameof(GetContact)}");
                    return NotFound();
                }
                contactlist = (List<ContactDto>)_mapper.Map<IEnumerable<ContactDto>>(list);
            }
            catch (Exception ex)
            {
                _logger.LogError($"error performing Get  contact: {nameof(GetContact)}");
            }
            
            return Ok(contactlist);
        }

        [HttpGet("{id}")]
        // [Route("GetContactById")]
       // [Authorize(Roles = "Admin, User")]
        public async Task<ActionResult<ContactDto>> GetContact(int id)
        {
            ContactDto contacts = new ContactDto();
            try
            {
                var contact = await _dbContactContext.Contacts.FindAsync(id);
                if (contact == null)
                {
                    _logger.LogError($"Record Not Found: {nameof(GetContact)}-ID:{id}");
                    return NotFound();
                }

                contacts = _mapper.Map<ContactDto>(contact);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error performing GetcontactById in: {nameof(GetContact)}-ID:{id}");
            }

            return Ok(contacts);
        }


        [HttpPost]
        [Route("AddContact")]
        public async Task<ActionResult<ContactDto>> AddNewContact(ContactDto contact)
        {
            try
            {
                if (contact == null)
                {
                    _logger.LogError($"Require contact info: {nameof(AddNewContact)}");
                    return NotFound();
                }

                var contacts = _mapper.Map<Models.Contact>(contact);
                await _dbContactContext.Contacts.AddAsync(contacts);
                await _dbContactContext.SaveChangesAsync();
                return CreatedAtAction(nameof(AddNewContact), new { id = contacts.Id }, contacts);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error performing save operation in {nameof(AddNewContact)}");
                return StatusCode(500, ex.ToString());
            }
            
        }


        [HttpPut("{id}")]
        // [Route("UpdateContact")]
      //  [Authorize(Roles = "Admin,User")]
        public async Task<ActionResult<ContactDto>> EditContact(int id, ContactDto contactDto)
        {
            if (id <= 0)
            {
                _logger.LogError($"Update Id is invalid: {nameof(EditContact)}-ID:{id}");
                return BadRequest();
            }

            var contact = await _dbContactContext.Contacts.FindAsync(id);
            if (contact == null)
            {
                _logger.LogError($"Record Not found: {nameof(EditContact)}-ID:{id}");
                return NotFound();
            }

            _mapper.Map(contactDto, contact);
            _dbContactContext.Entry(contact).State = EntityState.Modified;
            await _dbContactContext.SaveChangesAsync();
            return NoContent();
        }



        [HttpDelete("{id}")]
        //[Route("DeleteContact")]
        // [Authorize(Roles = "Admin")]
        public async Task<ActionResult> DeleteContact(int id)
        {
            var contact = await _dbContactContext.Contacts.FindAsync(id);
            if (contact == null)
            {
                _logger.LogError($"Record Not found: {nameof(DeleteContact)}-ID:{id}");
                return NotFound();
            }
            _dbContactContext.Contacts.Remove(contact);
            await _dbContactContext.SaveChangesAsync();
            return Ok();
        }
    }
}
