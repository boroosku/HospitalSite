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
public class GetAppointmentDrSpecView
{
    /// <summary>
    /// �������������
    /// </summary>

    /// <summary>
    /// �����
    /// </summary>
    [JsonPropertyName("Date")]
    public DateTime[] time { get; set; }

}