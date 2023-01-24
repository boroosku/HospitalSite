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
public class DoctorSearchView
{
    /// <summary>
    /// �������������
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }

    /// <summary>
    /// �����
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

}