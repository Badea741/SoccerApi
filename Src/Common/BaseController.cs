// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CommonGenericClasses;

using AutoMapper;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

#nullable disable

[ApiController, Route("api/[controller]")]

public abstract class BaseController<TEntity, TDto> : ControllerBase
    where TEntity : BaseEntity
    where TDto : BaseDto
{
    protected readonly IBaseUnitOfWork<TEntity> _unitOfWork;

    protected IMapper _mapper;
    protected readonly AbstractValidator<TEntity> _validator;

    public BaseController(IBaseUnitOfWork<TEntity> unitOfWork,
                          IMapper mapper,
                          AbstractValidator<TEntity> validator
                         )
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _validator = validator;
    }
    // DELETE api/<ProductsController>/5
    [HttpDelete("{id}")]
    public virtual async Task<ActionResult> Delete(Guid id)
    {

        TEntity entity = await _unitOfWork.DeleteByIdAsync(id);
        await _unitOfWork.SaveAsync();
        return Ok(_mapper.Map<TDto>(entity));
    }

    // GET: api/<ProductsController>
    [HttpGet]
    public virtual async Task<IActionResult> Get()
    {
        List<TEntity> entities = await _unitOfWork.ReadAllAsync();
        return Ok(entities.Select(product => _mapper.Map<TDto>(product)));
    }

    // GET api/<ProductsController>/5
    [HttpGet("{id}")]
    public virtual async Task<IActionResult> Get(Guid id)
    {
        TEntity entity = await _unitOfWork.ReadByIdAsync(id);
        TDto entityViewModel = _mapper.Map<TDto>(entity);

        return Ok(entityViewModel);
    }

    // POST api/<ProductsController>
    [HttpPost]
    public virtual async Task<IActionResult> Post([FromBody] TDto entityViewModel)
    {
        TEntity entity = _mapper.Map<TEntity>(entityViewModel);

        ValidationResult result = await _validator.ValidateAsync(entity);
        if (!result.IsValid)
            return BadRequest(result.Errors.Select(e => e.ErrorMessage));

        entity = await _unitOfWork.CreateAsync(entity);
        try
        {
            await _unitOfWork.SaveAsync();
            return CreatedAtAction(nameof(Get), new { id = entity.Id }, entity);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.InnerException.Message);
        }
    }

    // PUT api/<ProductsController>/5
    [HttpPut]
    public virtual async Task<IActionResult> Put([FromBody] TEntity entity)
    {
        entity = _unitOfWork.Update(entity);
        try
        {
            await _unitOfWork.SaveAsync();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.InnerException.Message);
        }

        return Ok(_mapper.Map<TDto>(entity));
    }
}
