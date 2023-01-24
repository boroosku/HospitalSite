using System.Text.Json.Serialization;

namespace API.Views;

/// <summary>
/// ����� ��� ������ �� ������ ��������� ������������
/// </summary>
/// <remarks>
/// ������� JsonPropertyName ����� ��� ������������ ��� �������������� ��������� � ������� �����
/// ������� �������, ��� �������� �������� ����������� ����� � ����� � ���������� � ��� ���������� �����
/// �, ��������, ���������������/���������� ����� ������� � ������, � ������������ � ���������� �����
/// </remarks>
public class UserSearchView
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

}