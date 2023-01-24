using domain;
using System.Text.Json.Serialization;
/// ����� ��� ������ �� ������ ��������� ������������
/// </summary>
/// <remarks>
/// ������� JsonPropertyName ����� ��� ������������ ��� �������������� ��������� � ������� �����
/// ������� �������, ��� �������� �������� ����������� ����� � ����� � ���������� � ��� ���������� �����
/// �, ��������, ���������������/���������� ����� ������� � ������, � ������������ � ���������� �����
/// </remarks>
/// 
namespace API.Views;
public class CreateUserView
{
    /// <summary>
    /// �������������
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }

    /// <summary>
    /// �����
    /// </summary>
    [JsonPropertyName("login")]
    public string Login { get; set; }

    [JsonPropertyName("phoneNumber")]
    public string PhoneNumber { get; set; }

    [JsonPropertyName("password")]
    public string Password { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("role")]
    public UserRole Role { get; set; }
}