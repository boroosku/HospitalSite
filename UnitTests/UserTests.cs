using domain;
using domain.Repositories;
using domain.Services;

namespace UnitTests
{
    public class UserTests
    {
        private readonly UserService _userService;
        private readonly Mock<IUserRepository> _userRepositoryMock;

        public UserTests()
        {
            // Используем библиотеку Moq, чтобы подготавливать тестовые данные
            // Мы отдаем реализацию интерфейса, но сервису без разницы, что там, ему важно, что удовлетворяется интерфейсу
            // Таким образом мы подкидываем нужные данные для тестовых сценариев, другими словами, "мокаем" (mock) репозиторий 
            _userRepositoryMock = new Mock<IUserRepository>();
            _userService = new UserService(_userRepositoryMock.Object);
        }

        [Fact]
        public void LoginIsEmptyOrNull_ShouldFail()
        {
            var res = _userService.GetUserByLogin(string.Empty);

            Assert.True(res.IsFailure); // �������, ��� ������ ������
            Assert.Equal("Login was not specified", res.Error); // ����������, ��� ������ ������ ��
        }

        [Fact]
        public void UserNotFound_ShouldFail()
        {
            // It.IsAny ��������, ��� �� �������������� ��, ��� ������ ������� ����� ��� ����������� �� ����, ����� ����� �� �������
            // �� ���� � ������ ������, ����� �������� ����� string, ��� ��� �� ��������� �������� ��������, ��� � ����� ������ ���� ������� ����
            _userRepositoryMock.Setup(repository => repository.GetByLogin(It.IsAny<string>()))
                .Returns(() => null);

            var res = _userService.GetUserByLogin("qwertyuiop"); // ��� ������ � ���� ������

            Assert.True(res.IsFailure); // �������, ��� ������ ������
            Assert.Equal("User not found", res.Error); // ����������, ��� ������ ������ ��
        }

        [Fact]
        public void UserCreate_ShouldFail()
        {
            _userRepositoryMock.Setup(repository => repository.CreateUser(It.IsAny<NewUser>()))
        .Returns(() => null);

            NewUser newUser = null;
            var res = _userService.CreateUser(newUser);

            Assert.True(res.IsFailure);
            Assert.Equal("User not created", res.Error);
        }

        [Fact]
        public void CheckUserLoginOrPasswordIsEmptyOrNull_ShouldFail()
        {
            var res = _userService.CheckUserExists(string.Empty, "qwertyuiop");

            Assert.True(res.IsFailure); // �������, ��� ������ ������
            Assert.Equal("Login or Password was not specified", res.Error); // ����������, ��� ������ ������ ��
        }

        [Fact]
        public void CheckUserExists_ShouldFail()
        {
            var res = _userService.CheckUserExists("qwertyuiop", "qwertyuiop");

            Assert.True(res.IsFailure); // �������, ��� ������ ������
            Assert.Equal("User not exists", res.Error); // ����������, ��� ������ ������ ��
        }
    }
}