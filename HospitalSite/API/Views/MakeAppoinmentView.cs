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
public class MakeAppointmentView
{
    /// <summary>
    /// �������������
    /// </summary>

    /// <summary>
    /// �����
    /// </summary>
    [JsonPropertyName("appointmentStart")]
    public DateTime AppoinmentStart { get; set; }

}