using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using domain;
using domain.Repositories;
using domain.Services;

namespace UnitTests
{
    public class DoctorTests
    {
        private readonly DoctorService _doctorService;
        private readonly Mock<IDoctorRepository> _doctorRepositoryMock;

        public DoctorTests()
        {
            // Используем библиотеку Moq, чтобы подготавливать тестовые данные
            // Мы отдаем реализацию интерфейса, но сервису без разницы, что там, ему важно, что удовлетворяется интерфейсу
            // Таким образом мы подкидываем нужные данные для тестовых сценариев, другими словами, "мокаем" (mock) репозиторий 
            _doctorRepositoryMock = new Mock<IDoctorRepository>();
            _doctorService = new DoctorService(_doctorRepositoryMock.Object);
        }

        [Fact]
        public void GetDoctorByID_ShouldFail()
        {
            var res = _doctorService.GetDoctorById(-1);

            Assert.True(res.IsFailure); // Ожидаем, что вернет ошибку
            Assert.Equal("Doctor not found", res.Error); // убеждаемся, что ошибка именно та
        }

        [Fact]
        public void GetDoctorBySpec_ShouldFail()
        {
            // It.IsAny означает, что мы подготавливаем то, что должен вернуть метод вне зависимости от того, какой логин мы указали
            // То есть в данном случае, можно скормить любой string, так как мы тестируем сценарий ненахода, нам в любом случае надо вернуть нуль
            _doctorRepositoryMock.Setup(repository => repository.GetBySpec(It.IsAny<DrSpec>()))
                .Returns(() => null);

            DrSpec drSpec = null;
            var res = _doctorService.GetDoctorBySpec(drSpec); // что угодно в виде строки

            Assert.True(res.IsFailure); // Ожидаем, что вернет ошибку
            Assert.Equal("Doctor not found", res.Error); // убеждаемся, что ошибка именно та
        }

        [Fact]
        public void CreateDoctor_ShouldFail()
        {
            _doctorRepositoryMock.Setup(repository => repository.CreateDoctor(It.IsAny<NewDoctor>()))
        .Returns(() => null);

            NewDoctor newDoctor = null;
            var res = _doctorService.CreateDoctor(newDoctor);

            Assert.True(res.IsFailure);
            Assert.Equal("Doctor not created", res.Error);
        }

        [Fact]
        public void GetAllDoctors_ShouldFail()
        {
            var res = _doctorService.GetAllDoctors();

            Assert.True(res.IsFailure);
            Assert.Equal("Failed when triying to get all doctors", res.Error); // убеждаемся, что ошибка именно та
        }

        [Fact]
        public void DeleteDoctor_ShouldFail()
        {
            var res = _doctorService.DeleteDoctor(-1);

            Assert.True(res.IsFailure); // Ожидаем, что вернет ошибку
            Assert.Equal("Deletion Error", res.Error); // убеждаемся, что ошибка именно та
        }
    }
}