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
[Route("schedule")]
public class ScheduleController : ControllerBase
{
    private readonly ScheduleService _service;
    public ScheduleController(ScheduleService service)
    {
        _service = service;
    }

    [HttpGet("schedule")] // атрибут для гет запроса
    public ActionResult<ScheduleSearchView> GetScheduleOnSelectedDateSpecificDoctor(DateTime time, int id)
    {

        var res = _service.GetScheduleOnSelectedDateSpecificDoctor(time, id);
        if (res.IsFailure)
            return Problem(statusCode: 404, detail: res.Error);

        return Ok(new ScheduleSearchView
        {
            Id = res.Value.Id,
            DayStart = res.Value.DayStart,
            DayEnd = res.Value.DayEnd
        });
    }
    [HttpPost("createSchedule")] // атрибут для гет запроса
    public ActionResult<ScheduleSearchView> CreateSchedule(NewSchedule newSchedule)
    {
        var res = _service.CreateSchedule(newSchedule);
        if (res.IsFailure)
            return Problem(statusCode: 404, detail: res.Error);

        return Ok(new ScheduleSearchView
        {
            Id = res.Value.Id,
            DayStart = res.Value.DayStart,
            DayEnd = res.Value.DayEnd
        });
    }

    [HttpPost("updateSchedule")] // атрибут для гет запроса
    public ActionResult<ScheduleSearchView> UpdateSchedule(int id, Schedule newSchedule)
    {
        var res = _service.UpdateSchedule(id, newSchedule);
        if (res.IsFailure)
            return Problem(statusCode: 404, detail: res.Error);

        return Ok(new ScheduleSearchView
        {
            Id = res.Value.Id,
            DayStart = res.Value.DayStart,
            DayEnd = res.Value.DayEnd
        });
    }

    [HttpPost("deleteSchedule")] // атрибут для гет запроса
    public ActionResult<DeleteView> DeleteSchedule(int id)
    {
        var res = _service.DeleteSchedule(id);
        if (res.IsFailure)
            return Problem(statusCode: 404, detail: res.Error);

        return Ok(new DeleteView
        {
        });
    }


}