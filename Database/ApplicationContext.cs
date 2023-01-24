using Database.Models;
using domain;
using Microsoft.EntityFrameworkCore;

namespace drAppointment.DAL;

public class ApplicationContext : DbContext
{
    /// <summary>
    /// Поле юзеров. Через него происходит обращение к таблице юзеров в БД
    /// </summary>
    public DbSet<UserModel> Users { get; set; }
    public DbSet<AppointmentModel> Appointments { get; set; }
    public DbSet<DoctorModel> Doctors { get; set; }
    public DbSet<ScheduleModel> Schedules { get; set; }

    /// <summary>
    /// Это конструктор. Такой параметр нужен, если мы не хотим писать строку
    /// с адресом и паролем к нашей БД здесь
    /// </summary>
    /// <param name="options"></param>
    public ApplicationContext(DbContextOptions options) : base(options) { }

    /// <summary>
    /// Конфигурация сущностей в таблицах
    /// </summary>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // В этом методе можно вставлять ограничения или индексы для столбцов БД.
        // Для примера, мы навесили индекс на столбец логина
        modelBuilder.Entity<AppointmentModel>().HasIndex(model => model.PatientId);
        modelBuilder.Entity<UserModel>().HasIndex(model => model.Id);
        modelBuilder.Entity<DoctorModel>().HasIndex(model => model.Id);
        modelBuilder.Entity<ScheduleModel>().HasIndex(model => model.Id);
    }
}