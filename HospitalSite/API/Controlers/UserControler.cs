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
[Route("user")]
public class UserController : ControllerBase
{
    private readonly UserService _service;
    public UserController(UserService service)
    {
        _service = service;
    }

    /// <summary>
    /// ����� ����� �� ������
    /// </summary>
    /// <param name="login">�����</param>
    [HttpGet("user")] // ������� ��� ��� �������
    public ActionResult<UserSearchView> GetUserByLogin(string login)
    {

        if (login == string.Empty)
            return Problem(statusCode: 404, detail: "�� ������ �����");

        var userRes = _service.GetUserByLogin(login);
        if (userRes.IsFailure)
            return Problem(statusCode: 404, detail: userRes.Error);

        return Ok(new UserSearchView
        {
            Id = userRes.Value.Id,
            Login = userRes.Value.Login
        });
    }

    [HttpPost("user")] // ������� ��� ��� �������
    public ActionResult<CreateUserView> CreateUser(NewUser newUser)
    {
        var userRes = _service.CreateUser(newUser);
        if (userRes.IsFailure)
            return Problem(statusCode: 404, detail: userRes.Error);

        return Ok(new CreateUserView
        {
            Id = userRes.Value.Id,
            Login = userRes.Value.Login,
            Name = userRes.Value.Name,
            PhoneNumber = userRes.Value.PhoneNumber,
            Role = userRes.Value.Role,
            Password = userRes.Value.Password
        });
    }


}