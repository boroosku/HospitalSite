using API.Views;
using Database.Models;
using domain;
using domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

/// <summary>
/// ���������� ��� ������ � �������������
/// </summary>
[ApiController]
[Route("appointment")]
public class AppointmentController : ControllerBase
{
    private readonly AppointmentService _service;
    public AppointmentController(AppointmentService service)
    {
        _service = service;
    }

    /// <param name="spec">�����</param>
    [HttpGet("appointment")] // ������� ��� ��� �������
    public ActionResult<GetAppointmentDrSpecView> GetFreeAppointmentDateByDrSpec(DrSpec spec)
    {

        var res = _service.GetFreeAppointmentDateByDrSpec(spec);
        if (res.IsFailure)
            return Problem(statusCode: 404, detail: res.Error);

        return Ok(new GetAppointmentDrSpecView
        {
            time = res.Value
        });
    }
    [HttpPost("appointmentSpec")] // ������� ��� ��� �������
    public ActionResult<MakeAppointmentView> MakeAppointmentOnSelectedDateSpecificDoctor(DateTime time, int id)
    {
        var res = _service.MakeAppointmentOnSelectedDateSpecificDoctor(id, time);
        if (res.IsFailure)
            return Problem(statusCode: 404, detail: res.Error);

        return Ok(new MakeAppointmentView
        {
            AppoinmentStart = res.Value.AppoinmentStart
        });
    }

    [HttpPost("appointmentFree")] // ������� ��� ��� �������
    public ActionResult<MakeAppointmentView> MakeAppointmentOnSelectedDateFreeDoctor(DateTime time, DrSpec spec)
    {
        var res = _service.MakeAppointmentOnSelectedDateFreeDoctor(time, spec);
        if (res.IsFailure)
            return Problem(statusCode: 404, detail: res.Error);

        return Ok(new MakeAppointmentView
        {
            AppoinmentStart = res.Value.AppoinmentStart
        });
    }


}