using domain;
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
public class ScheduleSearchView
{
    /// <summary>
    /// �������������
    /// </summary>

    /// <summary>
    /// �����
    /// </summary>
    [JsonPropertyName("Id")]
    public int Id { get; set; }

    [JsonPropertyName("DayStart")]
    public DateTime DayStart { get; set; }

    [JsonPropertyName("DayEnd")]
    public DateTime DayEnd{ get; set; }

}