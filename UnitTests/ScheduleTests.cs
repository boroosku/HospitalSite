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
    public class ScheduleTests
    {
        private readonly ScheduleService _scheduleService;
        private readonly Mock<IScheduleRepository> _scheduleRepositoryMock;

        public ScheduleTests()
        {
            // Используем библиотеку Moq, чтобы подготавливать тестовые данные
            // Мы отдаем реализацию интерфейса, но сервису без разницы, что там, ему важно, что удовлетворяется интерфейсу
            // Таким образом мы подкидываем нужные данные для тестовых сценариев, другими словами, "мокаем" (mock) репозиторий 
            _scheduleRepositoryMock = new Mock<IScheduleRepository>();
            _scheduleService = new ScheduleService(_scheduleRepositoryMock.Object);
        }

        [Fact]
        public void GetScheduleOnSelectedDateSpecificDoctor_ShouldFail()
        {
            var res = _scheduleService.GetScheduleOnSelectedDateSpecificDoctor(DateTime.Now, -1);

            Assert.True(res.IsFailure); // Ожидаем, что вернет ошибку
            Assert.Equal("Schedule not found", res.Error); // убеждаемся, что ошибка именно та
        }

        [Fact]
        public void CreateSchedule_ShouldFail()
        {
            // It.IsAny означает, что мы подготавливаем то, что должен вернуть метод вне зависимости от того, какой логин мы указали
            // То есть в данном случае, можно скормить любой string, так как мы тестируем сценарий ненахода, нам в любом случае надо вернуть нуль
            _scheduleRepositoryMock.Setup(repository => repository.CreateSchedule(It.IsAny<NewSchedule>()))
                .Returns(() => null);

            NewSchedule newSchedule = null;
            var res = _scheduleService.CreateSchedule(newSchedule); // что угодно в виде строки

            Assert.True(res.IsFailure); // Ожидаем, что вернет ошибку
            Assert.Equal("Schedule not created", res.Error); // убеждаемся, что ошибка именно та
        }

        [Fact]
        public void UpdateSchedule_ShouldFail()
        {
            _scheduleRepositoryMock.Setup(repository => repository.UpdateSchedule(-1, It.IsAny<Schedule>()))
        .Returns(() => null);

            Schedule schedule = null;
            var res = _scheduleService.UpdateSchedule(-1, schedule);

            Assert.True(res.IsFailure);
            Assert.Equal("Schedule not updated", res.Error);
        }

        [Fact]
        public void DeleteSchedule_ShouldFail()
        {
            var res = _scheduleService.DeleteSchedule(-1);

            Assert.True(res.IsFailure);
            Assert.Equal("Deletion Error", res.Error); // убеждаемся, что ошибка именно та
        }
    }
}