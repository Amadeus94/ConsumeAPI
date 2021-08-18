using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ApiLibrary;
using AutoMapper;
using API.Interfaces;
using API.Entities;
using API.Data;
using ApiLibrary.Models;

namespace API.Controllers
{
    [Route("api/[controller]")]
    public class ConsumeApiController : Controller
    {
        private readonly IActivityRepository _repository;
        private readonly IMapper _mapper;
        private readonly DataContext _context;
        public ConsumeApiController(IActivityRepository repository, IMapper mapper, DataContext context)
        {
            _context = context;
            _mapper = mapper;
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActivityModel> fetchNewActivity()
        {
            var activity = await ActivityProcessor.LoadActivity();
            var entityToStore = _mapper.Map<ActivityEntity>(activity);

            _repository.StoreEntity(entityToStore);
            return activity;
        }
    }
}