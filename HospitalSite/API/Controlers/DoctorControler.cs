using API.Views;
using Database.Models;
using domain;
using domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

/// <summary>
/// Контроллер для работы с пользователем
/// </summary>
[ApiController]
[Route("doctor")]
public class DoctorControler : ControllerBase
{
    private readonly DoctorService _service;
    public DoctorControler(DoctorService service)
    {
        _service = service;
    }

    [HttpGet("doctorById")] // атрибут для гет запроса
    public ActionResult<DoctorSearchView> GetById(int id)
    {
        var res = _service.GetDoctorById(id);
        if (res.IsFailure)
            return Problem(statusCode: 404, detail: res.Error);

        return Ok(new DoctorSearchView
        {
            Id = res.Value.Id,
            Name = res.Value.Name
        });
    }
    [HttpGet("doctorBySpec")] // атрибут для гет запроса
    public ActionResult<DoctorSearchView> GetDoctorBySpec(DrSpec spec)
    {
        var res = _service.GetDoctorBySpec(spec);
        if (res.IsFailure)
            return Problem(statusCode: 404, detail: res.Error);

        return Ok(new DoctorSearchView
        {
            Id = res.Value.Id,
            Name = res.Value.Name
        });
    }

    //[HttpGet("AllDoctors")] // атрибут для гет запроса
    //public ActionResult<DoctorSearchView> GetAllDoctors()
    //{
    //    var res = _service.GetAllDoctors();
    //    if (res.IsFailure)
    //        return Problem(statusCode: 404, detail: res.Error);

    //    return Ok(new DoctorSearchView
    //    {
    //        Id = res.Value.Id,
    //        Name = res.Value.Name
    //    });
    //}

    [HttpPost("newDoctor")] // атрибут для гет запроса
    public ActionResult<DoctorSearchView> CreateDoctor(NewDoctor newDoctor)
    {
        var res = _service.CreateDoctor(newDoctor);
        if (res.IsFailure)
            return Problem(statusCode: 404, detail: res.Error);

        return Ok(new DoctorSearchView
        {
            Id = res.Value.Id,
            Name = res.Value.Name
        });
    }

    [HttpPost("deleteDoctor")] // атрибут для гет запроса
    public ActionResult<DeleteView> DeleteDoctor(int id)
    {
        var res = _service.DeleteDoctor(id);
        if (res.IsFailure)
            return Problem(statusCode: 404, detail: res.Error);

        return Ok(new DeleteView
        {
            deleted = res.Success
        });
    }

}