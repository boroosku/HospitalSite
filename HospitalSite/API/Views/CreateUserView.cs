using domain;
using System.Text.Json.Serialization;
/// Вьюха для ответа на запрос получения пользователя
/// </summary>
/// <remarks>
/// Атрибут JsonPropertyName нужен для сериализации или десериализации сообщений в формате джсон
/// Простым словами, эти атрибуты помогают сконвертить класс в джсон с указанными в них названиями полей
/// И, наоборот, десериализовать/распарсить джсон обратно в объект, в соответствии с названиями полей
/// </remarks>
/// 
namespace API.Views;
public class CreateUserView
{
    /// <summary>
    /// Идентификатор
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }

    /// <summary>
    /// Логин
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